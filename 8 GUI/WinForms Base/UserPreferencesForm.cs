namespace WinFormsBase;

public class UserPreferencesForm : Form
{
    private RadioButton? _lightThemeRadio;
    private RadioButton? _darkThemeRadio;
    private RadioButton? _systemThemeRadio;

    private CheckBox? _emailCheckbox;
    private CheckBox? _smsCheckbox;
    private CheckBox? _pushCheckbox;

    private Button? _saveButton;
    private Button? _resetButton;
    private Button? _closeButton;

    private Label? _summaryLabel;

    Label _titleLabel = new()
    {
        Dock = DockStyle.Top,
        Height = 50,
        Text = "Imposta le tue preferenze",
        Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Bold),
        TextAlign = ContentAlignment.MiddleCenter,
        Margin = new Padding(0, 0, 0, 12)
    };

    public UserPreferencesForm()
    {
        Text = "Preferenze utente";
        StartPosition = FormStartPosition.CenterScreen;
        MinimumSize = new Size(550, 400);
        MaximumSize = new Size(700, 500);
        ClientSize = new Size(700, 500);

        //
        InitRadioButtons();
        InitCheckboxes();
        InitActionButtons();

        //
        var mainLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 4,
            Padding = new Padding(16)
        };
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        var preferencesLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1,
            AutoSize = true
        };
        preferencesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        preferencesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

        var themeGroup = new GroupBox
        {
            Text = "Tema dell'interfaccia",
            Dock = DockStyle.Fill,
            Padding = new Padding(12)
        };

        var themeOptionsPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.TopDown,
            AutoSize = true,
            WrapContents = false
        };

        // Inserisco i RadioButton nel FlowLayoutPanel
        themeOptionsPanel.Controls.Add(_lightThemeRadio);
        themeOptionsPanel.Controls.Add(_darkThemeRadio);
        themeOptionsPanel.Controls.Add(_systemThemeRadio);
        themeGroup.Controls.Add(themeOptionsPanel);

        var notificationsGroup = new GroupBox
        {
            Text = "Notifiche",
            Dock = DockStyle.Fill,
            Padding = new Padding(12)
        };

        var notificationsPanel = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.TopDown,
            AutoSize = true,
            WrapContents = false
        };

        notificationsPanel.Controls.Add(_emailCheckbox);
        notificationsPanel.Controls.Add(_smsCheckbox);
        notificationsPanel.Controls.Add(_pushCheckbox);
        notificationsGroup.Controls.Add(notificationsPanel);

        // Layout Tabella che divide in 2
        // BoxGroup1 -> FlowLayout -> 3 bottoni
        // BoxGroup2 -> FlowLayout -> 3 checkbox
        preferencesLayout.Controls.Add(themeGroup, 0, 0);
        preferencesLayout.Controls.Add(notificationsGroup, 1, 0);

        _summaryLabel = new Label
        {
            Dock = DockStyle.Fill,
            AutoSize = true,
            Text = "Seleziona le preferenze per vedere un riepilogo.",
            Margin = new Padding(0, 12, 0, 12)
        };

        var actionPanel = new FlowLayoutPanel
        {
            FlowDirection = FlowDirection.RightToLeft,
            Dock = DockStyle.Fill,
            AutoSize = true
        };

        actionPanel.Controls.Add(_closeButton);
        actionPanel.Controls.Add(_resetButton);
        actionPanel.Controls.Add(_saveButton);

        mainLayout.Controls.Add(_titleLabel, 0, 0);
        mainLayout.Controls.Add(preferencesLayout, 0, 1);
        mainLayout.Controls.Add(_summaryLabel, 0, 2);
        mainLayout.Controls.Add(actionPanel, 0, 3);

        Controls.Add(mainLayout);

        UpdateSummary();
    }

    private void InitRadioButtons()
    {
        _lightThemeRadio = new RadioButton
        {
            AutoSize = true,
            Text = "Chiaro",
            Checked = true
        };
        _darkThemeRadio = new RadioButton
        {
            AutoSize = true,
            Text = "Scuro"
        };
        _systemThemeRadio = new RadioButton
        {
            AutoSize = true,
            Text = "Sistema"
        };

        _lightThemeRadio.CheckedChanged += (_, _) => UpdateSummary();
        _darkThemeRadio.CheckedChanged += (_, _) => UpdateSummary();
        _systemThemeRadio.CheckedChanged += (_, _) => UpdateSummary();
    }

    private void InitCheckboxes()
    {
        _emailCheckbox = new CheckBox
        {
            AutoSize = true,
            Text = "Email"
        };
        _smsCheckbox = new CheckBox
        {
            AutoSize = true,
            Text = "SMS"
        };
        _pushCheckbox = new CheckBox
        {
            AutoSize = true,
            Text = "Push"
        };

        _emailCheckbox.CheckedChanged += (_, _) => UpdateSummary();
        _smsCheckbox.CheckedChanged += (_, _) => UpdateSummary();
        _pushCheckbox.CheckedChanged += (_, _) => UpdateSummary();
    }

    private void InitActionButtons()
    {
        _saveButton = new Button
        {
            Text = "Salva",
            AutoSize = true
        };
        _resetButton = new Button
        {
            Text = "Resetta",
            AutoSize = true
        };
        _closeButton = new Button
        {
            Text = "Chiudi",
            AutoSize = true
        };

        _saveButton.Click += (_, _) => MessageBox.Show("Preferenze salvate!", "Salvataggio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        _resetButton.Click += (_, _) => ResetPreferences();
        _closeButton.Click += (_, _) => Close();
    }

    private void ResetPreferences()
    {
        _lightThemeRadio.Checked = true;
        _darkThemeRadio.Checked = false;
        _systemThemeRadio.Checked = false;
        _emailCheckbox.Checked = false;
        _smsCheckbox.Checked = false;
        _pushCheckbox.Checked = false;

        UpdateSummary();
    }

    private void UpdateSummary()
    {
        var selectedTheme = GetSelectedTheme();
        var notifications = new[]
        {
            (_emailCheckbox.Checked, _emailCheckbox.Text),
            (_smsCheckbox.Checked, _smsCheckbox.Text),
            (_pushCheckbox.Checked, _pushCheckbox.Text)
        }
            .Where(option => option.Checked)
            .Select(option => option.Text)
            .ToArray();

        var notificationSummary = notifications.Length switch
        {
            0 => "nessuna notifica",
            1 => notifications[0],
            _ => string.Join(", ", notifications)
        };

        _summaryLabel.Text = $"Tema selezionato: {selectedTheme}. Notifiche attive: {notificationSummary}.";
    }

    private string GetSelectedTheme()
    {
        if (_lightThemeRadio.Checked)
        {
            return _lightThemeRadio.Text;
        }

        if (_darkThemeRadio.Checked)
        {
            return _darkThemeRadio.Text;
        }

        return _systemThemeRadio.Text;
    }
}
