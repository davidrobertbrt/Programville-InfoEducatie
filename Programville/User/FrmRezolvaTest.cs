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
    public partial class FrmRezolvaTest : Form
    {
        RezultateTableAdapter rezultateTA = new RezultateTableAdapter();

        Utilizator crUser;

        Test crTest;
        List<int> inputUser;

        int indexIntrebari = 0;
        int intrebariRezolvate = 0;
        int punctaj = 0;

        public FrmRezolvaTest(Utilizator _crUser,Test _crTest)
        {
            crTest = _crTest;
            crUser = _crUser;
            inputUser = Enumerable.Repeat(-1, crTest.Intrebari.Count).ToList();
            InitializeComponent();
        }

        private void ClearInput()
        {
            panelVariante.Enabled = true;
            btnSend.Enabled = true;
            picImagineCerinta.Image = null;
            txtCerinta.Clear();
            panelVariante.Controls.Clear();
        }

        private bool CheckAnswerInput()
        {
            bool selected = false;
            foreach(Control x in panelVariante.Controls)
            {
                if(x is RadioButton)
                {
                    var box = (RadioButton)x;
                    if (box.Checked == true)
                    {
                        selected = true;
                        break;
                    }
                }
            }

            if(selected == false)
            {
                MessageBox.Show("Nu ai selectat niciun raspuns!");
                return false;
            }

            return true;
        }

        private bool ValidateAnswerInput()
        {
            foreach (Control x in panelVariante.Controls)
            {
                if (x is RadioButton)
                {
                    var box = (RadioButton)x;
                    if (Convert.ToBoolean(box.Checked) == Convert.ToBoolean(box.Tag) && Convert.ToBoolean(box.Tag) == true)
                    {
                        MessageBox.Show("Raspuns corect!");

                        return true;
                    }
                }
            }
            MessageBox.Show("Raspuns gresit!");
            return false;
        }


        private void LoadIntrebare(int pos)
        {
            ClearInput();

            lbIntrebari.Text = String.Format("Întrebarea {0} din {1}", pos+1, crTest.Intrebari.Count.ToString());

            txtCerinta.Text = crTest.Intrebari[pos].Cerinta;
            if (!String.IsNullOrWhiteSpace(crTest.Intrebari[pos].CaleImagine))
                picImagineCerinta.Image = Image.FromFile(Application.StartupPath + crTest.Intrebari[pos].CaleImagine);

            foreach (Raspuns r in crTest.Intrebari[pos].Variante)
            {
                var varianta = new RadioButton();
                varianta.AutoSize = true;
                varianta.Text = r.Continut;
                varianta.Tag = r.Valid;
                panelVariante.Controls.Add(varianta);
            }

            if(inputUser[pos] != -1)
            {
                panelVariante.Enabled = false;
                btnSend.Enabled = false;
            }

           
        }

        private void LoadTest()
        {
            lbTest.Text = crTest.Titlu;
            LoadIntrebare(indexIntrebari);
        }

        private void FrmRezolvaTest_Load(object sender, EventArgs e)
        {
            LoadTest();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(CheckAnswerInput() == true)
            {
                intrebariRezolvate++;
                if(ValidateAnswerInput() == true)
                {
                    inputUser[indexIntrebari] = 1;
                    punctaj++;
                }
                else
                {
                    inputUser[indexIntrebari] = 0;
                }

                if (indexIntrebari + 1 < crTest.Intrebari.Count)
                {
                    indexIntrebari++;
                    LoadIntrebare(indexIntrebari);
                }
            }

            if(intrebariRezolvate == crTest.Intrebari.Count)
            {
                string final = String.Format("Felicitari!\n Ai obținut {0}p din {1}p", punctaj, crTest.Intrebari.Count);
                MessageBox.Show(final, "Rezultat final!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                rezultateTA.Insert(crTest.IdTest,crUser.IdUser, punctaj, DateTime.Now);

                this.Close();
            }
        }

        private void FrmRezolvaTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (intrebariRezolvate != crTest.Intrebari.Count)
            {
                DialogResult input = MessageBox.Show("Nu ai terminat de rezolvat tot testul!\n Rezolvarea ta va fi anulata!", "Atenție!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (input == DialogResult.No)
                    e.Cancel = true;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(indexIntrebari + 1 < crTest.Intrebari.Count)
            {
                indexIntrebari++;
                LoadIntrebare(indexIntrebari);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (indexIntrebari - 1 >= 0)
            {
                indexIntrebari--;
                LoadIntrebare(indexIntrebari);
            }
        }
    }
}
