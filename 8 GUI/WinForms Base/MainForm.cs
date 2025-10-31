namespace WinFormsBase;

public partial class MainForm : Form
{
    private readonly Button _actionButton;
    private readonly Label _messageLabel;

    public MainForm()
    {
        Text = "WinForms - Esempio Base";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(800, 600);
        MinimumSize = new Size(360, 200);

        _messageLabel = new Label
        {
            AutoSize = false,
            Dock = DockStyle.Top,
            Height = 80,
            Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Bold),
            TextAlign = ContentAlignment.MiddleCenter,
            Text = "Benvenuto in WinForms!"
        };

        _actionButton = new Button
        {
            Dock = DockStyle.Bottom,
            Height = 40,
            Margin = new Padding(20),
            Text = "Mostra Ora"
        };
        _actionButton.Click += OnActionButtonClick;

        Controls.Add(_actionButton);
        Controls.Add(_messageLabel);
    }

    private void OnActionButtonClick(object? sender, EventArgs e)
    {
        var ora = DateTime.Now.ToString("HH:mm:ss");
        var result = MessageBox.Show($"Sono le {ora}", "WinForms", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        if (result == DialogResult.Yes)
        {
            _messageLabel.Text = "Hai cliccato Sì!";
        }
        else
        {
            _messageLabel.Text = "Hai cliccato No!";
        }
    }
}