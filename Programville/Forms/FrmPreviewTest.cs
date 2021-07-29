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
    public partial class FrmPreviewTest : Form
    {
        Test crTest;
        List<Recenzie> recenzii;
        public FrmPreviewTest(Test _crTest)
        {
            InitializeComponent();
            crTest = _crTest;
        }

        public void LoadGeneralInfo()
        {
            lbTitlu.Text = crTest.Titlu;
            lbDescriere.Text = crTest.Descriere;

            if(!String.IsNullOrWhiteSpace(crTest.CaleImagine))
                 picTestPreview.Image = PhotoManager.LoadImage(crTest.CaleImagine);

            lbMaterie.Text = crTest.MaterieTest.Nume;


        }

        public void LoadRecenzii()
        {
            recenzii = Recenzie.LoadRecenziiFromDatabase().FindAll(x => x.TestEvaluat.IdTest == crTest.IdTest);
            flowRecenzii.Controls.Clear();
            foreach (var recenzie in recenzii)
                flowRecenzii.Controls.Add(new CardRecenzie(recenzie));
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmRezolvaTest(WindowManager.crUtilizator, crTest).ShowDialog();
            this.Show();
        }

        private void btnNouRecenzie_Click(object sender, EventArgs e)
        {
            new FrmRecenzieNoua(crTest, WindowManager.crUtilizator).ShowDialog();
            LoadRecenzii();
        }

        private void FrmPreviewTest_Load(object sender, EventArgs e)
        {
            LoadGeneralInfo();
            LoadRecenzii();
        }
    }
}
