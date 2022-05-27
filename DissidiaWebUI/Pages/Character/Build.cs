using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class Build
    {
        [Parameter]
        public BuildModel RenderBuild { get; set; } = new BuildModel();
        [Parameter]
        public bool IsAuthenticated { get; set; }
        private string edit = "Edit";
        private string delete = "Delete";
        public void HandleOnSelected(string selected)
        {
            Console.WriteLine(selected);
        }
    }
}
