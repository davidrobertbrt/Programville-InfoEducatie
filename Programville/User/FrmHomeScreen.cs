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
using System.IO;

namespace Programville
{
    public partial class FrmHomeScreen : Form
    {
        List<Test> teste;
        List<Materie> materii = Materie.LoadMateriiFromDatabase();
        public Utilizator crUtilizator = null;

        public FrmHomeScreen(Utilizator _crUtilizator)
        {
            InitializeComponent();
            crUtilizator = _crUtilizator;
        }

        private void LoadUserInfo()
        {
            lbNume.Text = crUtilizator.Nume + " " + crUtilizator.Prenume;
            lbEmail.Text = crUtilizator.Email;

            if (crUtilizator.CaleProfilePicture != null)
            {
                if (File.Exists(Application.StartupPath + crUtilizator.CaleProfilePicture))
                {
                    picUser.Image = Image.FromFile(Application.StartupPath + crUtilizator.CaleProfilePicture);
                    picUser.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
        
        private void LoadFilters()
        {
            comboFilter.DataSource = materii;
            comboFilter.DisplayMember = "Nume";
            comboFilter.ValueMember = "IdMaterie";
        }

        private void LoadTeste()
        {
            teste = Test.LoadTestsFromDatabase();
            panelTeste.Controls.Clear();

            foreach (Test test in teste)
                panelTeste.Controls.Add(new TestPreview(test));

        }

        private void LoadStatistica()
        {
            RezultateTableAdapter rezultateTA = new RezultateTableAdapter();

            if (rezultateTA.GetData().Rows.Count == 0)
            {
                lbNotFound.Visible = true;
                gridRezultate.Enabled = false;
            }

            foreach (DataRow rezultat in rezultateTA.GetData())
            {
                if (Convert.ToInt32(rezultat["IdUtilizator"]) == crUtilizator.IdUser)
                {
                    Test testRezolvat = new Test(Convert.ToInt32(rezultat["IdTest"]));
                    int punctaj = Convert.ToInt32(rezultat["Punctaj"]);
                    DateTime dataRezolvat = Convert.ToDateTime(rezultat["Data"]);
                    gridRezultate.Rows.Add(testRezolvat.Titlu, crUtilizator.Email, punctaj, dataRezolvat);
                }
            }

        }

        private void LoadBasedOnFilters()
        {
            if (comboFilter.SelectedItem != null)
            {
                int materieSelectata = Convert.ToInt32(comboFilter.SelectedValue);
                panelTeste.Controls.Clear();

                foreach (Test test in teste)
                {
                    if (test.MaterieTest.IdMaterie == materieSelectata)
                        panelTeste.Controls.Add(new TestPreview(test));
                }
            }
        }


        private void FrmHomeScreen_Load(object sender, EventArgs e)
        {
            LoadUserInfo();
            LoadFilters();
            LoadTeste();
            LoadStatistica();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            new FrmEditProfile(crUtilizator).ShowDialog();
            LoadUserInfo();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            new FrmChangePassword(crUtilizator).ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadBasedOnFilters();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmHomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmare = MessageBox.Show("Doresti să te deloghezi?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmare == DialogResult.No)
                e.Cancel = true;
        }
    }
}
