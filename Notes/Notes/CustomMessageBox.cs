using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal class CustomMessageBox : Form
    {
        Label txtMsg = new Label();
        Button btnOK = new Button();
        Button btnCancel = new Button();
        Form newForm = new Form();

        private DialogResult spawnForm(string title, string text, MessageBoxButtons type, string btnOkText, string btnCancelText)
        {
            newForm.BackColor = Color.FromArgb(51, 51, 61);
            newForm.Text = title;
            newForm.Controls.Add(txtMsg);
            txtMsg.AutoSize = true;
            txtMsg.Text = text;
            newForm.Width = txtMsg.Width + 125;
            newForm.Height = txtMsg.Height + 125;
            newForm.MaximumSize = new Size(newForm.Width, newForm.Height);
            newForm.MinimumSize = new Size(newForm.Width, newForm.Height);
            txtMsg.Location = new Point(newForm.Width / 2 - txtMsg.Width / 2, newForm.Height / 2 - 40);
            newForm.Controls.Add(btnOK);
            newForm.Controls.Add(btnCancel);
            btnOK.Text = btnOkText;
            btnCancel.Text = btnCancelText;

            newForm.ForeColor = Color.Gainsboro;

            btnOK.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnOK.ForeColor = Color.Gainsboro;
            btnCancel.ForeColor = Color.Gainsboro;
            btnOK.Cursor = Cursors.Hand;
            btnCancel.Cursor = Cursors.Hand;


            btnOK.Location = new Point(newForm.Width / 2 - btnOK.Width / 2 - 60, txtMsg.Location.Y + txtMsg.Height + 20);
            btnCancel.Location = new Point(newForm.Width / 2 - btnOK.Width / 2 + 40, btnOK.Location.Y);
            btnOK.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;
            newForm.StartPosition = FormStartPosition.CenterParent;
            return newForm.ShowDialog();

        }

        public DialogResult TextForm(string title, string text, MessageBoxButtons type, string btnOkText, string btnCancelText)
        {
            return spawnForm(title, text, type, btnOkText, btnCancelText);
        }
    }
}
