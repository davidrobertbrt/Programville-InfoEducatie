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
    public partial class FrmEditProfileInformation : Form
    {
        Utilizator userCr;
        public FrmEditProfileInformation(Utilizator _userCr)
        {
            InitializeComponent();
            userCr = _userCr;
        }

        public bool CheckOldPassword()
        {
            string encryptedPassword = Encryption.Encrypt(txtOldPassword.Text);

            if (encryptedPassword == userCr.Password)
                return true;
            else
            {
                lbError.Text = "Verificați câmpul parolă veche!";
                lbError.Visible = true;
                return false;
            }
        }

        public bool CheckPasswords()
        {
            if (txtNewPassword.Text.Equals(txtConfirmNewPassword.Text))
            {
                if (String.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    lbError.Text = "Parola nu a fost completată!";
                    lbError.Visible = true;
                    return false;
                }
                else
                    return true;
            }
            else
            {
                lbError.Text = "Parolele nu coincid!";
                return false;
            }
        }

        public bool CheckUserInfo()
        {
            if (String.IsNullOrWhiteSpace(txtFirstName.Text) || String.IsNullOrWhiteSpace(txtLastName.Text) || String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lbError.Text = "Câmpuri informații personale necompletat!";
                lbError.Visible = true;
                return false;
            }

            if (!Utilizator.CheckEmailFormat(txtEmail.Text))
            {
                lbError.Text = "Format e-mail greșit!";
                lbError.Visible = true;
                return false;
            }

            return true;
        }


        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (CheckOldPassword())
            {
                DialogResult confirmare = MessageBox.Show("Doriți să ștergeți contul?\nACEASTĂ ACȚIUNE ESTE IREVERSIBILĂ. VEȚI PIERDE ACCESUL LA TOATE INFORMAȚIILE", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmare == DialogResult.Yes)
                {
                    userCr.Delete();
                    MessageBox.Show("Contul a fost șters!\n Ieșire din aplicație...");
                    Environment.Exit(0);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != userCr.Nume || txtLastName.Text != userCr.Prenume || txtEmail.Text != userCr.Email)
                if (CheckUserInfo() == true && CheckOldPassword() == true)
                {
                    userCr.Nume = txtFirstName.Text;
                    userCr.Prenume = txtLastName.Text;
                    userCr.Email = txtEmail.Text;

                    if (!String.IsNullOrWhiteSpace(txtNewPassword.Text) && userCr.Password != Encryption.Encrypt(txtNewPassword.Text))
                    {
                        if (CheckPasswords() == true)
                            userCr.Password = Encryption.Encrypt(txtNewPassword.Text);
                    }

                    MessageBox.Show("Date actualizate cu succes!", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

        }

        private void lbError_TextChanged(object sender, EventArgs e)
        {
            if (lbError.Visible == false)
                lbError.Visible = true;
        }

        private void EditProfileInformation_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = userCr.Nume;
            txtLastName.Text = userCr.Prenume;
            txtEmail.Text = userCr.Email;

        }
    }
}
