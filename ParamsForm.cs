using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_с_
{
    public partial class ParamsForm : Form
    {
        int size;
        public ParamsForm()
        {
            InitializeComponent();
            OKButton.DialogResult = DialogResult.Yes;
            CancelButton.DialogResult = DialogResult.No;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            size = Input.Text == "" ? -1 : Convert.ToInt32(Input.Text);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {}

        public int GetSize()
        {
            return size;
        }

        private void ParamsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OKButton.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                CancelButton.PerformClick();
            }
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OKButton.PerformClick();
            }
        }
    }
}
