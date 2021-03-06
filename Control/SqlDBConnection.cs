﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Server.Control.Data
{
    public class SqlDbConnection
    {
        static object locker = new object();

        public static DbConnection Conection()
        {
            var dsConexao = new DataSet();

            dsConexao.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"\Conn.xml");

            DbProviderFactory provedor = DbProviderFactories.GetFactory("System.Data.SqlClient");

            DbConnection conection = provedor.CreateConnection();

            conection.ConnectionString = "Data Source=FRED-PC;Initial Catalog=VendasOk;Integrated Security=False;User ID=sa;Password=frd2211;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            /**Método para testar a conexão com o banco e capturar as exceptions**/
            //try
            //{
            //    SqlConnection cn = new SqlConnection("Data Source=FRED-PC;Initial Catalog=Vendas;Integrated Security=False;User ID=sa;Password=frd2211;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //    cn.Open();
            //}
            //catch (SqlException ex)
            //{
            //    Console.WriteLine("Error {0} ErrorCode {1} LineNumber {2}  Number {3}", ex.Message, ex.ErrorCode, ex.LineNumber, ex.Number);
            //    foreach (SqlError err in ex.Errors)
            //    {
            //        Console.WriteLine("** Error : {0} LineNumber {1} Number {2}",err.Message,err.LineNumber,err.Number);
            //    }
            //    if (ex.InnerException != null)
            //    {
            //        Console.WriteLine("Inner1 : {0}", ex.InnerException.Message);
            //    }
            //}


            return conection;

        }
    }
}

