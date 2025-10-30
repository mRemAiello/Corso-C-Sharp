using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WinFormsBase;

public class LoadingForm : Form
{
    private readonly ProgressBar _progressBar;
    private readonly Timer _countdownTimer;
    private readonly Label _titleLabel;
    private readonly Label _statusLabel;
    private readonly Button _startButton;
    private readonly Button _cancelButton;
    private readonly PictureBox _statusIcon;

    private int _elapsedSeconds;
    private readonly int _totalSeconds = 15;

    public LoadingForm()
    {
        Text = "Simulazione Caricamento";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(520, 260);
        BackColor = Color.FromArgb(37, 51, 71);
        Font = new Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point);
        Icon = SystemIcons.Information;
        MinimumSize = new Size(460, 240);

        _titleLabel = new Label
        {
            Dock = DockStyle.Top,
            Height = 60,
            Text = "Prepara il tuo ambiente",
            TextAlign = ContentAlignment.BottomCenter,
            Font = new Font("Segoe UI Semibold", 20, FontStyle.Bold),
            ForeColor = Color.FromArgb(245, 245, 245)
        };

        _statusIcon = new PictureBox
        {
            Size = new Size(64, 64),
            Image = SystemIcons.Information.ToBitmap(),
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Color.Transparent,
            Margin = new Padding(20, 10, 20, 10)
        };

        _statusLabel = new Label
        {
            AutoSize = false,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft,
            Text = "Premi \"Avvia\" per iniziare il caricamento.",
            ForeColor = Color.FromArgb(210, 222, 243)
        };

        var statusPanel = new TableLayoutPanel
        {
            ColumnCount = 2,
            Dock = DockStyle.Top,
            Height = 90,
            Padding = new Padding(20, 10, 20, 10),
            BackColor = Color.FromArgb(47, 63, 87)
        };
        statusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        statusPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        statusPanel.Controls.Add(_statusIcon, 0, 0);
        statusPanel.Controls.Add(_statusLabel, 1, 0);

        _progressBar = new ProgressBar
        {
            Dock = DockStyle.Top,
            Height = 30,
            Style = ProgressBarStyle.Continuous,
            ForeColor = Color.FromArgb(114, 191, 68),
            BackColor = Color.FromArgb(25, 35, 49),
            Margin = new Padding(20, 20, 20, 0)
        };

        _startButton = new Button
        {
            Text = "Avvia",
            BackColor = Color.FromArgb(114, 191, 68),
            ForeColor = Color.FromArgb(21, 32, 43),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold),
            Margin = new Padding(10),
            Height = 40,
            Dock = DockStyle.Fill
        };
        _startButton.FlatAppearance.BorderSize = 0;
        _startButton.Click += (_, _) => StartCountdown();

        _cancelButton = new Button
        {
            Text = "Annulla",
            BackColor = Color.FromArgb(207, 73, 73),
            ForeColor = Color.FromArgb(245, 245, 245),
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold),
            Margin = new Padding(10),
            Height = 40,
            Dock = DockStyle.Fill,
            Enabled = false
        };
        _cancelButton.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
        _cancelButton.Click += (_, _) => CancelCountdown();

        var buttonPanel = new TableLayoutPanel
        {
            Dock = DockStyle.Top,
            Height = 70,
            ColumnCount = 2,
            Padding = new Padding(20, 15, 20, 0)
        };
        buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        buttonPanel.Controls.Add(_startButton, 0, 0);
        buttonPanel.Controls.Add(_cancelButton, 1, 0);

        _countdownTimer = new Timer { Interval = 1000 };
        _countdownTimer.Tick += (_, _) => UpdateCountdown();

        Controls.Add(buttonPanel);
        Controls.Add(_progressBar);
        Controls.Add(statusPanel);
        Controls.Add(_titleLabel);
    }

    private void StartCountdown()
    {
        _elapsedSeconds = 0;
        _progressBar.Maximum = _totalSeconds;
        _progressBar.Value = 0;
        _statusLabel.Text = "Caricamento in corso...";
        _startButton.Enabled = false;
        _cancelButton.Enabled = true;
        _countdownTimer.Start();
    }

    private void CancelCountdown()
    {
        _countdownTimer.Stop();
        _statusLabel.Text = "Caricamento annullato.";
        _cancelButton.Enabled = false;
        _startButton.Enabled = true;
        _progressBar.Value = 0;
    }

    private void UpdateCountdown()
    {
        if (_elapsedSeconds < _totalSeconds)
        {
            _elapsedSeconds++;
            _progressBar.Value = Math.Min(_elapsedSeconds, _progressBar.Maximum);
            var remaining = _totalSeconds - _elapsedSeconds;
            _statusLabel.Text = remaining > 0
                ? $"Caricamento in corso... {remaining}s rimanenti"
                : "Finalizzazione...";
        }
        else
        {
            _countdownTimer.Stop();
            _statusLabel.Text = "Operazione completata con successo!";
            _cancelButton.Enabled = false;
            _startButton.Enabled = true;
            SystemSounds.Asterisk.Play();
        }
    }
}
