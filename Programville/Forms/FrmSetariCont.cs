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
    public partial class FrmSetariCont : Form
    {
        Utilizator userCr;
        public FrmSetariCont(Utilizator _userCr)
        {
            InitializeComponent();
            userCr = _userCr;
        }
        private void LoadGeneralInfo()
        {
            lbName.Text = userCr.Nume + " " + userCr.Prenume;
            lbEmail.Text = userCr.Email;

            if (userCr.TipUtilizator == 1)
                lbRole.Text = "Administrator";
            else
                lbRole.Text = "Student";

            if (!String.IsNullOrWhiteSpace(userCr.CaleProfilePicture))
                profilePictureBox.Image = PhotoManager.LoadImage(userCr.CaleProfilePicture);


        }

        private void btnUploadProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                profilePictureBox.Image = new Bitmap(open.FileName);
                string imgPath = PhotoManager.SaveImage(profilePictureBox.Image, "ProfilePictures", userCr.IdUser);
                userCr.CaleProfilePicture = imgPath;
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            new FrmEditProfileInformation(userCr).ShowDialog();
            LoadGeneralInfo();

        }

        private void FrmSetariCont_Load(object sender, EventArgs e)
        {
            LoadGeneralInfo();
        }
    }
}
