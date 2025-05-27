using ItemSpecifications.Data.Tables;
using Lib.Common.Interfaces;

namespace ItemSpecifications.Logic
{
    public class CDBTableFactory
    {
        #region // Singleton \\
        // ....................................................................
        private static CDBTableFactory? __instance = null;
        public static CDBTableFactory Instance
        {
            get
            {
                //PATTERN: Lazy initialization. The only instance is created at the first time that is needed.
                if (__instance == null)
                    __instance = new CDBTableFactory();
                return __instance;
            }
        }
        private CDBTableFactory()
        {
        }
        // ....................................................................
        #endregion

        // --------------------------------------------------------------------------------------
        // [PATTERNS] Factory Method
        public IDBTable CreateTable(string p_sTableName)
        {
            // [C# ADVANCED] We cast the type to Object and then convert to the base class CDBRecord for the T in the generic class CDBTable
            if (p_sTableName == "ITEM")
                return new TableITEM();
            else if (p_sTableName == "ITEM_CATEGORY")
                return new TableITEM_CATEGORY();
            else if (p_sTableName == "ITEM_SPEC")
                return new TableITEM_SPEC();
            else if (p_sTableName == "MEASUREMENT_UNIT")
                return new TableMEASUREMENT_UNIT();
            else if (p_sTableName == "SPEC_TYPE")
                return new TableSPEC_TYPE();
            else
                return null;
        }
        // --------------------------------------------------------------------------------------
    }

}
