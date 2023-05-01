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
    public partial class FrmTeste : Form
    {
        List<Test> teste;
        List<Materie> materii = Materie.LoadMateriiFromDatabase();

        public FrmTeste()
        {
            InitializeComponent();
        }

        public void LoadTests()
        {
            flowTeste.Controls.Clear();
            teste = Test.LoadTestsFromDatabase();

            foreach (Test test in teste)
            {
                flowTeste.Controls.Add(new TestPreviewAdmin(test));
            }
        }

        public void LoadMaterii()
        {
            comboFilter.DataSource = materii;
            comboFilter.DisplayMember = "Nume";
            comboFilter.ValueMember = "IdMaterie";
        }


        private void FrmTeste_Load(object sender, EventArgs e)
        {
            LoadTests();
            LoadMaterii();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            new FrmCreatorTest().ShowDialog();
            LoadTests();
        }

        private void comboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboFilter_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (comboFilter.SelectedItem != null)
            {
                int materieSelectata = Convert.ToInt32(comboFilter.SelectedValue);
                flowTeste.Controls.Clear();

                foreach (Test test in teste)
                {
                    if (test.MaterieTest.IdMaterie == materieSelectata)
                        flowTeste.Controls.Add(new TestPreviewAdmin(test));
                }
            }
        }

        private void btnDeleteFilter_Click(object sender, EventArgs e)
        {
            LoadTests();
        }
    }
}
