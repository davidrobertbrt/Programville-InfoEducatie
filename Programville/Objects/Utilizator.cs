using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Mail;
using Programville.MainDatabaseDataSetTableAdapters;


namespace Programville
{
    public class Utilizator
    {
        private string nume, prenume, email,password,caleProfilePicture;
        private int idUser, tipUtilizator;

        public Utilizator(int _idUser)
        {
            UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();

            DataTable utilizatori = utilizatoriTableAdapter.GetData();
            DataView viewUser = utilizatori.DefaultView;
            viewUser.RowFilter = String.Format("IdUser = {0}", _idUser);

            if (viewUser.Count != 1)
                throw new Exception("O eroare a aparut in gasirea utilizatorului dupa ID!");
            else
            {
                nume = Convert.ToString(viewUser[0]["Nume"]);
                prenume = Convert.ToString(viewUser[0]["Prenume"]);
                email = Convert.ToString(viewUser[0]["Email"]);
                idUser = _idUser;

                tipUtilizator = Convert.ToInt32(viewUser[0]["TipUtilizator"]);
                caleProfilePicture = Convert.ToString(viewUser[0]["CaleProfilePicutre"]);
                password = Convert.ToString(viewUser[0]["Parola"]);
            }

        }

        public Utilizator(string _nume, string _prenume, string _email, string _password,string _profilePicture ,int _tipUtilizator)
        {
            if (CheckEmailFormat(_email) == true)
            {
                if(ReturnUtilizatorByCredentials(_email,null) == null)
                {
                    this.nume = _nume;
                    this.prenume = _prenume;
                    this.email = _email;
                    this.password = _password;
                    this.caleProfilePicture = _profilePicture;
                    this.tipUtilizator = _tipUtilizator;

                    UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
                    utilizatoriTableAdapter.Insert(_email, _tipUtilizator, _nume, _prenume, _password, _profilePicture);
                    this.idUser = Convert.ToInt32(utilizatoriTableAdapter.GetData().Last()["IdUser"]);
                }
            }
            else
                throw new Exception("Email-ul nu a fost scris in format corect!");
        }

        public  static List<Utilizator> ReturnUtilizatoriFromDatabase()
        {
            List<Utilizator> listUtilizatori = new List<Utilizator>();
            UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
            DataTable tableDbUtilizatori = utilizatoriTableAdapter.GetData();

            foreach (DataRow dr in tableDbUtilizatori.Rows)
                listUtilizatori.Add(new Utilizator(Convert.ToInt32(dr["IdUser"])));

            return listUtilizatori;
        }

        public static List<Utilizator> ReturnAdminsFromDatabase()
        {
            List<Utilizator> listUtilizatori = new List<Utilizator>();
            UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
            DataTable tableDbUtilizatori = utilizatoriTableAdapter.GetData();

            foreach (DataRow dr in tableDbUtilizatori.Rows)
            {
                if(Convert.ToInt32(dr["TipUtilizator"]) == 1)
                    listUtilizatori.Add(new Utilizator(Convert.ToInt32(dr["IdUser"])));
            }

            return listUtilizatori;
        }

        public static List<Utilizator> ReturnStudentsFromDatabase()
        {
            List<Utilizator> listUtilizatori = new List<Utilizator>();
            UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
            DataTable tableDbUtilizatori = utilizatoriTableAdapter.GetData();

            foreach (DataRow dr in tableDbUtilizatori.Rows)
            {
                if (Convert.ToInt32(dr["TipUtilizator"]) == 0)
                    listUtilizatori.Add(new Utilizator(Convert.ToInt32(dr["IdUser"])));
            }

            return listUtilizatori;
        }

        public static Utilizator ReturnUtilizatorByCredentials(string email, string password)
        {
            UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
            DataTable utilizatori = utilizatoriTableAdapter.GetData();
            DataView viewUser = utilizatori.DefaultView;

        

            if (!String.IsNullOrEmpty(password))
                viewUser.RowFilter = String.Format("Email = '{0}' AND Parola = '{1}'", email, password);
            else
                viewUser.RowFilter = String.Format("Email = '{0}'", email);

            if (viewUser.Count == 1)
                return new Utilizator(Convert.ToInt32(viewUser[0]["IdUser"]));
            else
                return null;
        }

        private static bool CheckEmailFormat(string email)
        {
            if (String.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static List<Utilizator> ReturnUtilizatoriFromDB()
        {
            List<Utilizator> utilizatori = new List<Utilizator>();

            DataTable utilizatoriDt = new UtilizatoriTableAdapter().GetData();

            foreach (DataRow dr in utilizatoriDt.Rows)
                utilizatori.Add(new Utilizator(Convert.ToInt32(dr[0])));


            return utilizatori;
        }



        public string Nume
        {
            get { return nume; }
            set
            {
                this.nume = value;
                UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
                Programville.MainDatabaseDataSet.UtilizatoriDataTable users = utilizatoriTableAdapter.GetData();
                users.Rows.Find(this.idUser)["Nume"] = Convert.ToString(nume);
                utilizatoriTableAdapter.Update(users);
            }
        }

        public string Prenume
        {
            get { return prenume; }
            set
            {
                this.nume = value;
                UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
                Programville.MainDatabaseDataSet.UtilizatoriDataTable users = utilizatoriTableAdapter.GetData();
                users.Rows.Find(this.idUser)["Prenume"] = Convert.ToString(prenume);
                utilizatoriTableAdapter.Update(users);
            }
        }

        public string Email
        {
            get { return email; }
        }

        public string Password
        {
            get { return password; }
            set
            {
                this.password = value;
                UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
                Programville.MainDatabaseDataSet.UtilizatoriDataTable users = utilizatoriTableAdapter.GetData();
                users.Rows.Find(this.idUser)["Parola"] = Convert.ToString(password);
                utilizatoriTableAdapter.Update(users);
            }
        }

        public int IdUser
        {
            get { return idUser; }
        }

        public string CaleProfilePicture
        {
            get { return caleProfilePicture; }
            set
            {
                this.caleProfilePicture = value;
                UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
                Programville.MainDatabaseDataSet.UtilizatoriDataTable users = utilizatoriTableAdapter.GetData();
                users.Rows.Find(this.idUser)[6] = this.caleProfilePicture;
                utilizatoriTableAdapter.Update(users);
            }
        }

        public int TipUtilizator
        {
            get { return this.tipUtilizator; }
            set
            {
                this.tipUtilizator = value;
                UtilizatoriTableAdapter utilizatoriTableAdapter = new UtilizatoriTableAdapter();
                Programville.MainDatabaseDataSet.UtilizatoriDataTable users = utilizatoriTableAdapter.GetData();
                users.Rows.Find(this.idUser)["TipUtilizator"] = Convert.ToInt32(tipUtilizator);
                utilizatoriTableAdapter.Update(users);
            }
        }

        public void Delete()
        {
            UtilizatoriTableAdapter utilizatoriTA = new UtilizatoriTableAdapter();
            RezultateTableAdapter rezultateTA = new RezultateTableAdapter();

            if (rezultateTA.GetData().Rows.Count > 0)
                rezultateTA.Delete(this.IdUser);

            utilizatoriTA.Delete(this.IdUser, this.tipUtilizator);
        }

    }
}
