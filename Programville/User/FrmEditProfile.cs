using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Programville
{
    public partial class FrmEditProfile : Form
    {
        Utilizator userCr;
        public FrmEditProfile(Utilizator _userCr)
        {
            userCr = _userCr;
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult confirmare = MessageBox.Show("Doriți să ștergeți contul?\nACEASTĂ ACȚIUNE ESTE IREVERSIBILĂ. VEȚI PIERDE ACCESUL LA TOATE INFORMAȚIILE","Atenție!" ,MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(confirmare == DialogResult.Yes)
            {
                userCr.Delete();
                MessageBox.Show("Contul a fost șters!\n Ieșire din aplicație...");
                Environment.Exit(0);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtNume.Text) || String.IsNullOrWhiteSpace(txtPrenume.Text) || String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Nu ați completat unul dintre câmpuri...", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userCr.Nume != txtNume.Text && userCr.Prenume != txtPrenume.Text)
            {
                userCr.Nume = txtNume.Text;
                userCr.Prenume = txtPrenume.Text;
            }

            if (userCr.CaleProfilePicture == null)
            {
                string[] poze = Directory.GetFiles(Application.StartupPath + @"\profile_picture\");
                int count = poze.Length + 1;
                string calePoza = @"\profile_picture\" + String.Format("{0}-{1}", userCr.IdUser, count) + ".bmp";
                picUser.Image.Save(Application.StartupPath + calePoza, System.Drawing.Imaging.ImageFormat.Bmp);
                userCr.CaleProfilePicture = calePoza;
            }
            else
            {
                if (!String.IsNullOrWhiteSpace(Convert.ToString(picUser.Tag)))
                {
                    string[] poze = Directory.GetFiles(Application.StartupPath + @"\profile_picture\");
                    int count = poze.Length + 1;
                    string calePoza = @"\profile_picture\" + String.Format("{0}-{1}", userCr.IdUser, count) + ".bmp";
                    picUser.Image.Save(Application.StartupPath + calePoza, System.Drawing.Imaging.ImageFormat.Bmp);
                    userCr.CaleProfilePicture = calePoza;
                }
            }

            MessageBox.Show("Date actualizate cu succes!", "Informare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FrmEditProfile_Load(object sender, EventArgs e)
        {
            txtNume.Text = userCr.Nume;
            txtPrenume.Text = userCr.Prenume;
            txtEmail.Text = userCr.Email;
            if (!String.IsNullOrWhiteSpace(userCr.CaleProfilePicture))
            {
                picUser.Image = Image.FromFile(Application.StartupPath + userCr.CaleProfilePicture);
                picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog pozaDialog = new OpenFileDialog();

            if (pozaDialog.ShowDialog() == DialogResult.OK)
            {
                string calePoza = pozaDialog.FileName;
                picUser.Image = Image.FromFile(calePoza);
                picUser.Tag = calePoza;
                picUser.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
