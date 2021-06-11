using Microsoft.AspNetCore.Components;

namespace BugTrackerUI.Pages
{
    public partial class NewBug
    {
        public Bug AddBug => new Bug();

        [Inject]
        public IBugService BugService { get; set; }

        [Inject]
        public NavigationManager NavService { get; set; }

        protected void HandleValidSubmit()
        {
            BugService.AddBug(AddBug);
            NavService.NavigateTo("");
        }
    }
}
