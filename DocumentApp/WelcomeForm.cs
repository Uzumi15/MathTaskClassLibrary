using System;
using System.Drawing;
using System.Windows.Forms;

namespace DocumentApp
{
    public class WelcomeForm : Form
    {
        private Label lblTitle;
        private Label lblDescription;
        private Button btnStart;
        private Button btnExit;
        private CheckBox chkDarkTheme;
        private ThemeManager themeManager;

        public WelcomeForm()
        {
            themeManager = new ThemeManager();
            InitializeComponent();
            LoadTheme();
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblDescription = new Label();
            this.btnStart = new Button();
            this.btnExit = new Button();
            this.chkDarkTheme = new CheckBox();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.Location = new Point(50, 50);
            this.lblTitle.Size = new Size(400, 50);
            this.lblTitle.Text = "Конструктор Документов 📄";

            // lblDescription
            this.lblDescription.Font = new Font("Segoe UI", 12F);
            this.lblDescription.Location = new Point(50, 120);
            this.lblDescription.Size = new Size(400, 100);
            this.lblDescription.Text = "Собирайте документы из блоков:\n• Заголовки\n• Текст\n• Списки\n• Таблицы";

            // btnStart
            this.btnStart.Font = new Font("Segoe UI", 12F);
            this.btnStart.Location = new Point(100, 250);
            this.btnStart.Size = new Size(150, 40);
            this.btnStart.Text = "Начать работу";
            this.btnStart.Click += new EventHandler(this.BtnStart_Click);

            // btnExit
            this.btnExit.Font = new Font("Segoe UI", 12F);
            this.btnExit.Location = new Point(270, 250);
            this.btnExit.Size = new Size(100, 40);
            this.btnExit.Text = "Выход";
            this.btnExit.Click += new EventHandler(this.BtnExit_Click);

            // chkDarkTheme
            this.chkDarkTheme.Font = new Font("Segoe UI", 10F);
            this.chkDarkTheme.Location = new Point(50, 320);
            this.chkDarkTheme.Size = new Size(150, 30);
            this.chkDarkTheme.Text = "Тёмная тема";
            this.chkDarkTheme.CheckedChanged += new EventHandler(this.ChkDarkTheme_CheckedChanged);

            // WelcomeForm
            this.ClientSize = new Size(500, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkDarkTheme);
            this.Name = "WelcomeForm";
            this.Text = "Конструктор Документов";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LoadTheme()
        {
            bool isDark = themeManager.LoadTheme();
            chkDarkTheme.Checked = isDark;
            themeManager.ApplyTheme(this, isDark);
        }

        private void ChkDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            themeManager.ApplyTheme(this, chkDarkTheme.Checked);
            themeManager.SaveTheme(chkDarkTheme.Checked);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}