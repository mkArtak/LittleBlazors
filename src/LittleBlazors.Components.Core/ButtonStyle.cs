namespace LittleBlazors.Components.Core
{
    /// <summary>
    /// Specifies styles applicable to a button.
    /// </summary>
    public readonly struct ButtonStyle
    {
        /// <summary>
        /// Specifies the text of the button.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Specifies the CSS class name to apply to the button, when rendered.
        /// </summary>
        public string CssClassName { get; }

        /// <summary>
        /// Specifies, whether the button this style applies to should be rendered or not.
        /// </summary>
        /// <remarks>The default value is `true`.</remarks>
        public bool Visible { get; }

        /// <summary>
        /// Initializes a new instance of a ButtonStyle with default visibility value of `true`
        /// </summary>
        /// <param name="title">The title of the button</param>
        /// <param name="cssClassName">The CSS class name to be applied to the button which this style is applied to</param>
        public ButtonStyle(string title, string cssClassName) : this(title, cssClassName, true)
        {

        }

        /// <summary>
        /// Initializes a new instance of a ButtonStyle
        /// </summary>
        /// <param name="title">The title of the button</param>
        /// <param name="cssClassname">The CSS class name to be applied to the button which this style is applied to</param>
        /// <param name="visible">Indicates whether the button should be visible or not</param>
        public ButtonStyle(string title, string cssClassname, bool visible)
        {
            this.Title = title;
            this.CssClassName = cssClassname;
            this.Visible = visible;
        }
    }
}
