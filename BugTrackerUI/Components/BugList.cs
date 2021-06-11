using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace BugTrackerUI.Components
{
    public partial class BugList
    {
        [Inject]
        public IBugService BugService { get; set; }

        public List<Bug> Bugs { get; set; }

        protected override void  OnInitialized()
        {
            Bugs = BugService.GetBugs().OrderBy(x => x.Priority).ToList();
        }
    }
}
