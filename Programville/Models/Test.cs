using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programville.MainDatabaseDataSetTableAdapters;
using System.Data;

namespace Programville
{
    public class Test
    {
        private Materie materieTest;
        private int idTest;
        private string titlu, caleImagine,descriere;
        private List<Intrebare> intrebari;

        public Test(int _idTest)
        {
            this.idTest = _idTest;
            TesteTableAdapter testeAdapter = new TesteTableAdapter();
            DataTable teste = testeAdapter.GetData();
            DataView testeView = teste.DefaultView;
            testeView.RowFilter = String.Format("IdTest = {0}", _idTest);
            if(testeView.Count == 1)
            {
                this.materieTest = new Materie(Convert.ToInt32(testeView[0]["MaterieID"]));
                this.titlu = Convert.ToString(testeView[0]["titlu"]);
                this.descriere = Convert.ToString(testeView[0]["Descriere"]);
                this.caleImagine = Convert.ToString(testeView[0]["caleImagine"]);
                intrebari = new List<Intrebare>();

                IntrebariTableAdapter intrebariTA = new IntrebariTableAdapter();
                DataTable intrebariTable = intrebariTA.GetData();
                DataView viewIntrebari = intrebariTable.DefaultView;
                viewIntrebari.RowFilter = String.Format("IdTest = {0}", this.idTest);

                foreach (DataRowView dr in viewIntrebari)
                    this.intrebari.Add(new Intrebare(Convert.ToInt32(dr["IdIntrebare"])));
            }
        }

        public Test(string _titlu, Materie _materie, string _descriere, string _caleImagine)
        {
            this.titlu = _titlu;
            this.materieTest = _materie;
            this.descriere = _descriere;
            this.caleImagine = _caleImagine;

            TesteTableAdapter testeAdapter = new TesteTableAdapter();
            testeAdapter.Insert(this.titlu, this.materieTest.IdMaterie, this.caleImagine,this.descriere);

            this.idTest = Convert.ToInt32(testeAdapter.GetData().Last()["IdTest"]);
        }

        public static List<Test> LoadTestsFromDatabase()
        {
            List<Test> listaTeste = new List<Test>();
            TesteTableAdapter testeAdapter = new TesteTableAdapter();
            DataTable testeTabel = testeAdapter.GetData();
            foreach (DataRow dr in testeTabel.Rows)
                listaTeste.Add(new Test(Convert.ToInt32(dr["IdTest"])));

            return listaTeste;
        }

        public int IdTest
        {
            get { return this.idTest; }
        }

        public Materie MaterieTest
        {
            get { return this.materieTest; }
            set
            {
                if (this.materieTest != null)
                {
                    this.materieTest = value;
                    TesteTableAdapter testeTableAdapter = new TesteTableAdapter();
                    Programville.MainDatabaseDataSet.TesteDataTable teste = testeTableAdapter.GetData();
                    teste.Rows.Find(this.idTest)["MaterieID"] = value.IdMaterie;
                    testeTableAdapter.Update(teste);
                }
            }
        }

        public string Descriere
        {
            get { return this.descriere; }
            set {
                this.descriere = value;
                TesteTableAdapter testeTableAdapter = new TesteTableAdapter();
                Programville.MainDatabaseDataSet.TesteDataTable teste = testeTableAdapter.GetData();
                teste.Rows.Find(this.idTest)["Descriere"] = value;
                testeTableAdapter.Update(teste);
            }
        }

        public string Titlu
        {
            get { return this.titlu; }
            set {

                this.titlu = value;
                TesteTableAdapter testeTableAdapter = new TesteTableAdapter();
                Programville.MainDatabaseDataSet.TesteDataTable teste = testeTableAdapter.GetData();
                teste.Rows.Find(this.idTest)["Titlu"] = value;
                testeTableAdapter.Update(teste);
            }
        }

        public string CaleImagine
        {
            get { return this.caleImagine; }
            set
            {
                this.caleImagine = value;
                TesteTableAdapter testeTableAdapter = new TesteTableAdapter();
                Programville.MainDatabaseDataSet.TesteDataTable teste = testeTableAdapter.GetData();
                teste.Rows.Find(this.idTest)["CaleImagine"] = value;
                testeTableAdapter.Update(teste);
            }
        }

        public List<Intrebare> Intrebari
        {
            get { return this.intrebari; }
            set { this.intrebari = value; }
        }

        public void Delete()
        {
            foreach (Intrebare intrebare in intrebari)
                intrebare.Delete();

            intrebari.Clear();
            TesteTableAdapter testeTableAdapter = new TesteTableAdapter();
            Programville.MainDatabaseDataSet.TesteDataTable teste = testeTableAdapter.GetData();
            teste.Rows.Remove(teste.FindByIdTest(this.idTest));

            testeTableAdapter.Delete(this.idTest,this.materieTest.IdMaterie);
        }



    }
}
