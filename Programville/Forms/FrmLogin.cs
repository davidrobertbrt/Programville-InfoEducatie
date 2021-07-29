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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogare_Click(object sender, EventArgs e)
        {

            //Daca nu a fost introdus email-ul sau parola.
            if (String.IsNullOrWhiteSpace(txtEmail.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Nu au fost completate toate câmpurile!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Utilizator rezultat = Utilizator.ReturnUtilizatorByCredentials(txtEmail.Text, Encryption.Encrypt(txtPassword.Text));
            if (rezultat == null)
            {
                MessageBox.Show("Utilizatorul nu a fost gasit!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(rezultat != null)
            {
                WindowManager.crUtilizator = rezultat;
                WindowManager.isActive = true;
                this.Close();
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmRegister().ShowDialog();
        }


        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            WindowManager.isActive = false;
        }
    }
}
