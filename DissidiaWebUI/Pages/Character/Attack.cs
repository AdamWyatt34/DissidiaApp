using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class Attack
    {
        [Parameter]
        public AttackModel RenderAttack { get; set; } = new AttackModel();

    }
}
