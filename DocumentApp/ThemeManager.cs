using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DocumentApp
{
    public class ThemeManager
    {
        private const string ThemeFile = "theme.txt";

        public void ApplyTheme(Control control, bool isDark)
        {
            Color backColor = isDark ? Color.FromArgb(45, 45, 48) : SystemColors.Control;
            Color foreColor = isDark ? Color.White : SystemColors.ControlText;
            Color controlBack = isDark ? Color.FromArgb(63, 63, 70) : SystemColors.Window;

            control.BackColor = backColor;
            control.ForeColor = foreColor;

            foreach (Control c in control.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = isDark ? Color.FromArgb(70, 70, 75) : SystemColors.Control;
                    btn.ForeColor = foreColor;
                    btn.FlatStyle = isDark ? FlatStyle.Flat : FlatStyle.Standard;
                }
                else if (c is ListBox lb)
                {
                    lb.BackColor = controlBack;
                    lb.ForeColor = foreColor;
                }
                else if (c is RichTextBox rtb)
                {
                    rtb.BackColor = controlBack;
                    rtb.ForeColor = foreColor;
                }
                else if (c is GroupBox gb)
                {
                    gb.ForeColor = foreColor;
                    ApplyTheme(gb, isDark);
                }
                else if (c is CheckBox chk)
                {
                    chk.ForeColor = foreColor;
                }
                else if (c is Label lbl)
                {
                    lbl.ForeColor = foreColor;
                }
            }
        }

        public void SaveTheme(bool isDark)
        {
            File.WriteAllText(ThemeFile, isDark ? "dark" : "light");
        }

        public bool LoadTheme()
        {
            if (File.Exists(ThemeFile))
            {
                string content = File.ReadAllText(ThemeFile);
                return content == "dark";
            }
            return false;
        }
    }
}