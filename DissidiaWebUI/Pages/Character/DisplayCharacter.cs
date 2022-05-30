using DissidiaWebUI.Data;
using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{

    public partial class DisplayCharacter
    {
        [Parameter]
        public string? CharacterId { get; set; }
        private string currentId;
        [Inject]
        private IHttpClientFactory? _httpClientFactory { get; set; }
        [Inject]
        ICharacterService? _characterService { get; set; }
        private CharacterModel _characterModel = new CharacterModel();
        private string? _errorString = string.Empty;
        private bool _isAuthenticated;

        protected override async Task OnInitializedAsync()
        {
            _characterService.OnCharacterSelect += CharacterSelectHandler;
            var client = _httpClientFactory.CreateClient();

            if (CharacterId != null)
            {
                currentId = CharacterId;

                try
                {
#pragma warning disable CS8601 // Possible null reference assignment.
                    _characterModel = await client.GetFromJsonAsync<CharacterModel>($"{config.GetValue<string>("APIUrl")}/{currentId}");
#pragma warning restore CS8601 // Possible null reference assignment.
                }
                catch (Exception ex)
                {
                    _errorString = ex.Message;
                }
            }

            var authState = await authenticationState.GetAuthenticationStateAsync();
            var user = authState.User;

            _isAuthenticated = user.Identity.IsAuthenticated;
        }

        public void Dispose()
        {
            _characterService.OnCharacterSelect -= CharacterSelectHandler;
        }

        private async void CharacterSelectHandler(string newId)
        {
            if (string.IsNullOrEmpty(newId))
            {
                throw new Exception("ID cannot be null");
            }

            currentId = newId;
            var client = _httpClientFactory.CreateClient();
            try
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                _characterModel = await client.GetFromJsonAsync<CharacterModel>($"{config.GetValue<string>("APIUrl")}/{currentId}");
#pragma warning restore CS8601 // Possible null reference assignment.
                StateHasChanged();
            }
            catch (Exception ex)
            {
                _errorString = ex.Message;
            }
        }

        private async Task SaveCharacter()
        {
            var client = _httpClientFactory.CreateClient();
            await client.PutAsJsonAsync<CharacterModel>($"{config.GetValue<string>("APIUrl")}/edit", _characterModel);
        }
    }
}
