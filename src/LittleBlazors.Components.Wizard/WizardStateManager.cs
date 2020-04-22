using System;
using System.Collections.Generic;
using System.Text;

namespace LittleBlazors.Components.Wizards
{
    public class WizardStateManager
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
