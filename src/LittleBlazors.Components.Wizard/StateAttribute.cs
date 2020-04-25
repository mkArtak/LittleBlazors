using System;

namespace LittleBlazors.Components.Wizards
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class StateAttribute : Attribute
    {
        public string Key { get; }

        /// <summary>
        /// The key will match the property name this attribute is applied to.
        /// </summary>
        public StateAttribute()
        {
        }

        public StateAttribute(string key)
        {
            this.Key = key;
        }
    }
}
