using Oracle.DataAccess.Client;
using System.Data;

namespace ALForm
{
    public class OraDB
    {
        /* Class members */
        private Credentials mCredendials = new Credentials();
        private string mSqlStmt;

        /* Constructors */
        public OraDB () { }

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
        
        public string DataSource
        {
            get { return mCredendials.DataSource; }
        }

        public string Password
        {
            get { return mCredendials.Password; }
        }

        public string UserId
        {
            get { return mCredendials.UserId; }
        }

        public string SqlStmt
        {
            get { return mSqlStmt; }
            set { mSqlStmt = value; }
        }

        /* Public methods */

        public int execSql()
        {
            return execSql(mSqlStmt);
        }

        public int execSql(string pSql)
        {
            int retval;

            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = ConnectString;

            OracleCommand sqlCmd = getCommand(conn, pSql);

            retval = sqlCmd.ExecuteNonQuery();

            conn.Close();
            sqlCmd.Dispose();
            conn.Dispose();

            return retval;
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
