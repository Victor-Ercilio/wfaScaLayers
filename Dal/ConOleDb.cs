using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.CodeDom;

namespace Dal
{
    public class ConOleDb
    {
        readonly OleDbConnection myDBConnection = new OleDbConnection(Properties.Settings.Default.sca);

        public void OpenConnection()
        {
            try
            {
                myDBConnection.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myDBConnection.Close();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public DataSet ReturnDataSet(string sql)
        {
            try
            {
                OpenConnection();
                OleDbDataAdapter oDa = new OleDbDataAdapter(sql, myDBConnection);
                DataSet oDs = new DataSet();
                oDa.Fill(oDs);
                return oDs;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable ReturnDataTable(OleDbCommand cmd)
        {
            try
            {
                OpenConnection();
                if(cmd.Connection == null)
                {
                    cmd.Connection = myDBConnection;
                    cmd.Prepare();
                }
                OleDbDataAdapter oDa = new OleDbDataAdapter(cmd);
                DataTable oDt = new DataTable();
                oDa.Fill(oDt);
                return oDt;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public object ReturnScalar(OleDbCommand cmd)
        {
            try
            {
                OpenConnection();
                if (cmd.Connection == null)
                    cmd.Connection = myDBConnection;
                return cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void ExecuteNQ(OleDbCommand cmd)
        {
            try
            {
                OpenConnection();
                if(cmd.Connection is null)
                {
                    cmd.Connection = myDBConnection;
                }
                cmd.ExecuteNonQuery();
            }
            catch(Exception )
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void ExecutaNQ(string sql)
        {
            try
            {
                OpenConnection();
                OleDbCommand command = new OleDbCommand(sql, myDBConnection);
                command.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Dispose()
        {
            myDBConnection.Dispose();
        }
    }
}
