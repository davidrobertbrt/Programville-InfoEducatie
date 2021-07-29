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
    public partial class FrmRecenziiAdmin : Form
    {
        List<Recenzie> recenzii;

        public FrmRecenziiAdmin()
        {
            InitializeComponent();
        }


        public void LoadRecenzii()
        {
            flowRecenzii.Controls.Clear();
            recenzii = Recenzie.LoadRecenziiFromDatabase();
            foreach (Recenzie recenzie in recenzii)
                flowRecenzii.Controls.Add(new CardRecenzie(recenzie));
        }
        private void FrmRecenziiAdmin_Load(object sender, EventArgs e)
        {
            LoadRecenzii();
        }

    }
}
