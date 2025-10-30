using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsBase;

/// <summary>
/// Finestra che mostra come popolare una <see cref="ListBox"/> da un elenco in memoria
/// e come salvare/caricare i dati da un file di testo.
/// </summary>
public class ListPersistenceForm : Form
{
    private readonly List<string> _items = new();

    private readonly ListBox _itemsListBox;
    private readonly TextBox _inputTextBox;
    private readonly Label _statusLabel;

    public ListPersistenceForm()
    {
        Text = "Gestione elenco utenti";
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new System.Drawing.Size(540, 420);

        var mainLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 5,
            Padding = new Padding(16)
        };
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        var titleLabel = new Label
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            Text = "Esempio di popolamento di una ListBox e persistenza su file di testo.",
            Font = new System.Drawing.Font(System.Drawing.FontFamily.GenericSansSerif, 12, System.Drawing.FontStyle.Bold),
            Margin = new Padding(0, 0, 0, 12)
        };

        var inputPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            AutoSize = true
        };
        inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

        _inputTextBox = new TextBox
        {
            PlaceholderText = "Aggiungi un nuovo elemento",
            Dock = DockStyle.Fill,
            Margin = new Padding(0, 0, 8, 0)
        };

        var addButton = new Button
        {
            AutoSize = true,
            Text = "Aggiungi"
        };
        addButton.Click += OnAddItem;

        inputPanel.Controls.Add(_inputTextBox, 0, 0);
        inputPanel.Controls.Add(addButton, 1, 0);

        _itemsListBox = new ListBox
        {
            Dock = DockStyle.Fill,
            Height = 240
        };

        var actionsPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.RightToLeft,
            AutoSize = true
        };

        var saveButton = new Button
        {
            AutoSize = true,
            Text = "Salva su file"
        };
        saveButton.Click += OnSaveToFile;

        var loadButton = new Button
        {
            AutoSize = true,
            Text = "Carica da file"
        };
        loadButton.Click += OnLoadFromFile;

        var removeButton = new Button
        {
            AutoSize = true,
            Text = "Rimuovi selezionato"
        };
        removeButton.Click += OnRemoveSelected;

        var resetButton = new Button
        {
            AutoSize = true,
            Text = "Ripristina elenco iniziale"
        };
        resetButton.Click += (_, _) => LoadDefaultItems();

        actionsPanel.Controls.Add(saveButton);
        actionsPanel.Controls.Add(loadButton);
        actionsPanel.Controls.Add(removeButton);
        actionsPanel.Controls.Add(resetButton);

        _statusLabel = new Label
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            Margin = new Padding(0, 8, 0, 0)
        };

        mainLayout.Controls.Add(titleLabel, 0, 0);
        mainLayout.Controls.Add(inputPanel, 0, 1);
        mainLayout.Controls.Add(_itemsListBox, 0, 2);
        mainLayout.Controls.Add(actionsPanel, 0, 3);
        mainLayout.Controls.Add(_statusLabel, 0, 4);

        Controls.Add(mainLayout);

        AcceptButton = addButton;

        LoadDefaultItems();
    }

    private void LoadDefaultItems()
    {
        _items.Clear();
        _items.AddRange(new[]
        {
            "Mario Rossi",
            "Giulia Verdi",
            "Luca Bianchi",
            "Anna Neri"
        });

        UpdateListBox();
        ShowStatus($"Caricati {_items.Count} elementi dalla memoria.");
    }

    private void OnAddItem(object? sender, EventArgs e)
    {
        var text = _inputTextBox.Text.Trim();
        if (string.IsNullOrEmpty(text))
        {
            ShowStatus("Inserisci un testo prima di aggiungere un elemento.");
            return;
        }

        _items.Add(text);
        UpdateListBox();
        _inputTextBox.Clear();
        ShowStatus($"Aggiunto \"{text}\" all'elenco.");
    }

    private void OnRemoveSelected(object? sender, EventArgs e)
    {
        if (_itemsListBox.SelectedItem is not string selected)
        {
            ShowStatus("Seleziona un elemento da rimuovere.");
            return;
        }

        _items.Remove(selected);
        UpdateListBox();
        ShowStatus($"Rimosso \"{selected}\" dall'elenco.");
    }

    private void OnSaveToFile(object? sender, EventArgs e)
    {
        using var dialog = new SaveFileDialog
        {
            Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*",
            FileName = "elenco-utenti.txt",
            Title = "Salva elenco su file"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            File.WriteAllLines(dialog.FileName, _items);
            ShowStatus($"Elenco salvato in {Path.GetFileName(dialog.FileName)}.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Impossibile salvare il file.\nDettagli: {ex.Message}", "Errore di salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OnLoadFromFile(object? sender, EventArgs e)
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "File di testo (*.txt)|*.txt|Tutti i file (*.*)|*.*",
            Title = "Carica elenco da file"
        };

        if (dialog.ShowDialog(this) != DialogResult.OK)
        {
            return;
        }

        try
        {
            var lines = File.ReadAllLines(dialog.FileName)
                .Select(line => line.Trim())
                .Where(line => !string.IsNullOrEmpty(line))
                .ToList();

            _items.Clear();
            _items.AddRange(lines);
            UpdateListBox();

            ShowStatus($"Caricati {_items.Count} elementi da {Path.GetFileName(dialog.FileName)}.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(this, $"Impossibile caricare il file.\nDettagli: {ex.Message}", "Errore di caricamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void UpdateListBox()
    {
        _itemsListBox.BeginUpdate();
        _itemsListBox.Items.Clear();
        foreach (var item in _items)
        {
            _itemsListBox.Items.Add(item);
        }
        _itemsListBox.EndUpdate();
    }

    private void ShowStatus(string message)
    {
        _statusLabel.Text = message;
    }
}
