using System;
using System.Drawing;
using System.Windows.Forms;

namespace DocumentApp
{
    public class InputDialog : Form
    {
        private TextBox txtInput;
        private Button btnOk;
        private Button btnCancel;
        private Label lblPrompt;

        public string InputText
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }

        public InputDialog(string prompt, bool multiline = false)
        {
            InitializeComponent(prompt, multiline);
        }

        private void InitializeComponent(string prompt, bool multiline)
        {
            this.lblPrompt = new Label();
            this.txtInput = new TextBox();
            this.btnOk = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // lblPrompt
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new Point(12, 9);
            this.lblPrompt.Size = new Size(200, 13);
            this.lblPrompt.Text = prompt;

            // txtInput
            if (multiline)
            {
                this.txtInput.Multiline = true;
                this.txtInput.ScrollBars = ScrollBars.Vertical;
                this.txtInput.Height = 150;
            }
            else
            {
                this.txtInput.Multiline = false;
                this.txtInput.Height = 23;
            }
            this.txtInput.Location = new Point(12, 30);
            this.txtInput.Width = 360;

            // btnOk
            this.btnOk.Location = new Point(216, 200);
            this.btnOk.Size = new Size(75, 23);
            this.btnOk.Text = "OK";
            this.btnOk.DialogResult = DialogResult.OK;

            // btnCancel
            this.btnCancel.Location = new Point(297, 200);
            this.btnCancel.Size = new Size(75, 23);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.DialogResult = DialogResult.Cancel;

            // InputDialog
            this.ClientSize = new Size(384, 241);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Ввод данных";
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}