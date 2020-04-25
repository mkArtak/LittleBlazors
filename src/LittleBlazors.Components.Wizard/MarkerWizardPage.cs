using System.Threading.Tasks;

namespace LittleBlazors.Components.Wizards
{
    internal class MarkerWizardPage : WizardPage
    {
        protected override async Task OnInitializedAsync()
        {
            base.OnInitialized();

            await this.Wizard.AllPagesLoaded();
        }
    }
}