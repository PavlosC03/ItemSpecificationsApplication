namespace Lib.Logic
{
    public interface IMasterDetailModel
    {
        public IEntity NewMasterDetail();
        public void LoadMasterDetail(int p_nMasterKeyValue);
        public int SaveMasterDetail();
        public void DeleteMasterDetail();
    }
}
