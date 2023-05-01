using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Programville.MainDatabaseDataSetTableAdapters;

namespace Programville
{
    public class Recenzie
    {
        private int id, scor;
        private string descriere;
        private Utilizator creator;
        private Test testEvaluat;
        private DateTime dataRecenzie;

        public Recenzie(int _id)
        {
            RecenziiTableAdapter recenziiAdapter = new RecenziiTableAdapter();
            DataTable recenzii = recenziiAdapter.GetData();
            DataView viewRecenzii = recenzii.DefaultView;

            viewRecenzii.RowFilter = String.Format("Id = {0}", _id);

            if (viewRecenzii.Count == 1)
            {
                this.descriere = Convert.ToString(viewRecenzii[0]["Descriere"]);
                this.id = Convert.ToInt32(viewRecenzii[0]["Id"]);
                this.scor = Convert.ToInt32(viewRecenzii[0]["Scor"]);
                this.creator = new Utilizator(Convert.ToInt32(viewRecenzii[0]["CreatedUserID"]));
                this.testEvaluat = new Test(Convert.ToInt32(viewRecenzii[0]["TestID"]));
                this.dataRecenzie = Convert.ToDateTime(viewRecenzii[0]["DataRecenzie"]);
            }
            else
                throw new Exception("Recenzia nu a putut fi initializata dupa ID!");
        }

        public Recenzie(string _descriere, int _scor, Utilizator _creator, Test _testEvaluat,DateTime _dataRecenzie)
        {
            descriere = _descriere;
            scor = _scor;
            creator = _creator;
            testEvaluat = _testEvaluat;
            dataRecenzie = _dataRecenzie;

            RecenziiTableAdapter recenziiAdapter = new RecenziiTableAdapter();
            recenziiAdapter.Insert(scor, descriere, creator.IdUser, testEvaluat.IdTest, dataRecenzie);
            id = Convert.ToInt32(recenziiAdapter.GetData().Last()["Id"]);
        }


        public void Delete()
        {
            RecenziiTableAdapter recenziiAdapter = new RecenziiTableAdapter();
            Programville.MainDatabaseDataSet.RecenziiDataTable recenzii = recenziiAdapter.GetData();
            recenzii.Rows.Remove(recenzii.FindById(this.id));
            recenziiAdapter.Delete(this.id);
        }

        public static List<Recenzie> LoadRecenziiFromDatabase()
        {
            RecenziiTableAdapter recenziiAdapter = new RecenziiTableAdapter();
            List<Recenzie> listRecenzii = new List<Recenzie>();
            DataTable tableDbRecenzii = recenziiAdapter.GetData();
            foreach (DataRow dr in tableDbRecenzii.Rows)
                listRecenzii.Add(new Recenzie(Convert.ToInt32(dr["Id"])));

            return listRecenzii;

        }

        public int Id
        {
            get { return id; }
        }

        public int Scor
        {
            get { return this.scor; }
            set { this.scor = value; }
        }

        public string Descriere
        {
            get { return this.descriere; }
            set { this.descriere = value; }
        }

        public DateTime DataRecenzie
        {
            get { return this.dataRecenzie; }
            set { this.dataRecenzie = value; }
        }

        public Utilizator Creator
        {
            get { return this.creator; }
            set { this.creator = value; }
        }

        public Test TestEvaluat
        {
            get { return this.testEvaluat; }
            set { this.testEvaluat = value; }
        }

    }
}
