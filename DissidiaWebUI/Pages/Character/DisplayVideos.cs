using Blazored.Modal;
using Blazored.Modal.Services;
using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class DisplayVideos
    {

        [CascadingParameter]
        public IModalService Modal { get; set; }

        [Parameter]
        public List<string> Videos { get; set; } = new List<string>();

        [Parameter]
        public bool IsAuthenticated { get; set; }

        async Task ShowAddVideoForm()
        {
            var videoModal = Modal.Show<VideoForm>("Add Video");
            var result = await videoModal.Result;

            if (result.Cancelled == false)
            {
                Videos.Add((string)result.Data);
            }
            StateHasChanged();
        }

        private async void HandleDropDownSelection(EventCallbackArgs<string> args)
        {
            if (args.Action == "Edit")
            {
                //Open Edit Form
                var parameters = new ModalParameters();
                parameters.Add("Video", args.Model);

                var videoModal = Modal.Show<VideoForm>("Edit Video", parameters);
                var result = await videoModal.Result;

                if (result.Cancelled == false)
                {
                    var index = Videos.IndexOf(args.Model);
                    Videos[index] = (string)result.Data;
                }
            }
            else
            {
                var parameters = new ModalParameters();
                parameters.Add("Text", "this video");

                var deleteDialog = Modal.Show<ModalDialog>("Delete Video", parameters);
                var result = await deleteDialog.Result;

                if (result.Cancelled == false)
                {
                    Videos.Remove(args.Model);
                }
            }

            StateHasChanged();
        }
    }
}
