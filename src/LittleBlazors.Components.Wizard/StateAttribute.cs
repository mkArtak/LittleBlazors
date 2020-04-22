using System;

namespace LittleBlazors.Components.Wizards
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class StateAttribute : Attribute
    {
        public string Key { get; }

        // This is a positional argument
        public StateAttribute(string key)
        {
            this.Key = key;
        }
    }
}
