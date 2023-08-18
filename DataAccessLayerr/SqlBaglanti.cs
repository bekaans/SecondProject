using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerr
{
    public class SqlBaglanti
    {
        public static SqlConnection sql = new SqlConnection(@"Data Source=localhost;Initial Catalog=DbYazOkulu;Integrated Security=True");
    }
}
