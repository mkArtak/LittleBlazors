namespace LittleBlazors.Components.Wizards
{
    public interface IWizardStateManager
    {
        void Set(string key, object value);

        bool TryGet(string key, out object result);
    }
}