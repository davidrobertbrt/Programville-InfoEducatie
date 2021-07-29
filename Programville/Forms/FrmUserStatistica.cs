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

namespace Programville
{
    public partial class FrmUserStatistica : Form
    {
        public FrmUserStatistica()
        {
            InitializeComponent();
        }

        private void InformatiiGenerale()
        {
            RezultateTableAdapter rezultateTA = new RezultateTableAdapter();
            lbNrTeste.Text = Convert.ToString(rezultateTA.GetData().Select(x => Convert.ToInt32(x["IdRezultat"]) == WindowManager.crUtilizator.IdUser).Count());
            lbNrRecenzii.Text = Convert.ToString(Recenzie.LoadRecenziiFromDatabase().FindAll(x => x.Creator.IdUser == WindowManager.crUtilizator.IdUser).Count());
        }

        private void Rezolvari()
        {
            RezultateTableAdapter rezultateTA = new RezultateTableAdapter();

            if (rezultateTA.GetData().Rows.Count == 0)
                gridRezultate.Enabled = false;

            foreach (DataRow rezultat in rezultateTA.GetData())
            {
                if (Convert.ToInt32(rezultat["IdUtilizator"]) == WindowManager.crUtilizator.IdUser)
                {
                    Test testRezolvat = new Test(Convert.ToInt32(rezultat["IdTest"]));
                    int punctaj = Convert.ToInt32(rezultat["Punctaj"]);
                    DateTime dataRezolvat = Convert.ToDateTime(rezultat["Data"]);
                    gridRezultate.Rows.Add(testRezolvat.Titlu,punctaj, dataRezolvat);
                }
            }
        }

        private void FrmUserStatistica_Load(object sender, EventArgs e)
        {
            InformatiiGenerale();
            Rezolvari();
        }
    }
}
