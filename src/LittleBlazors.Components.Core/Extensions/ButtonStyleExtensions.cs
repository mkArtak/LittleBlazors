namespace LittleBlazors.Components.Core.Extensions
{
    public static class ButtonStyleExtensions
    {
        /// <summary>
        /// Creates a new ButtonStyle instance with the specified title, while keeping the rest of the properties the same as the current style
        /// </summary>
        /// <param name="style">The style to use as a base</param>
        /// <param name="title">The new title</param>
        /// <returns>A new ButtonStyle instance with requested values</returns>
        public static ButtonStyle Title(this ButtonStyle style, string title)
        {
            return new ButtonStyle(title, style.CssClassName, style.Visible);
        }

        /// <summary>
        /// Creates a new ButtonStyle instance with the specified CSS class name value, while keeping the rest of the properties the same as the current style
        /// </summary>
        /// <param name="style">The style to use as a base</param>
        /// <param name="cssClass">The new CSS class name</param>
        /// <returns>A new ButtonStyle instance with requested values</returns>
        public static ButtonStyle CssClassName(this ButtonStyle style, string cssClass)
        {
            return new ButtonStyle(style.Title, cssClass, style.Visible);
        }

        /// <summary>
        /// Creates a new ButtonStyle instance with the specified visibility value, while keeping the rest of the properties the same as the current style
        /// </summary>
        /// <param name="style">The style to use as a base</param>
        /// <param name="visible">The new visibility value</param>
        /// <returns>A new ButtonStyle instance with requested values</returns>
        public static ButtonStyle Visible(this ButtonStyle style, bool visible)
        {
            return new ButtonStyle(style.Title, style.CssClassName, visible);
        }
    }
}
