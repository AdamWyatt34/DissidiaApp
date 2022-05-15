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
        private string edit = "Edit";
        private string delete = "Delete";

        public Attack()
        {
            priorityValues = Enum.GetValues(typeof(PriorityType)).Cast<PriorityType>().ToList();
        }

        public void HandleOnSelected(string selected)
        {
            Console.WriteLine(selected);
        }

    }
}
