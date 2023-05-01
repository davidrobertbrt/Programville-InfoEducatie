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
                        string path = PhotoManager.SaveImage(picPreviewTest.Image, "TestPreviews", this.crTest.IdTest);
                        crTest.CaleImagine = path;
                        
                    }
                    

                    this.Hide();
                    DialogResult confirm = new EditorIntrebari(crTest).ShowDialog();

                    if(picPreviewTest.Image != null)
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
                        if (picPreviewTest.Image != null)
                        {
                            string path = PhotoManager.SaveImage(picPreviewTest.Image, "TestPreviews", this.crTest.IdTest);
                            crTest.CaleImagine = path;
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
                if(!String.IsNullOrWhiteSpace(crTest.CaleImagine))
                    picPreviewTest.Image = PhotoManager.LoadImage(crTest.CaleImagine); 
            }

        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picPreviewTest.Image = new Bitmap(open.FileName);
            }
        }

    }
}
