﻿using Lib.Common.Interfaces;
using System.Collections;
using System.Data;

namespace Lib.Data.DB
{
    public class CDBTable<T> : IDBTable
    {

        // ....................................................................
        protected List<T> records = new List<T>();
        public List<T> Records { get { return records; } }
        public IList RecordSet { get { return records; } }
        // ....................................................................
        public string TableName { get; set; } = string.Empty;
        // ....................................................................



        // --------------------------------------------------------------------------------------
        public CDBTable()
        {
        }
        // --------------------------------------------------------------------------------------
        public CDBTable(string p_sTableName)
        {
            TableName = p_sTableName;
        }
        // --------------------------------------------------------------------------------------
        public virtual void LoadRecord(int p_nKeyValue)
        {
            throw new NotSupportedException();
        }
        // --------------------------------------------------------------------------------------
        public virtual void LoadTable(IDbTransaction? p_iTransaction, int p_nMasterKeyValue) { throw new NotSupportedException(); }
        // --------------------------------------------------------------------------------------
        public virtual void LoadTable(IDbTransaction? p_iTransaction) { throw new NotSupportedException(); }
        // --------------------------------------------------------------------------------------
        public virtual void SaveTable(IDbTransaction? p_iTransaction) { throw new NotSupportedException(); }
        // --------------------------------------------------------------------------------------
    }
}
