using Blazored.Modal;
using Blazored.Modal.Services;
using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class DisplayAttacks
    {
        [CascadingParameter]
        public IModalService Modal { get; set; }
        [Parameter]
        public List<AttackModel> Attacks { get; set; } = new List<AttackModel>();
        private List<AttackModel> _bravery = new List<AttackModel>();
        private List<AttackModel> _hps = new List<AttackModel>();

        protected override void OnParametersSet()
        {
            base.OnParametersSet();
            RenderAttackTypes();
        }

        private void RenderAttackTypes()
        {
            _bravery = Attacks.Where(a => a.Type == Models.Enums.AttackType.Bravery).ToList();
            _hps = Attacks.Where(a => a.Type == Models.Enums.AttackType.HP).ToList();
        }

        async Task ShowAddAttackForm()
        {
            var attackModal = Modal.Show<AttackForm>("Add Attack");
            var result = await attackModal.Result;

            if (result.Cancelled == false)
            {
                Attacks.Add((AttackModel)result.Data);
            }

            StateHasChanged();
            RenderAttackTypes();
        }

        private async void HandleDropDownSelection(EventCallbackArgs<AttackModel> args)
        {
            if (args.Action == "Edit")
            {
                //Open Edit Form
                var parameters = new ModalParameters();
                parameters.Add("_currentAttack", args.Model);

                var attackModal = Modal.Show<AttackForm>("Edit Attack", parameters);
                var result = await attackModal.Result;

                if (result.Cancelled == false)
                {
                    var index = Attacks.IndexOf(args.Model);
                    Attacks[index] = (AttackModel)result.Data;
                }
            }
            else
            {
                var parameters = new ModalParameters();
                parameters.Add("Text", args.Model.Name);

                var deleteDialog = Modal.Show<ModalDialog>("Delete Attack", parameters);
                var result = await deleteDialog.Result;

                if (result.Cancelled == false)
                {
                    Attacks.Remove(args.Model);
                }
            }

            StateHasChanged();
            RenderAttackTypes();
        }
    }
}
