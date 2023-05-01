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
    public partial class ManageMaterii : Form
    {
        List<Materie> materii;
        public ManageMaterii()
        {
            InitializeComponent();
        }


        private void UpdateList()
        {
            materii = Materie.LoadMateriiFromDatabase();

            if (materii.Count == 0)
            {
                listMaterii.Visible = false;
                listMaterii.Enabled = false;
            }
            else
            {
                listMaterii.Visible = true;
                listMaterii.Enabled = true;
            }

            listMaterii.DataSource = materii;
            listMaterii.DisplayMember = "Nume";
            listMaterii.ValueMember = "IdMaterie";
            listMaterii.ClearSelected();
        }

        private void ManageMaterii_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listMaterii.SelectedItem == null)
            {
                
                materii.Add(new Materie(txtMaterie.Text));
                UpdateList();
            }
            else
            {
                Materie materieCr = (Materie)listMaterii.SelectedItem;
                materieCr.Nume = txtMaterie.Text;
                UpdateList();
            }
            

        }

        private void listMaterii_SelectedIndexChanged(object sender, EventArgs e)
        {
            var materieSelectata = (Materie)listMaterii.SelectedItem;
            if (materieSelectata == null)
                txtMaterie.Clear();
            else
                txtMaterie.Text = Convert.ToString(materieSelectata.Nume);
        }

        private void btnDeselect_Click(object sender, EventArgs e)
        {
            listMaterii.ClearSelected();
        }
    }
}
