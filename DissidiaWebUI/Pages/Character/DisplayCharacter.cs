using Microsoft.AspNetCore.Components;

namespace DissidiaWebUI.Pages.Character
{

    public partial class DisplayCharacter
    {
        [Inject]
        private IHttpClientFactory? _httpClientFactory { get; set; }
        private string? _errorString;
    }
}
