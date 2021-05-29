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
    public partial class FrmChangePassword : Form
    {
        Utilizator userCr;

        public FrmChangePassword(Utilizator _userCr)
        {
            userCr = _userCr;
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            if(!txtParola.Text.Equals(userCr.Password))
            {
                MessageBox.Show("Ați greșit parola curentă!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(String.IsNullOrWhiteSpace(txtNewPass.Text))
            {
                MessageBox.Show("Introduceți o parolă!","Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(!txtNewPass.Text.Equals(txtConfirmNewPass.Text))
            {
                MessageBox.Show("Parolele nu coincid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            MessageBox.Show("Sunteți sigur că doriți să schimbați parola?","Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if(ValidateInput() == true)
            {
                try
                {
                    userCr.Password = txtNewPass.Text;
                    MessageBox.Show("Parola schimbată cu succes!");
                }
                catch
                {
                    MessageBox.Show("Eroare la schimbarea parolei. Contactați dezvoltatorul!");
                }
                
            }
        }
    }
}
