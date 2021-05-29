using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Programville
{
    public partial class EditorIntrebari : Form
    {
        Test testCreat;
        Intrebare intrebareCr;
        int indexIntrebari = 0;

        public EditorIntrebari(Test _testCreat)
        {
            InitializeComponent();

            testCreat = _testCreat;
            if (testCreat.Intrebari == null)
            {
                testCreat.Intrebari = new List<Intrebare>();
            }
            else
                NavigareIntrebare(0);
            
        }

        private bool ValidateInput()
        {
            if (String.IsNullOrWhiteSpace(txtCerinta.Text) || panelVariante.Controls.Count == 0)
                return false;

            bool raspunsSelectat = false;
            foreach (Control ctrl in panelVariante.Controls)
                if (ctrl is RadioBoxWithTextBox)
                {
                    var box = (RadioBoxWithTextBox)ctrl;
                    if (String.IsNullOrWhiteSpace(box.input))
                        return false;
                    if (box.valid == 1)
                        raspunsSelectat = true;
                }

            return raspunsSelectat;
        }

        private void ResetInputs()
        {
            intrebareCr = null;
            picImagineCerinta.Image = null;
            txtCerinta.Clear();
            panelVariante.Controls.Clear();

        }

        private void SalvareIntrebare()
        {
            if (intrebareCr == null)
            {
                intrebareCr = new Intrebare(testCreat.IdTest, txtCerinta.Text);
                intrebareCr.Variante = new List<Raspuns>();

                foreach (Control ctrl in panelVariante.Controls)
                    if (ctrl is RadioBoxWithTextBox)
                    {
                        var box = (RadioBoxWithTextBox)ctrl;
                        intrebareCr.Variante.Add(new Raspuns(intrebareCr.IdIntrebare, box.input, box.valid));
                    }

                if (picImagineCerinta.Image != null)
                {
                    string[] poze = Directory.GetFiles(Application.StartupPath + @"\preview_intrebari\");
                    int countPoze = poze.Length + 1;
                    string calePoza = @"\preview_intrebari\" + String.Format("{0}-{1}", intrebareCr.IdTest, countPoze) + ".bmp";
                    picImagineCerinta.Image.Save(Application.StartupPath + calePoza, ImageFormat.Bmp);
                    intrebareCr.CaleImagine = calePoza;
                }

                testCreat.Intrebari.Add(intrebareCr);

                indexIntrebari = testCreat.Intrebari.Count - 1;
                NavigareIntrebare(indexIntrebari);
            }
            else
            {
                intrebareCr.Cerinta = txtCerinta.Text;
                int count = 0;

                if (picImagineCerinta.Image != null)
                {
                    if (!String.IsNullOrWhiteSpace(Convert.ToString(picImagineCerinta.Tag)))
                    {
                        string[] poze = Directory.GetFiles(Application.StartupPath + @"\preview_intrebari\");
                        int countPoze = poze.Length + 1;
                        string calePoza = @"\preview_intrebari\" + String.Format("{0}-{1}", intrebareCr.IdTest, countPoze) + ".bmp";
                        picImagineCerinta.Image.Save(Application.StartupPath + calePoza, ImageFormat.Bmp);
                        intrebareCr.CaleImagine = calePoza;
                    }
                }


                foreach (Control ctrl in panelVariante.Controls)
                    if (ctrl is RadioBoxWithTextBox)
                    {
                        
                        var box = (RadioBoxWithTextBox)ctrl;

                        if (count + 1 > intrebareCr.Variante.Count)
                            intrebareCr.Variante.Add(new Raspuns(intrebareCr.IdIntrebare, box.input, box.valid));
                        else
                        {
                            intrebareCr.Variante[count].Continut = box.input;
                            intrebareCr.Variante[count].Valid = box.valid;
                            count++;
                        }
                    }
            }
            

        }

        private void NavigareIntrebare(int pos)
        {
            
            ResetInputs();
            lbIntrebari.Text = String.Format("Intrebarea {0} din {1}", pos+1, testCreat.Intrebari.Count);
            intrebareCr = testCreat.Intrebari[pos];
            txtCerinta.Text = intrebareCr.Cerinta;

            if (!String.IsNullOrWhiteSpace(intrebareCr.CaleImagine))
                picImagineCerinta.Image = Image.FromFile(Application.StartupPath + intrebareCr.CaleImagine);
            else
                picImagineCerinta.Image = null;

            int posRasp = 0;
            foreach (Raspuns rasp in intrebareCr.Variante)
            {
                var box = new RadioBoxWithTextBox(rasp.Continut, rasp.Valid);
                box.Tag = posRasp;
                panelVariante.Controls.Add(box);
                posRasp++;
            }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == true)
                SalvareIntrebare();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetInputs();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(indexIntrebari + 1 < testCreat.Intrebari.Count)
            {
                indexIntrebari++;
                NavigareIntrebare(indexIntrebari);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (indexIntrebari - 1 >= 0)
            {
                indexIntrebari--;
                NavigareIntrebare(indexIntrebari);
            }
        }
            
        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            panelVariante.Controls.Add(new RadioBoxWithTextBox());
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditorIntrebari_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(testCreat.Intrebari.Count == 0)
            {
                MessageBox.Show("Nu puteți ieși din editorul de test dacă acesta nu conține nicio întrebare!", "Atenție!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                e.Cancel = true;
            }
            else
            {
                var window = MessageBox.Show("Doriți să ieșiti din editarea testului?\n Nu uitați să salvați orice modificare!", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (window == DialogResult.No)
                    e.Cancel = true;
                else
                    this.DialogResult = DialogResult.OK;
            }
        }

        private void btnNextAll_Click(object sender, EventArgs e)
        {
            indexIntrebari = testCreat.Intrebari.Count - 1;
            NavigareIntrebare(indexIntrebari);
        }

        private void btnPrevAll_Click(object sender, EventArgs e)
        {
            indexIntrebari = 0;
            NavigareIntrebare(indexIntrebari);
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int index = panelVariante.Controls.Count - 1;
            panelVariante.Controls.RemoveAt(index);

            if (intrebareCr != null)
            {
                int posRaspuns = Convert.ToInt32(panelVariante.Controls[index].Tag);
                this.intrebareCr.Variante[posRaspuns].DeleteAnswer();
                this.intrebareCr.Variante.RemoveAt(posRaspuns);
            }

            testCreat.Intrebari[indexIntrebari] = intrebareCr;

        }

        private void btnLoadImagine_Click(object sender, EventArgs e)
        {
            OpenFileDialog pozaDialog = new OpenFileDialog();

            if (pozaDialog.ShowDialog() == DialogResult.OK)
            {
                string calePoza = pozaDialog.FileName;
                picImagineCerinta.Image = Image.FromFile(calePoza);
                picImagineCerinta.Tag = calePoza;

            }
        }
    }
}
