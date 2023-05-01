using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programville
{
    public partial class RadioBoxWithTextBox : UserControl
    {
        public string input = null;
        public int valid = 0;
        public RadioBoxWithTextBox()
        {
            InitializeComponent();
        }

        public RadioBoxWithTextBox(string _input, int _valid)
        {
            input = _input;
            valid = _valid;
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            input = txtInput.Text;
        }

        private void btnCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCheck.Checked == true)
                valid = 1;
            else
                valid = 0;
        }

        private void RadioBoxWithTextBox_Resize(object sender, EventArgs e)
        {
            
        }

        private void RadioBoxWithTextBox_Load(object sender, EventArgs e)
        {
            if (input != null)
            {
                txtInput.Text = input;
                if (valid == 1)
                    btnCheck.Checked = true;
                else
                    btnCheck.Checked = false;
            }
        }
    }
}
