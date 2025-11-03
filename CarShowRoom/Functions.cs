using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient
using System.Data
namespace CarShowRoom
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConStr;
        public Functions()
        {
            ConStr = @"";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
               Cmd.Connection = Con;
        }
        public DataTable GetData(string Query) {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query,ConStr);
            Sda.Fill(dt);
            return dt;
    }

}
