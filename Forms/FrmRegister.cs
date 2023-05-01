using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programville.MainDatabaseDataSetTableAdapters;

namespace Programville
{
    public partial class FrmRegister : Form
    {

        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in this.Controls)
                if(ctrl is TextBox)
                {
                    var box = (TextBox)ctrl;
                    if (String.IsNullOrWhiteSpace(box.Text))
                    {
                        MessageBox.Show("Nu au fost completate toate câmpurile!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

            if(!txtParola.Text.Equals(txtConfirmParola.Text))
            {
                MessageBox.Show("Parolele nu sunt identice!");
                txtParola.Clear();
                txtConfirmParola.Clear();
                return;
            }

            if (Utilizator.ReturnUtilizatorByCredentials(txtEmail.Text, null) == null)
            {
                new Utilizator(txtNume.Text, txtPrenume.Text, txtEmail.Text, Encryption.Encrypt(txtParola.Text), null, 0);
                MessageBox.Show("Felicitari!\n Ai reusit sa te inregistrezi", "Bun venit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Contul deja există!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
