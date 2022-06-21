using QUANLYQUANCAFE.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYQUANCAFE.ViewModel
{
    public class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance
        {
            get { if (instance == null) instance = new BanDAO(); return BanDAO.instance; }
            private set { BanDAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private BanDAO() { }

        public List<BAN> LoadTableList()
        {
            List<BAN> tableList = new List<BAN>();

            DataTable data = DataProviderDAO.Instance.ExecuteQuery("select * from tablefood");

            foreach (DataRow item in data.Rows)
            {
                BAN table = new BAN(item);
                tableList.Add(table);
            }

            return tableList;
        }
    }
}
