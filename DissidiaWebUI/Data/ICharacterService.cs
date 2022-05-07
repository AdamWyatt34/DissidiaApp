
namespace DissidiaWebUI.Data
{
    public interface ICharacterService
    {
        event Action<string> OnCharacterSelect;

        void SendNewCharacter(string newId);
    }
}