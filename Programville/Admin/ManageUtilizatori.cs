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
    public partial class ManageUtilizatori : Form
    {
        List<Utilizator> utilizatori;

        public ManageUtilizatori()
        {
            InitializeComponent();
            
        }

        private void UpdateFromDatabase()
        {
            this.utilizatori = Utilizator.ReturnStudentsFromDatabase();

            if (utilizatori.Count == 0)
            {
                listUtilizatori.Visible = false;
                listUtilizatori.Enabled = false;
                lbNotFound.Visible = true;
            }
            else
            {
                listUtilizatori.Visible = true;
                listUtilizatori.Enabled = true;
                lbNotFound.Visible = false;
            }

            this.listUtilizatori.DataSource = utilizatori;
            this.listUtilizatori.DisplayMember = "Nume";
            this.listUtilizatori.ValueMember = "IdUser";
            this.listUtilizatori.ClearSelected();
        }

        private void btnPromovare_Click(object sender, EventArgs e)
        {
            if (listUtilizatori.SelectedItem != null)
            {
                Utilizator utilizatorSelectat = (Utilizator)listUtilizatori.SelectedItem;

                DialogResult confirmare = MessageBox.Show("Esti sigur ca doresti sa transformi persoana in administrator?", "Confiramre", MessageBoxButtons.YesNo);
                if (confirmare == DialogResult.Yes)
                {
                    utilizatorSelectat.TipUtilizator = 1;
                    UpdateFromDatabase();
                }

            }
        }

        private void ManageUtilizatori_Load(object sender, EventArgs e)
        {
            UpdateFromDatabase();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (listUtilizatori.SelectedItem != null)
            {
                Utilizator utilizatorSelectat = (Utilizator)listUtilizatori.SelectedItem;

                DialogResult confirmare = MessageBox.Show("Esti sigur ca doresti sa faci acest lucru?", "Confiramre", MessageBoxButtons.YesNo);
                if (confirmare == DialogResult.Yes)
                {
                    utilizatorSelectat.Delete();
                    UpdateFromDatabase();
                }

            }

            UpdateFromDatabase();
        }

        private void listUtilizatori_Format(object sender, ListControlConvertEventArgs e)
        {
            var item = (Utilizator)e.ListItem;

            e.Value = String.Format("{0} {1} - {2}", item.Nume, item.Prenume, item.Email);
        }
    }
}
