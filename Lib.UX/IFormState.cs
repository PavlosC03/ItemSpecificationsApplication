namespace Lib.UX
{
    public interface IFormState
    {
        public void PerformAction(String p_sAction);
        public IFormState NextState();

    }
}
