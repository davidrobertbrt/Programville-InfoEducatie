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
    public partial class TestPreviewAdmin : UserControl
    {
        public Test crTest;

        public TestPreviewAdmin(Test _crTest)
        {
            crTest = _crTest;
            InitializeComponent();
        }

        private void TestPreview_Load(object sender, EventArgs e)
        {
            lbTitluTest.Text = crTest.Titlu;
            lbMaterie.Text = crTest.MaterieTest.Nume;
            if (!String.IsNullOrEmpty(crTest.CaleImagine))
                picPreviewTest.Image = Image.FromFile(Application.StartupPath + crTest.CaleImagine);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            crTest.Delete();
            var frm = (FrmTeste)ParentForm;
            frm.LoadTests();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new FrmCreatorTest(crTest).ShowDialog();
            var frm = (FrmTeste)ParentForm;
            frm.LoadTests();
        }
    }
}
