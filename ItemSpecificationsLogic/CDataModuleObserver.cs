using Lib.Common.Interfaces;

namespace ItemSpecifications.Logic;

public class CDataModuleObserver : List<IDataModule>
{
    #region // Singleton \\
    // ....................................................................
    private static CDataModuleObserver? __instance = null;
    public static CDataModuleObserver Instance
    {
        get
        {
            //PATTERN: Lazy initialization. The only instance is created at the first time that is needed.
            if (__instance == null)
                __instance = new CDataModuleObserver();
            return __instance;
        }
    }
    private CDataModuleObserver()
    {
    }
    // ....................................................................
    #endregion


    // --------------------------------------------------------------------------------
    public void Subscribe(IDataModule p_iModule)
    {
        // Add it only once.
        if (this.IndexOf(p_iModule) == -1)
            this.Add(p_iModule);
    }
    // --------------------------------------------------------------------------------
    public void UnSubscribe(IDataModule p_iModule)
    {
        // Remove it if it is subscribed.
        if (this.IndexOf(p_iModule) != -1)
            this.Remove(p_iModule);
    }
    // --------------------------------------------------------------------------------
    public void NotifyAllToReloadLookups()
    {
        foreach (IDataModule iModule in this)
            iModule.ModuleLoadLookups();
    }
    // --------------------------------------------------------------------------------


}
