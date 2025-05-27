using ItemSpecifications.Logic.Visitors;

namespace ItemSpecifications.Logic
{
    // After developing two different modules we realized that some members are common between the two classes.
    //
    // At this iteration of development we have moved the common code for the operation of data module,
    // to a new ancestor class and made the existing classes inherit from CDataModule

    public class CDataModule
    {
        //[C#]: Using class (static) fields to keep a global variable on the class, visible by all objects.
        private static int _nextModuleID = 1;

        // ....................................................................
        private int _moduleID;
        public int ModuleID { get { return _moduleID; } }
        // ....................................................................
        public string LastError { get; set; }
        // ....................................................................
        public bool IsLoaded { get; set; }
        // ....................................................................
        protected Object model = null;
        // ....................................................................
        protected CVisitorEntityLoader entityLoader;
        protected CVisitorRecordAdder recordAdder;
        // ....................................................................

        // --------------------------------------------------------------------------------------
        public CDataModule()
        {
            //TECHNIQUE: Having an auto-increment ID for each new object instance.
            _moduleID = _nextModuleID;
            _nextModuleID++;

            LastError = "";
            IsLoaded = false;
            this.entityLoader = new CVisitorEntityLoader();
            this.recordAdder = new CVisitorRecordAdder();
        }
        // --------------------------------------------------------------------------------------

    }
}
