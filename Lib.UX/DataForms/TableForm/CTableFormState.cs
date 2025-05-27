namespace Lib.UX.DataForms.TableForm
{
    public class CTableFormState
    {
        protected CTableFormContext context;

        // ........................................................................
        public string StateName { get { return GetType().Name; } }
        // ........................................................................

        // --------------------------------------------------------------------------------------
        public CTableFormState(CTableFormContext p_oContext)
        {
            context = p_oContext;
        }
        // --------------------------------------------------------------------------------------
    }
}
