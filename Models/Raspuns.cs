using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Programville.MainDatabaseDataSetTableAdapters;

namespace Programville
{
    public class Raspuns
    {
        private int idRaspuns, idIntrebare,valid;
        string continut;

        public Raspuns(int _idRaspuns)
        {
            RaspunsuriTableAdapter raspunsuriTA = new RaspunsuriTableAdapter();
            this.idRaspuns = _idRaspuns;
            var dt = raspunsuriTA.GetData();

            var raspunsDB = dt.FindByIdRaspuns(_idRaspuns);
            this.idIntrebare = Convert.ToInt32(raspunsDB["IdIntrebare"]);
            this.continut = Convert.ToString(raspunsDB["Continut"]);
            this.valid = Convert.ToInt32(raspunsDB["valid"]);
 
        }

        public Raspuns(int _idIntrebare, string _continut, int _valid)
        {
            this.continut = _continut;
            this.valid = _valid;
            this.idIntrebare = _idIntrebare;

            RaspunsuriTableAdapter raspunsTA = new RaspunsuriTableAdapter();
            raspunsTA.Insert(continut, valid, idIntrebare);
            this.idRaspuns = Convert.ToInt32(raspunsTA.GetData().Last()["IdRaspuns"]);
        }

        public int IdRaspuns
        {
            get { return this.idRaspuns; }
        }

        public int IdIntrebare
        {
            get { return this.idIntrebare; }
            set
            {
                this.idIntrebare = value;
                RaspunsuriTableAdapter raspunsuriTableAdapter = new RaspunsuriTableAdapter();
                Programville.MainDatabaseDataSet.RaspunsuriDataTable raspunsuri = raspunsuriTableAdapter.GetData();
                raspunsuri.Rows.Find(this.idRaspuns)["IdIntrebare"] = value;
                raspunsuriTableAdapter.Update(raspunsuri);
            }
        }

        public int Valid
        {
            get { return this.valid; }
            set
            {
                this.valid = value;
                RaspunsuriTableAdapter raspunsuriTableAdapter = new RaspunsuriTableAdapter();
                Programville.MainDatabaseDataSet.RaspunsuriDataTable raspunsuri = raspunsuriTableAdapter.GetData();
                raspunsuri.Rows.Find(this.idRaspuns)["Valid"] = value;
                raspunsuriTableAdapter.Update(raspunsuri);
            }
        }

        public string Continut
        {
            get { return this.continut; }
            set
            {
                this.continut = value;
                RaspunsuriTableAdapter raspunsuriTableAdapter = new RaspunsuriTableAdapter();
                Programville.MainDatabaseDataSet.RaspunsuriDataTable raspunsuri = raspunsuriTableAdapter.GetData();
                raspunsuri.Rows.Find(this.idRaspuns)["Continut"] = value;
                raspunsuriTableAdapter.Update(raspunsuri);
            }
        }

        public void DeleteAnswer()
        {
            RaspunsuriTableAdapter raspunsuriTableAdapter = new RaspunsuriTableAdapter();
            Programville.MainDatabaseDataSet.RaspunsuriDataTable raspunsuri = raspunsuriTableAdapter.GetData();

            raspunsuri.Rows.Remove(raspunsuri.FindByIdRaspuns(this.idRaspuns));
            raspunsuriTableAdapter.Delete(this.idRaspuns, this.valid, this.idIntrebare);
        }

    }
}
