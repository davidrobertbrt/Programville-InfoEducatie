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
    public partial class CardRecenzieActiuni : UserControl
    {
        Recenzie recenzie;

        public CardRecenzieActiuni(Recenzie _recenzie)
        {
            InitializeComponent();
            recenzie = _recenzie;
        }

        private void RecenzieTestCard_Load(object sender, EventArgs e)
        {
            lbNume.Text = recenzie.Creator.Nume + " " + recenzie.Creator.Prenume;
            lbDescriere.Text = recenzie.Descriere;
            lbScor.Text = String.Format("{0}/5", recenzie.Scor);
            lbDateTime.Text = recenzie.DataRecenzie.ToString();
            if(!String.IsNullOrWhiteSpace(recenzie.Creator.CaleProfilePicture))
                picUser.Image = PhotoManager.LoadImage(recenzie.Creator.CaleProfilePicture);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var frm = (FrmRecenziileMele)ParentForm;
            recenzie.Delete();
            frm.LoadRecenzii();
        }
    }
}
