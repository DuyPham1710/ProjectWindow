using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWin_Demo_
{
    internal class NguoiDAO
    {
        DBConnection dBConnection;
        private int id;
        public NguoiDAO(int id)
        {
            this.id = id;
            dBConnection = new DBConnection(id);
        }
        public MemoryStream LoadAvt()
        {
            string query = "SELECT  * FROM Person WHERE id = " + id.ToString();
            return dBConnection.LoadAvt(query);
        }
    }
}
