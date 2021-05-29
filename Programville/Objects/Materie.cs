using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Programville.MainDatabaseDataSetTableAdapters;

namespace Programville
{
    public class Materie
    {
        private int idMaterie;
        private string nume;


        public Materie(int _idMaterie)
        {
            MateriiTableAdapter materiiAdapter = new MateriiTableAdapter();
            DataTable materii = materiiAdapter.GetData();
            DataView viewMaterii = materii.DefaultView;

            viewMaterii.RowFilter = String.Format("IdMaterie = {0}", _idMaterie);
            if (viewMaterii.Count == 1)
            {
                this.nume = Convert.ToString(viewMaterii[0]["NumeMaterie"]);
                this.idMaterie = Convert.ToInt32(viewMaterii[0]["IdMaterie"]);
            }
            else
                throw new Exception("Materia nu a putut fi initializata dupa ID!");
        }

        public Materie(string _nume)
        {
            this.nume = _nume;

            MateriiTableAdapter materiiAdapter = new MateriiTableAdapter();
            materiiAdapter.Insert(this.nume);

            this.idMaterie =  Convert.ToInt32(materiiAdapter.GetData().Last()["IdMaterie"]);
        }


        public static List<Materie> LoadMateriiFromDatabase()
        {
            MateriiTableAdapter materiiAdapter = new MateriiTableAdapter();
            List<Materie> listMaterii = new List<Materie>();
            DataTable tableDbMaterii = materiiAdapter.GetData();
            foreach (DataRow dr in tableDbMaterii.Rows)
                listMaterii.Add(new Materie(Convert.ToInt32(dr["IdMaterie"])));

            return listMaterii;

        }


        public string Nume
        {
            get { return this.nume; }
            set { 
                MateriiTableAdapter materiiAdapter = new MateriiTableAdapter();
                materiiAdapter.Update(value, this.idMaterie);
                this.nume = value;

            }
        }

        public int IdMaterie
        {
            get { return this.idMaterie; }
        }

    }
}
