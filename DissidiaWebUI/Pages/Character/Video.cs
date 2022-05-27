using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class Video
    {
        [Parameter]
        public string RenderVideo { get; set; }
        [Parameter]
        public bool RenderDropdownButton { get; set; } = true;

        [Parameter]
        public EventCallback<EventCallbackArgs<string>> HandleDropdownButtonSelect { get; set; }
        
        [Parameter]
        public bool IsAuthenticated { get; set; }

        private string edit = "Edit";
        private string delete = "Delete";

        public void HandleOnSelected(string selected)
        {
            EventCallbackArgs<string> args = new EventCallbackArgs<string>()
            {
                Action = selected,
                Model = RenderVideo
            };
            HandleDropdownButtonSelect.InvokeAsync(args);
        }
    }
}
