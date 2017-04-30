using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestNote_cs
{
    public partial class RenameDialog : Form
    {
        public RenameDialog()
        {
            InitializeComponent();
        }

        public string getInputedName()
        {
            return nameTextBox.Text;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("名称不能为空", "警告", MessageBoxButtons.OK);
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
