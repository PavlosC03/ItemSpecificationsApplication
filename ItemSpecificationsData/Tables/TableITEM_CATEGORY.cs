using ItemSpecifications.Data;
using ItemSpecifications.Data.Records;
using Lib.Data.DB;
using System.Data;
using System.Diagnostics;

public class TableITEM_CATEGORY : CDBTable<ITEM_CATEGORY>
{
    // --------------------------------------------------------------------------------------
    public TableITEM_CATEGORY() { }
    // --------------------------------------------------------------------------------------

    public override void LoadRecord(int p_nKeyValue)
    {
        this.records.Clear(); // Empty the existing records

        // Create an object to hold the ID parameter for the select statement
        ITEM_CATEGORY oParams = new ITEM_CATEGORY();
        oParams.CID = p_nKeyValue;

        using (var iTransaction = CData.Instance.DB.BeginTransaction())
        {
            try
            {
                var oRecords = CData.Instance.DB.SelectWithParams<ITEM_CATEGORY>(
                        "select * from ITEM_CATEGORY where ID = @ID", oParams, iTransaction);
                iTransaction.Commit();

                // When no records are returned, oRecords will be null
                if (oRecords != null)
                {
                    this.records = oRecords;
                    foreach (var oRecord in this.records)
                    {
                        Debug.WriteLine($"Loaded record: {oRecord.ToString()}");
                    }
                }
                else
                {
                    Debug.WriteLine("No records returned.");
                }
            }
            catch (Exception ex)
            {
                iTransaction.Rollback();
                Debug.WriteLine($"Error loading record: {ex.Message}");
                throw;
            }
        }
    }

    // --------------------------------------------------------------------------------------
    public override void LoadTable(IDbTransaction? p_iTransaction)
    {
        this.records.Clear(); // Empty the existing records

        var oRecords = CData.Instance.DB.Select<ITEM_CATEGORY>("select * from ITEM_CATEGORY", p_iTransaction);

        // When no records are returned, oRecords will be null
        if (oRecords != null)
        {
            this.records = oRecords;
            foreach (var oRecord in this.records)
            {
                Debug.WriteLine($"Loaded record: {oRecord.ToString()}");
            }
        }
        else
        {
            Debug.WriteLine("No records returned.");
        }
    }
    // --------------------------------------------------------------------------------------
    public override void SaveTable(IDbTransaction? p_iTransaction)
    {
        if (this.records != null)
        {
            CData.Instance.DB.SaveChanges<ITEM_CATEGORY>(this.records,

                        @"INSERT INTO ITEM_CATEGORY (CATEGORY_NAME, PARENT_CATEGORY_CID) VALUES (@CATEGORY_NAME, @PARENT_CATEGORY_CID)",

                        @"UPDATE ITEM_CATEGORY SET CATEGORY_NAME = @CATEGORY_NAME, PARENT_CATEGORY_CID = @PARENT_CATEGORY_CID WHERE ID = @ID",

                        @"DELETE FROM ITEM_CATEGORY WHERE ID = @ID",

                        p_iTransaction
                    );

            // Reload table to reflect changes
            this.LoadTable(p_iTransaction);
        }
    }
    // --------------------------------------------------------------------------------------
}
