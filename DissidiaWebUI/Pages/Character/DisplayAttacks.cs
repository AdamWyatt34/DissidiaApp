using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class DisplayAttacks
    {
        [Parameter]
        public List<AttackModel> Attacks { get; set; } = new List<AttackModel>();
        private List<AttackModel> _bravery = new List<AttackModel>();
        private List<AttackModel> _hps = new List<AttackModel>();

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            _bravery = Attacks.Where(a => a.Type == Models.Enums.AttackType.Bravery).ToList();
            _hps = Attacks.Where(a => a.Type == Models.Enums.AttackType.HP).ToList();
        }
    }
}
