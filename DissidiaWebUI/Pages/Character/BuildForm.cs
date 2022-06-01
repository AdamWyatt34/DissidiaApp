using Blazored.Modal;
using Blazored.Modal.Services;
using DissidiaWebUI.Data;
using DissidiaWebUI.Models;
using DissidiaWebUI.Options;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.Extensions.Options;

namespace DissidiaWebUI.Pages.Character
{
    public partial class BuildForm
    {
        [CascadingParameter]
        BlazoredModalInstance _blazoredModalInstance { get; set; }

        [Parameter]
        public BuildModel? _currentBuild { get; set; } = new BuildModel();

        [Inject]
        IOptions<AzureStorageSettings> _options { get; set; }

        private BuildModel? _currentBuildModel = new BuildModel();
        private BlobUtility _blobUtility;
        private IBrowserFile selectedFile;

        protected override void OnInitialized()
        {
            if (_currentBuild != null)
            {
                _currentBuildModel = _currentBuild;
            }
            _blobUtility = new BlobUtility(_options.Value.ConnectionString);
        }
        public async Task SaveBuild()
        {
            _currentBuildModel.ImagePath = await _blobUtility.UploadBlob(_options.Value.FullImagesContainerNameOption, selectedFile, _options.Value.StorageAccountNameOption, _options.Value.StorageAccountKeyOption);
            //Check if build passed in has image, if it does then delete it.
            if (_currentBuild.ImagePath != _currentBuildModel.ImagePath)
            {
                await _blobUtility.DeleteBlob(_options.Value.FullImagesContainerNameOption, _currentBuild.ImagePath);
            }
            _blazoredModalInstance.CloseAsync(ModalResult.Ok(_currentBuildModel));
        }

        private void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFile = e.File;
            this.StateHasChanged();
        }
    }
}
