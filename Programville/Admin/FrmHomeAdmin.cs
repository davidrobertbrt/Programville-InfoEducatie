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
using Programville.MainDatabaseDataSetTableAdapters;

namespace Programville
{
    public partial class FrmHomeAdmin : Form
    {
        Utilizator userCr;
        RezultateTableAdapter rezultateTA = new RezultateTableAdapter();
        MainDatabaseDataSet.RezultateDataTable rezultate;

        public FrmHomeAdmin(Utilizator _userCr)
        {
            userCr = _userCr;
            InitializeComponent();
        }

        private void LoadStatistica()
        {
            if(rezultate.Rows.Count == 0)
            {
                lbNotFound.Visible = true;
                gridRezultate.Enabled = false;
            }

            foreach (DataRow rezultat in rezultate.Rows)
            {
                Test testRezolvat = new Test(Convert.ToInt32(rezultat["IdTest"]));
                Utilizator participant = new Utilizator(Convert.ToInt32(rezultat["IdUtilizator"]));
                int punctaj = Convert.ToInt32(rezultat["Punctaj"]);
                DateTime dataRezolvat = Convert.ToDateTime(rezultat["Data"]);
                gridRezultate.Rows.Add(testRezolvat.Titlu, participant.Email, punctaj, dataRezolvat);
            }
        }

        private void UpdateForm()
        {
            DataTable rezultateTable = new DataTable();

            lbNrTeste.Text = Convert.ToString(Test.LoadTestsFromDatabase().Count);
            lbNrUtilizatori.Text = Convert.ToString(Utilizator.ReturnStudentsFromDatabase().Count);
            lbNume.Text = userCr.Nume + " " + userCr.Prenume;
            lbEmail.Text = userCr.Email;
            rezultate = rezultateTA.GetData();

            if(userCr.CaleProfilePicture != null)
            {
                if (File.Exists(Application.StartupPath + userCr.CaleProfilePicture))
                {
                    picUser.Image = Image.FromFile(Application.StartupPath + userCr.CaleProfilePicture);
                    picUser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }


        }

        private void materiiOp_Click(object sender, EventArgs e)
        {
            new ManageMaterii().ShowDialog();
        }


        private void administrareOp_Click(object sender, EventArgs e)
        {
            new ManageUtilizatori().ShowDialog();
            UpdateForm();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            new FrmEditProfile(userCr).ShowDialog();
            UpdateForm();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new FrmChangePassword(userCr).ShowDialog();
            UpdateForm();
        }


        private void FrmHomeAdmin_Load(object sender, EventArgs e)
        {
            UpdateForm();
            LoadStatistica();
        }
        private void testeOp_Click(object sender, EventArgs e)
        {
            new FrmTeste().ShowDialog();
            UpdateForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmare = MessageBox.Show("Doresti să te deloghezi?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmare == DialogResult.No)
                e.Cancel = true;
        }
    }
}
