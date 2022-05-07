using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{

    public partial class DisplayCharacter
    {
        [Parameter]
        public string CharacterId { get; set; }
        [Inject]
        private IHttpClientFactory? _httpClientFactory { get; set; }
        private CharacterModel _characterModel { get; set; }
        private string? _errorString;

        protected override async Task OnInitializedAsync()
        {
            var client = _httpClientFactory.CreateClient();

            try
            {
                _characterModel = await client.GetFromJsonAsync<CharacterModel>($"https://localhost7172/api/character/{CharacterId}");
            }
            catch (Exception ex)
            {
                _errorString = ex.Message;
            }

            //return base.OnInitializedAsync();
        }
    }
}
