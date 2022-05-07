using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class DisplayVideos
    {
        [Parameter]
        public List<string> Videos { get; set; } = new List<string>();
    }
}
