using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Classes
{
    public class Tovar
    {
        public int id;
        public string name;
        public int max_skidka;
        public int skidka;
        public float cost;
        public int id_category;
        public string category;
        public int id_postavhik;
        public string postavhik;
        public int id_company;
        public string company;

        public static List<Tovar> getTovars()
        {
            List<Tovar> tovars = new List<Tovar>();
            string select = "select t.*, ct.name as category, pt.name as postavhik, cp.name as company from tovar t" +
                " inner join category ct on t.id_category = ct.id" +
                " inner join postavhik pt on t.id_category = pt.id" +
                " inner join company cp on t.id_category = cp.id;";

            DB db = new DB();
            db.openConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(select, db.getConnection());
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Tovar tovar = new Tovar();
                tovar.id = Convert.ToInt32(reader["id"]);
                tovar.name = Convert.ToString(reader["name"]);
                tovar.max_skidka = Convert.ToInt32(reader["max_skidka"]);
                tovar.skidka = Convert.ToInt32(reader["skidka"]);
                tovar.cost = (float)Convert.ToInt32(reader["cost"]);
                tovar.id_category = Convert.ToInt32(reader["id_category"]);
                tovar.category = Convert.ToString(reader["category"]);
                tovar.id_postavhik = Convert.ToInt32(reader["id_postavhik"]);
                tovar.postavhik = Convert.ToString(reader["postavhik"]);
                tovar.id_company = Convert.ToInt32(reader["id_company"]);
                tovar.company = Convert.ToString(reader["company"]);

                tovars.Add(tovar);
            }
            return tovars;
        }
    }
}
