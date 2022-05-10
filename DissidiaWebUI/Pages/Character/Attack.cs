using DissidiaWebUI.Models;
using DissidiaWebUI.Models.Enums;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class Attack
    {
        [Parameter]
        public AttackModel RenderAttack { get; set; } = new AttackModel();

        private List<PriorityType> priorityValues = new List<PriorityType>();

        public Attack()
        {
            priorityValues = Enum.GetValues(typeof(PriorityType)).Cast<PriorityType>().ToList();
        }

    }
}
