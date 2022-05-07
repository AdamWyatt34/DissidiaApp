using DissidiaWebUI.Data;
using DissidiaWebUI.Models;
using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{
    public partial class CharacterSelector
    {
        [Parameter]
        public string CharacterId { get; set; }
        private Dictionary<Guid, string> _charactersDictionary = new Dictionary<Guid, string>();
        [Inject]
        
        private IHttpClientFactory? _httpClientFactory { get; set; }

        [Inject]
        ICharacterService? _characterService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            var client = _httpClientFactory.CreateClient();

            var fullCharacters = await client.GetFromJsonAsync<List<CharacterModel>>("https://localhost:7172/api/character");

            _charactersDictionary = fullCharacters.ToDictionary(x => x.Id, x => x.Name);

            await base.OnInitializedAsync();
        }

        private void SendNewCharacter(ChangeEventArgs e)
        {
            _characterService.SendNewCharacter(e.Value.ToString());
        }
    }
}
