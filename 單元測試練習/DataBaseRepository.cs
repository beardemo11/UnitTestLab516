using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace UnitTestLab1
{
    public class DataBaseRepository
    {
        public string GetConnString()
        {
            string connString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            return connString;
        }


        public DataTable SelectDataTable(string connString,string strSql, ArrayList aryFild, ArrayList aryValue)
        {
            DataTable dtTmp = new DataTable();
            SqlConnection sqlConn = new SqlConnection(connString);
            SqlCommand sqlCmd = new SqlCommand(strSql, sqlConn);
            using (sqlConn)
            {
                using (sqlCmd)
                {
                    sqlConn.Open();
                    if (aryFild.Count > 0)
                    {
                        int intI = 0;
                        for (intI = 0; intI <= aryFild.Count - 1; intI++)
                        {
                            sqlCmd.Parameters.AddWithValue("@" + aryFild[intI], aryValue[intI]);
                        }

                    }

                    dtTmp.Load(sqlCmd.ExecuteReader());
                }
            }

            return dtTmp;

        }


    }
}
