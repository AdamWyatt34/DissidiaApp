using Blazored.Modal;
using Blazored.Modal.Services;
using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class DisplayBuilds
    {
        [CascadingParameter]
        public IModalService Modal { get; set; }
        [Parameter]
        public List<BuildModel> Builds { get; set; } = new List<BuildModel>();
        [Parameter]
        public bool IsAuthenticated { get; set; }

        private async void HandleDropDownSelection(EventCallbackArgs<BuildModel> args)
        {
            if (args.Action == "Edit")
            {
                //Open Edit Form
                var parameters = new ModalParameters();
                parameters.Add("_currentBuild", args.Model);

                var buildModal = Modal.Show<BuildForm>("Edit Build", parameters);
                var result = await buildModal.Result;

                if (result.Cancelled == false)
                {
                    var index = Builds.IndexOf(args.Model);
                    Builds[index] = (BuildModel)result.Data;
                }
            }
            else
            {
                var parameters = new ModalParameters();
                parameters.Add("Text", args.Model.Description);

                var deleteDialog = Modal.Show<ModalDialog>("Delete Build", parameters);
                var result = await deleteDialog.Result;

                if (result.Cancelled == false)
                {
                    Builds.Remove(args.Model);
                }
            }

            StateHasChanged();
        }

        async Task ShowAddBuildForm()
        {
            var buildModal = Modal.Show<BuildForm>("Add Build");
            var result = await buildModal.Result;

            if (result.Cancelled == false)
            {
                Builds.Add((BuildModel)result.Data);
            }

            StateHasChanged();
        }

    }
}
