using Oracle.DataAccess.Client;
using System.Collections.Generic;
using System.Data;

namespace ALOra
{
    interface IOraDB
    {
        /* Properties */
        string ConnectString { get; }
        Credentials Credentials { get; set; }
        List<OracleCommand> OraCommands { get; }
        OracleConnection OraConnection { get; }
        string SqlStmt { get; set; }

        /* Methods */
        void addCommand();
        void addCommand(string pStmt);
        void beginTrans();
        void breakRunning();
        void commitTrans(bool pPreserveStmts = false);
        void execCommands(bool pUseTransaction = true);
        int execStmt();
        int execStmt(string pStmt);
        void exportToExcel(DataTable pDataTbl);
        DataSet getDataSet(DataTable pDataTbl);
        string getHtml(DataTable pDataTbl);
        void rollbackTrans(bool pPreserveStmts = true);
        DataTable runQuery();
        DataTable runQuery(string pSql);
    }
}
