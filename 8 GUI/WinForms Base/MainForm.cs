using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsBase;

public partial class MainForm : Form
{
    private readonly Button _actionButton;
    private readonly Label _messageLabel;

    public MainForm()
    {
        Text = "WinForms - Esempio Base";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(420, 220);
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
            Dock = DockStyle.Fill,
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
        MessageBox.Show($"Sono le {ora}", "WinForms", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
