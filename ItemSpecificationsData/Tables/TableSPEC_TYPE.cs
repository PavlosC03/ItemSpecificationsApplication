using ItemSpecifications.Data.Records;
using Lib.Data.DB;
using System.Data;
using System.Diagnostics;

namespace ItemSpecifications.Data.Tables
{
    public class TableSPEC_TYPE : CDBTable<SPEC_TYPE>
    {
        public TableSPEC_TYPE()
        {
        }
        // --------------------------------------------------------------------------------------
        public override void LoadTable(IDbTransaction p_iTransaction)
        {
            var oRecords = CData.Instance.DB.Select<SPEC_TYPE>("select * from SPEC_TYPE");

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }
        // --------------------------------------------------------------------------------------
        // --------------------------------------------------------------------------------------
        public override void SaveTable(IDbTransaction p_iTransaction)
        {
            if (this.records != null)
            {
                CData.Instance.DB.SaveChanges<SPEC_TYPE>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into SPEC_TYPE
                                  (SPECIFICATION_NAME, UNIT_NAME)
                                  values
                                  (@SPECIFICATION_NAME, @UNIT_NAME)",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update SPEC_TYPE set
                                     SPECIFICATION_NAME = @SPECIFICATION_NAME
                                    ,UNIT_NAME = @UNIT_NAME
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from SPEC_TYPE where ID = @ID",

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
