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
        List<Test> teste = Test.LoadTestsFromDatabase();
        List<Materie> materii = Materie.LoadMateriiFromDatabase();

        public FrmHomeScreen()
        {
            InitializeComponent();
        }


        
        private void LoadFilters()
        {
            comboFilter.DataSource = materii;
            comboFilter.DisplayMember = "Nume";
            comboFilter.ValueMember = "IdMaterie";
        }

        private void LoadTeste()
        {
            flowTeste.Controls.Clear();

            foreach (Test test in teste)
                flowTeste.Controls.Add(new TestPreview(test));

        }

        /**
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
                if (Convert.ToInt32(rezultat["IdUtilizator"]) == WindowManager.crUtilizator.IdUser)
                {
                    Test testRezolvat = new Test(Convert.ToInt32(rezultat["IdTest"]));
                    int punctaj = Convert.ToInt32(rezultat["Punctaj"]);
                    DateTime dataRezolvat = Convert.ToDateTime(rezultat["Data"]);
                    gridRezultate.Rows.Add(testRezolvat.Titlu, WindowManager.crUtilizator.Email, punctaj, dataRezolvat);
                }
            }

        }
        **/

        private void LoadBasedOnFilters()
        {
            if (comboFilter.SelectedItem != null)
            {
                int materieSelectata = Convert.ToInt32(comboFilter.SelectedValue);
                flowTeste.Controls.Clear();

                foreach (Test test in teste)
                {
                    if (test.MaterieTest.IdMaterie == materieSelectata)
                        flowTeste.Controls.Add(new TestPreview(test));
                }
            }
        }


        private void FrmHomeScreen_Load(object sender, EventArgs e)
        {
            LoadFilters();
            LoadTeste();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadBasedOnFilters();
        }


        private void FrmHomeScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowManager.crUtilizator = null;
        }

        private void btnDeconectare_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetari_Click(object sender, EventArgs e)
        {
            new FrmSetariCont(WindowManager.crUtilizator).ShowDialog();
        }


        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            LoadTeste();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            new FrmUserStatistica().ShowDialog();
        }

        private void btnRecenzii_Click(object sender, EventArgs e)
        {
            new FrmRecenziileMele().ShowDialog();
        }
    }
}
