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
    public partial class FrmCreatorTest : Form
    {
        Test crTest;
        public FrmCreatorTest()
        {
            InitializeComponent();
        }

        public FrmCreatorTest(Test _crTest) ///Edit mode
        {
            crTest = _crTest;
            InitializeComponent();
        }

        private bool ValidateInput()
        {
            if(comboMaterie.SelectedItem == null)
            {
                MessageBox.Show("Nu ați selectat o materie!");
                return false;
            }

            foreach(Control x in this.Controls)
            {
                if(x is TextBox)
                {
                    var box = (TextBox)x;
                    if(String.IsNullOrWhiteSpace(box.Text))
                    {
                        MessageBox.Show("Nu ati completat un câmp al testului!");
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == true)
            {
                if (crTest == null)
                {
                    crTest = new Test(txtTitlu.Text, (Materie)comboMaterie.SelectedItem, txtDescriere.Text, "");
                    if (picPreviewTest.Image != null)
                    {
                        string[] poze = Directory.GetFiles(Application.StartupPath + @"\preview_tests\");
                        int count = poze.Length + 1;
                        picPreviewTest.Image.Save(Application.StartupPath + @"\preview_tests\" + String.Format("{0}-{1}", crTest.IdTest, count) + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                        crTest.CaleImagine = @"\preview_tests\" + String.Format("{0}-{1}", crTest.IdTest, count) + ".bmp";
                    }

                    

                    this.Hide();
                    DialogResult confirm = new EditorIntrebari(crTest).ShowDialog();

                    crTest.CaleImagine = "";

                    if (confirm == DialogResult.OK)
                    {
                        this.Close();
                    }
                    else
                    {
                        crTest.Delete();
                        this.Close();
                    }
                }
                else
                {
                    crTest.Titlu = txtTitlu.Text;
                    crTest.Descriere = txtDescriere.Text;
                    if (picPreviewTest.Image != null)
                    {
                        if (!String.IsNullOrWhiteSpace(Convert.ToString(picPreviewTest.Tag)))
                        {
                            string[] poze = Directory.GetFiles(Application.StartupPath + @"\preview_tests\");
                            int count = poze.Length + 1;
                            picPreviewTest.Image.Save(Application.StartupPath + @"\preview_tests\" + String.Format("{0}-{1}", crTest.IdTest, count) + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                            crTest.CaleImagine = @"\preview_tests\" + String.Format("{0}-{1}", crTest.IdTest, count) + ".bmp";
                        }
                    }
      
                    

                    this.Hide();
                    DialogResult confirm = new EditorIntrebari(crTest).ShowDialog();

                    if (confirm == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }


        }

        private void FrmCreatorTest_Load(object sender, EventArgs e)
        {
            comboMaterie.DataSource = Materie.LoadMateriiFromDatabase();
            comboMaterie.DisplayMember = "Nume";
            comboMaterie.ValueMember = "IdMaterie";

            if (comboMaterie.Items.Count == 0)
            {
                MessageBox.Show("Nu ati adaugat nicio materie! Adaugați o materie din meniul principal pentru a realiza un test...", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            if(crTest != null)
            {
                txtTitlu.Text = crTest.Titlu;
                comboMaterie.SelectedItem = crTest.MaterieTest;
                txtDescriere.Text = crTest.Descriere;
                if(File.Exists(Application.StartupPath + crTest.CaleImagine) && !String.IsNullOrEmpty(crTest.CaleImagine))
                    picPreviewTest.Image = Image.FromFile(Application.StartupPath + crTest.CaleImagine);
                else
                    picPreviewTest.Image = null; 
            }

        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {

            OpenFileDialog pozaDialog = new OpenFileDialog();

            if (pozaDialog.ShowDialog() == DialogResult.OK)
            {
                string calePoza = pozaDialog.FileName;
                picPreviewTest.Image = Image.FromFile(calePoza);
                picPreviewTest.Tag = calePoza;
            }
        }

        private void picPreviewTest_Paint(object sender, PaintEventArgs e)
        {
            if (picPreviewTest.Image == null)
                lbNotFound.Visible = true;
            else
                lbNotFound.Visible = false;
        }
    }
}
