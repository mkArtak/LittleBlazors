using System.Threading.Tasks;

namespace LittleBlazors.Components.Wizards
{
    /// TODO: This component should be internal.
    /// Due to https://github.com/dotnet/aspnetcore/issues/21213 bug, this is temporarily marked as `public`.
    public class MarkerWizardPage : WizardPage
    {
        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();

            await this.Wizard.AllPagesLoaded();
        }
    }
}