using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace clase
{
    public class Class1
    {
        
public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=LAPTOP-VLHH2QQV; Initial Catalog = BDPuntoVenta; Integrated security = SSPI ;");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);
            DP.Fill(DS);
            Con.Close();

            return DS;

        }
    }
    
}
