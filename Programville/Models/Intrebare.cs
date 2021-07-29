using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Programville.MainDatabaseDataSetTableAdapters;

namespace Programville
{
    public class Intrebare
    {
        private int idIntrebare, idTest;
        private string cerinta,caleImagine;

        private List<Raspuns> variante;

        public Intrebare(int _idIntrebare)
        {
            this.idIntrebare = _idIntrebare;
            var intrebareTA = new IntrebariTableAdapter();
            DataTable dt = intrebareTA.GetData();
            DataView dv = dt.DefaultView;

            dv.RowFilter = String.Format("IdIntrebare = {0}", _idIntrebare);
            if (dv.Count == 1)
            {
                this.cerinta = Convert.ToString(dv[0]["Cerinta"]);
                this.idTest = Convert.ToInt32(dv[0]["IdTest"]);
                variante = new List<Raspuns>();

                var raspunsuriTA = new RaspunsuriTableAdapter();
                dt = raspunsuriTA.GetData();
                dv = dt.DefaultView;
                dv.RowFilter = String.Format("IdIntrebare = {0}", _idIntrebare);

                variante = new List<Raspuns>();
                foreach(DataRowView dr in dv)
                    variante.Add(new Raspuns(Convert.ToInt32(dr["IdRaspuns"])));

            }
            else
                throw new Exception("Materia nu a putut fi initializata dupa ID!");
        }
       
        public Intrebare(int _idTest, string _cerinta)
        {
            this.idTest = _idTest;
            this.cerinta = _cerinta;
           

            var intrebariTA = new IntrebariTableAdapter();
            intrebariTA.Insert(this.idTest, this.cerinta,null);
            this.idIntrebare = Convert.ToInt32(intrebariTA.GetData().Last()["IdIntrebare"]);
        }

        public int IdIntrebare
        {
            get { return this.idIntrebare; }
        }

        public int IdTest
        {
            get { return this.idTest; }
            set
            {
                this.idTest = value;
                IntrebariTableAdapter intrebariTableAdapter = new IntrebariTableAdapter();
                Programville.MainDatabaseDataSet.IntrebariDataTable intrebari = intrebariTableAdapter.GetData();
                intrebari.Rows.Find(this.idIntrebare)["idTest"] = value;
                intrebariTableAdapter.Update(intrebari);
            }
        }

        public string Cerinta
        {
            get { return this.cerinta; }
            set
            {
                this.cerinta = value;
                IntrebariTableAdapter intrebariTableAdapter = new IntrebariTableAdapter();
                Programville.MainDatabaseDataSet.IntrebariDataTable intrebari = intrebariTableAdapter.GetData();
                intrebari.Rows.Find(this.idIntrebare)["cerinta"] = value;
                intrebariTableAdapter.Update(intrebari);
            }
        }

        public List<Raspuns> Variante
        {
            get { return this.variante; }
            set
            {
                this.variante = value;
            }
        }

        public string CaleImagine
        {
            get { return this.caleImagine; }
            set
            {
                this.caleImagine = value;
                IntrebariTableAdapter intrebariTableAdapter = new IntrebariTableAdapter();
                Programville.MainDatabaseDataSet.IntrebariDataTable intrebari = intrebariTableAdapter.GetData();
                intrebari.Rows.Find(this.idTest)["CaleImagine"] = value;
                intrebariTableAdapter.Update(intrebari);
            }
        }

        public void Delete()
        {
            foreach (Raspuns raspuns in variante)
            {
                raspuns.DeleteAnswer();
            }
            variante.Clear();

            IntrebariTableAdapter intrebariTableAdapter = new IntrebariTableAdapter();
            Programville.MainDatabaseDataSet.IntrebariDataTable intrebari = intrebariTableAdapter.GetData();

            intrebari.Rows.Remove(intrebari.FindByIdIntrebare(this.IdIntrebare));
            intrebariTableAdapter.Delete(this.idIntrebare, this.idTest);
        }

    }
}
