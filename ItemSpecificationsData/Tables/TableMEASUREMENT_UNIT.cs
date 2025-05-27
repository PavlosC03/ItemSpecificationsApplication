using ItemSpecifications.Data.Records;
using Lib.Data.DB;
using System.Data;
using System.Diagnostics;

namespace ItemSpecifications.Data.Tables
{
    public class TableMEASUREMENT_UNIT : CDBTable<MEASUREMENT_UNIT>
    {
        // --------------------------------------------------------------------------------------
        public TableMEASUREMENT_UNIT()
        {
        }
        // --------------------------------------------------------------------------------------

        public override void LoadRecord(int p_nKeyValue)
        {
            this.records.Clear(); // Empty the existing records

            // We create an object to hold the ID parameter for the select statement
            ITEM? oParams = new ITEM();
            oParams.ID = p_nKeyValue;


            using (var iTransaction = CData.Instance.DB.BeginTransaction())
            {
                try
                {
                    var oRecords = CData.Instance.DB.SelectWithParams<MEASUREMENT_UNIT>(
                            "select * from MEASUREMENT_UNIT where ID = @ID", oParams, iTransaction);
                    iTransaction.Commit();

                    // When a select returns no records a null object might be returned by the method
                    if (oRecords != null)
                    {
                        this.records = oRecords;

                        foreach (var oRecord in this.records)
                            Debug.WriteLine(oRecord.ToString());
                    }
                }
                catch
                {
                    iTransaction.Rollback();
                    throw;
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            this.records.Clear(); // Empty the existing records

            var oRecords = CData.Instance.DB.Select<MEASUREMENT_UNIT>("select * from MEASUREMENT_UNIT", p_iTransaction);

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }
        // --------------------------------------------------------------------------------------
        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                CData.Instance.DB.SaveChanges<MEASUREMENT_UNIT>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"INSERT INTO MEASUREMENT_UNIT
                            (UNIT_NAME)
                            VALUES
                            (@UNIT_NAME)",

                             // Provide the update statement that will be used for updated records
                             @"UPDATE MEASUREMENT_UNIT SET                          
                            UNIT_NAME = @UNIT_NAME,                        
                            WHERE ID = @ID",

                            // Provide the delete statement that will be used for deleted records
                            @"delete from MEASUREMENT_UNIT where ID = @ID",

                            p_iTransaction
                        );

                // We reload the table to reflect all the changes that have been saved in the DB
                // With this we secure that fields altered by DB triggers are properly loaded
                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
