using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class Build
    {
        [Parameter]
        public BuildModel RenderBuild { get; set; } = new BuildModel();
    }
}
