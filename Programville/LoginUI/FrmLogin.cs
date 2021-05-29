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

            Utilizator rezultat = Utilizator.ReturnUtilizatorByCredentials(txtEmail.Text, txtPassword.Text);
            if (rezultat == null)
            {
                MessageBox.Show("Utilizatorul nu a fost gasit!", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(rezultat != null)
            {
                if (rezultat.TipUtilizator == 0)
                {
                    this.Hide();
                    new FrmHomeScreen(rezultat).ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    new FrmHomeAdmin(rezultat).ShowDialog();
                    this.Show();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmRegister().ShowDialog();
        }
    }
}
