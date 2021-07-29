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
    public partial class FrmRecenziileMele : Form
    {
        List<Recenzie> recenziileMele;
        public FrmRecenziileMele()
        {
            InitializeComponent();
        }

        public void LoadRecenzii()
        {
            flowRecenzii.Controls.Clear();
            recenziileMele = Recenzie.LoadRecenziiFromDatabase().FindAll(x => x.Creator.IdUser == WindowManager.crUtilizator.IdUser);
            foreach(Recenzie recenzie in recenziileMele)
                flowRecenzii.Controls.Add(new CardRecenzieActiuni(recenzie));
        }
        private void FrmRecenziileMele_Load(object sender, EventArgs e)
        {
            LoadRecenzii();
        }
    }
}
