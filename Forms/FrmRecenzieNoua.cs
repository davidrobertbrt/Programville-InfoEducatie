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
    public partial class FrmRecenzieNoua : Form
    {
        Test crTest;
        Utilizator crUtilizator;

        public FrmRecenzieNoua(Test _crTest, Utilizator _crUtilizator)
        {
            InitializeComponent();
            crTest = _crTest;
            crUtilizator = _crUtilizator;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtDescriere.Text))
            {
                new Recenzie(txtDescriere.Text, Convert.ToInt32(comboScor.Value), crUtilizator, crTest, DateTime.Now);
                MessageBox.Show("Recenzie adaugata!");
                this.Close();
            }
        }
    }
}
