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
        RezultateTableAdapter rezultateTA = new RezultateTableAdapter();
        MainDatabaseDataSet.RezultateDataTable rezultate;

        public FrmHomeAdmin()
        {
            InitializeComponent();
        }

        private void LoadGeneralInfo()
        {
            lbNrTeste.Text = Convert.ToString(Test.LoadTestsFromDatabase().Count);
            lbNrUtilizatori.Text = Convert.ToString(Utilizator.ReturnStudentsFromDatabase().Count);
        }

        private void LoadRezultate()
        {
            rezultate = rezultateTA.GetData();

            if (rezultate.Rows.Count == 0)
            {
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

        private void FrmHomeAdmin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            new ManageUtilizatori().ShowDialog();
        }

        private void btnMaterii_Click(object sender, EventArgs e)
        {
            new ManageMaterii().ShowDialog();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            new FrmTeste().ShowDialog();
        }

        private void FrmHomeAdmin_Load(object sender, EventArgs e)
        {
            LoadGeneralInfo();
            LoadRezultate();
        }

        private void btnRecenzii_Click(object sender, EventArgs e)
        {
            new FrmRecenziiAdmin().ShowDialog();
        }
    }
}
