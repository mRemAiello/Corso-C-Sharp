using System.Drawing;
using System.Windows.Forms;

namespace WinFormsBase;

public class EventDemoForm : Form
{
    private readonly Label _statusLabel;
    private readonly Button _clickButton;
    private readonly Button _hoverButton;
    private readonly TextBox _inputTextBox;
    private readonly Button _showTextButton;
    private readonly Label _textOutputLabel;

    public EventDemoForm()
    {
        Text = "WinForms - Eventi di base";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(520, 320);
        MinimumSize = new Size(480, 300);

        var mainLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 5,
            Padding = new Padding(16),
            AutoSize = true
        };
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

        var titleLabel = new Label
        {
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold),
            Text = "Esempio di eventi in WinForms"
        };

        var eventsPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            Margin = new Padding(0, 16, 0, 0)
        };

        _clickButton = new Button
        {
            AutoSize = true,
            Text = "Click"
        };
        _clickButton.Click += (_, _) => UpdateStatus("Hai premuto il pulsante di click.");

        _hoverButton = new Button
        {
            AutoSize = true,
            Text = "Passa il mouse qui"
        };
        _hoverButton.MouseEnter += (_, _) => UpdateStatus("Il mouse è sopra il pulsante.");
        _hoverButton.MouseLeave += (_, _) => UpdateStatus("Il mouse ha lasciato il pulsante.");

        eventsPanel.Controls.Add(_clickButton);
        eventsPanel.Controls.Add(_hoverButton);

        var inputPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            FlowDirection = FlowDirection.LeftToRight,
            WrapContents = false,
            Margin = new Padding(0, 16, 0, 0)
        };

        _inputTextBox = new TextBox
        {
            Width = 240,
            PlaceholderText = "Digita qualcosa..."
        };

        _showTextButton = new Button
        {
            AutoSize = true,
            Text = "Mostra testo"
        };
        _showTextButton.Click += (_, _) => ShowTypedText();

        inputPanel.Controls.Add(_inputTextBox);
        inputPanel.Controls.Add(_showTextButton);

        _textOutputLabel = new Label
        {
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Italic),
            Margin = new Padding(0, 16, 0, 0),
            Text = "Il testo digitato apparirà qui."
        };

        _statusLabel = new Label
        {
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            BorderStyle = BorderStyle.FixedSingle,
            Margin = new Padding(0, 16, 0, 0),
            Height = 40,
            Text = "Interagisci con i pulsanti per vedere gli eventi."
        };

        mainLayout.Controls.Add(titleLabel, 0, 0);
        mainLayout.Controls.Add(eventsPanel, 0, 1);
        mainLayout.Controls.Add(inputPanel, 0, 2);
        mainLayout.Controls.Add(_textOutputLabel, 0, 3);
        mainLayout.Controls.Add(_statusLabel, 0, 4);

        AcceptButton = _showTextButton;

        Controls.Add(mainLayout);
    }

    private void ShowTypedText()
    {
        var testo = _inputTextBox.Text;
        _textOutputLabel.Text = string.IsNullOrWhiteSpace(testo)
            ? "Nessun testo da mostrare."
            : $"Hai scritto: {testo}";
        UpdateStatus("Testo mostrato nell'etichetta.");
    }

    private void UpdateStatus(string message)
    {
        _statusLabel.Text = message;
    }
}
