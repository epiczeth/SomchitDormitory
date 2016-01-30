using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  System.Data;
using  System.Data.OleDb;
using  System.Diagnostics;

namespace SomchitDormitory
{
   internal class SQL
    {
       private OleDbConnection getOleDbConnection()
       {
           OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\somchit.accdb;Persist Security Info=True");
           try
           {
               conn.Open();
           }
           catch (Exception exception)
           {
               Debug.WriteLine(exception.Message);
           }
           return conn;
       }

       internal int ExecuteNonQuery(string sqlCommand)
       {
           int flag = 0;
           try
           {
               OleDbCommand cmd = new OleDbCommand(sqlCommand,getOleDbConnection());
               flag = cmd.ExecuteNonQuery();
           }
           catch (Exception exception)
           {
                Debug.WriteLine(exception.Message);
           }
           return flag;
       }
       internal int ExecuteScalar(string sqlCommand)
       {
           int flag = 0;
           try
           {
               OleDbCommand cmd = new OleDbCommand(sqlCommand, getOleDbConnection());
               flag = (int)cmd.ExecuteScalar();
           }
           catch (Exception exception)
           {
               Debug.WriteLine(exception.Message);
           }
           return flag;
       }
       internal int ExecuteNonQuery(OleDbCommand incmd)
       {
           int flag = 0;
           try
           {
               OleDbCommand cmd = incmd;
               cmd.Connection = getOleDbConnection();
               flag = cmd.ExecuteNonQuery();
           }
           catch (Exception exception)
           {
               Debug.WriteLine(exception.Message);
           }
           return flag;
       }

       internal DataTable GetDataTable(string sqlCommand)
       {
           DataTable dt = new DataTable();
           try
           {
               OleDbCommand cmd = new OleDbCommand(sqlCommand,getOleDbConnection());
               dt.Load( cmd.ExecuteReader());
           }
           catch (Exception exception)
           {
                Debug.WriteLine(exception.Message);
           }
           return dt;
       }
    }
}
