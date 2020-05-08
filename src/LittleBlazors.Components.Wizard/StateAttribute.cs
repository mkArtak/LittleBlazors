using System;

namespace LittleBlazors.Components.Wizards
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public sealed class StateAttribute : Attribute
    {
        /// <summary>
        /// Gets the key of the state value in the state dictionary.
        /// </summary>
        public string Key { get; }

        /// <summary>
        /// Indicates whether the property value should only be read from the underlying state store or also be written to.
        /// </summary>
        public bool ReadOnly { get; }

        /// <summary>
        /// The key will match the property name this attribute is applied to.
        /// </summary>
        public StateAttribute()
        {
        }

        public StateAttribute(string key) : this(key, false)
        {
        }

        public StateAttribute(string key, bool readOnly)
        {
            this.Key = key;
            this.ReadOnly = readOnly;
        }
    }
}
