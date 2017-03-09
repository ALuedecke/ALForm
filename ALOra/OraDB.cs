using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess.Client;

namespace ALOra
{
    public class OraDB : IOraDB
    {
        /* Class members */
        private Credentials mCredendials = new Credentials();
        private List<OracleCommand> mCommands;
        private OracleConnection mConnection;
        private OracleTransaction mTransaction;
        private string mSqlStmt;

        /* Constructors */
        public OraDB() { }

        public OraDB(Credentials pCredentials)
        {
            mCredendials = pCredentials;
        }

        public OraDB(string pDataSrc, string pUserId, string pPassword)
        {
            mCredendials.DataSource = pDataSrc;
            mCredendials.Password = pPassword;
            mCredendials.UserId = pUserId;
        }

        /* Properties */
        public string ConnectString
        {
            get
            {
                return mCredendials.ConnectString;
            }
        }

        public Credentials Credentials
        {
            get { return mCredendials; }
            set { mCredendials = value; }
        }

        public List<OracleCommand> OraCommands
        {
            get
            {
                return mCommands;
            }
        }

        public OracleConnection OraConnection
        {
            get
            {
                return mConnection;
            }
        }

        public string SqlStmt
        {
            get { return mSqlStmt; }

            set { mSqlStmt = value; }
        }

        /* Public methods */
        public void addCommand()
        {
            addCommand(mSqlStmt);
        }

        public void addCommand(string pStmt)
        {
            if (mConnection.Equals(null))
            {
                mConnection = new OracleConnection(ConnectString);
            }

            mCommands.Add(getCommand(mConnection, pStmt));
        }

        public void beginTrans()
        {
            mTransaction = mConnection.BeginTransaction();
        }

        public void commitTrans(bool pPreserveStmts = false)
        {
            mTransaction.Commit();

            if (!pPreserveStmts)
            {
                mCommands.Clear();
            }

            mTransaction.Dispose();
        }

        public void execCommands(bool pUseTransaction = true)
        {
            foreach (OracleCommand cmd in mCommands)
            {
                if (pUseTransaction)
                {
                    cmd.Transaction = mTransaction;
                }

                cmd.ExecuteNonQuery();
            }
        }

        public int execStmt()
        {
            return execStmt(mSqlStmt);
        }

        public int execStmt(string pStmt)
        {
            int retval;

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = ConnectString;

            OracleCommand sqlCmd = getCommand(conn, pStmt);

            retval = sqlCmd.ExecuteNonQuery();

            conn.Close();
            sqlCmd.Dispose();
            conn.Dispose();

            return retval;
        }

        public void exportToExcel(DataTable pDataTbl)
        {
            throw new NotImplementedException();
        }

        public DataSet getDataSet(DataTable pDataTbl)
        {
            return pDataTbl.DataSet;
        }

        public string getHtml(DataTable pDataTbl)
        {
            bool   header = true;
            string col = "\n    <td>:VALUE:</td>";
            string cols;
            string heads = "";
            string row = "\n  <tr>\n:COLS:</tr>";
            string rows = "";
            string table = "<table>:ROWS:\n</table>";

            foreach (DataRow r in pDataTbl.Rows)
            {
                cols = "";
                foreach (DataColumn c in pDataTbl.Columns)
                {
                    if (header)
                    {
                        heads += col.Replace(":VALUE:", c.ColumnName);
                    }

                    cols += col.Replace(":VALUE:", r[c].ToString());
                }

                if (header)
                {
                    rows += row.Replace(":COLS:", heads);
                    header = false;
                }

                rows += row.Replace(":COLS:", cols);
            }

            table = table.Replace(":ROWS:", rows);

            return table;
        }

        public void rollbackTrans(bool pPreserveStmts = true)
        {
            mTransaction.Rollback();

            if (!pPreserveStmts)
            {
                mCommands.Clear();
            }

            mTransaction.Dispose();
        }

        public DataTable runQuery()
        {
            return runQuery(mSqlStmt);
        }

        public DataTable runQuery(string pSql)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = ConnectString;

            DataTable dt = new DataTable();
            OracleCommand sqlCmd = getCommand(conn, pSql);
            OracleDataAdapter sqlDataAdap = new OracleDataAdapter(sqlCmd);

            sqlDataAdap.Fill(dt);

            conn.Close();
            sqlDataAdap.Dispose();
            sqlCmd.Dispose();
            conn.Dispose();
            return dt;
        }

        /* Private methods */

        private OracleCommand getCommand(OracleConnection pConn, string pSql)
        {
            mSqlStmt = pSql;

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = pConn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = mSqlStmt;

            return cmd;
        }
    }
}
