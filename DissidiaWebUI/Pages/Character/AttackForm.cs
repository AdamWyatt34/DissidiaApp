using Blazored.Modal;
using Blazored.Modal.Services;
using DissidiaWebUI.Models;
using DissidiaWebUI.Models.Enums;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class AttackForm
    {
        [CascadingParameter] 
        BlazoredModalInstance _blazoredModalInstance { get; set; }

        [Parameter]
        public AttackModel? _currentAttack { get; set; }

        private AttackModel? _currentAttackModel = new AttackModel();
        private List<AttackType> _attackTypes = new List<AttackType>();
        private List<PriorityType> _priorityTypes = new List<PriorityType>();
        protected override void OnInitialized()
        {
            if (_currentAttack != null)
            {
                _currentAttackModel = _currentAttack;
            }
            _attackTypes = Enum.GetValues(typeof(AttackType)).Cast<AttackType>().ToList();
            _priorityTypes = Enum.GetValues(typeof(PriorityType)).Cast<PriorityType>().ToList();
        }

        public void SaveAttack()
        {
            _blazoredModalInstance.CloseAsync(ModalResult.Ok(_currentAttackModel));
        }

        private void HandleAttackTypeChange(ChangeEventArgs e)
        {
            var newType = AttackType.Bravery;
            Enum.TryParse<AttackType>(e.Value.ToString(), out newType);
            _currentAttackModel.Type = newType;
        }

        private void HandlePriorityTypeChange(ChangeEventArgs e)
        {
            var newPriority = PriorityType.High;
            Enum.TryParse<PriorityType>(e.Value.ToString(), out newPriority);
            _currentAttackModel.Priority = newPriority;
        }
    }
}
