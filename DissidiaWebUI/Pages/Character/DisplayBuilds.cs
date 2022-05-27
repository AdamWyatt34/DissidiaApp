using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class DisplayBuilds
    {
        [Parameter]
        public List<BuildModel> Builds { get; set; } = new List<BuildModel>();
        [Parameter]
        public bool IsAuthenticated { get; set; }
    }
}
