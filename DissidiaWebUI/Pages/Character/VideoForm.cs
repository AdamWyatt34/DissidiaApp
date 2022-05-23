using Blazored.Modal;
using Blazored.Modal.Services;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class VideoForm
    {
        [CascadingParameter]
        BlazoredModalInstance _blazoredModalInstance { get; set; }
        [Parameter]
        public string Video { get; set; }
        private string _currentVideo = String.Empty;

        protected override void OnInitialized()
        {
            if (string.IsNullOrEmpty(Video) == false)
            {
                _currentVideo = Video;
            }
        }

        public void SaveVideo()
        {
            _blazoredModalInstance.CloseAsync(ModalResult.Ok(_currentVideo));
        }



    }
}
