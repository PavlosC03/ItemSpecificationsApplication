namespace Lib.UX.DataForms.MasterForm
{
    public class CMasterFormState
    {
        protected CMasterFormContext context;

        // ........................................................................
        public string StateName { get { return GetType().Name; } }
        // ........................................................................

        // --------------------------------------------------------------------------------------
        public CMasterFormState(CMasterFormContext p_oContext)
        {
            context = p_oContext;
        }
        // --------------------------------------------------------------------------------------
    }
}
