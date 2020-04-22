using System.Collections.Generic;

namespace LittleBlazors.Components.Wizards
{
    internal class WizardStateManager : IWizardStateManager
    {
        private IDictionary<string, object> state = new Dictionary<string, object>();

        public bool TryGet(string key, out object result)
        {
            return this.state.TryGetValue(key, out result);
        }

        public void Set(string key, object value)
        {
            this.state[key] = value;
        }
    }
}
