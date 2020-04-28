namespace LittleBlazors.Components.Wizards
{
    /// <summary>
    /// Represents a contract for simple state management.
    /// </summary>
    public interface IWizardStateManager
    {
        /// <summary>
        /// Stores the given value in the underlying state container
        /// </summary>
        /// <param name="key">The key to be used for later retrieval of the state</param>
        /// <param name="value">The state value to store</param>
        void Set(string key, object value);

        /// <summary>
        /// Attempts to retrieve a value from the underlying state container, stored with the specified key
        /// </summary>
        /// <param name="key">The key to retrieve the state for</param>
        /// <param name="result">The state value if such exists</param>
        /// <returns>true, if a state value exists with the given key. false - otherwise</returns>
        bool TryGet(string key, out object result);

        /// <summary>
        /// Clears the state value with the given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns>true, if the key was found and removed. false - otherwise</returns>
        bool Remove(string key);
    }
}