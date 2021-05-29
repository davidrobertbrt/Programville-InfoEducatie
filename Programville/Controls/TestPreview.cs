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
    public partial class TestPreview : UserControl
    {
        public Test crTest;

        public TestPreview(Test _crTest)
        {
            crTest = _crTest;
            InitializeComponent();
        }

        private void TestPreview_Load(object sender, EventArgs e)
        {
            lbTitluTest.Text = crTest.Titlu;
            lbMaterie.Text = crTest.MaterieTest.Nume;
            lbDescriere.Text = crTest.Descriere;
            if(!String.IsNullOrEmpty(crTest.CaleImagine))
                picPreviewTest.Image = Image.FromFile(Application.StartupPath + crTest.CaleImagine);
        }

        private void btnRezolva_Click(object sender, EventArgs e)
        {
            var frm = (FrmHomeScreen)ParentForm;
            frm.Hide();
            new FrmRezolvaTest(frm.crUtilizator,crTest).ShowDialog();
            frm.Show();
        }
    }
}
