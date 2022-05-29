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

        [Parameter]
        public EventCallback<EventCallbackArgs<BuildModel>> HandleDropdownButtonSelect { get; set; }

        [Parameter]
        public bool RenderDropdownButton { get; set; } = true;


        private string edit = "Edit";
        private string delete = "Delete";
        public void HandleOnSelected(string selected)
        {
            EventCallbackArgs<BuildModel> args = new EventCallbackArgs<BuildModel>()
            {
                Action = selected,
                Model = RenderBuild
            };
            HandleDropdownButtonSelect.InvokeAsync(args);
        }
    }
}
