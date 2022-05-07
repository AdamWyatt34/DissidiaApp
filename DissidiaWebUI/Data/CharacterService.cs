namespace DissidiaWebUI.Data
{
    public class CharacterService : ICharacterService
    {
        public event Action<string> OnCharacterSelect;

        public void SendNewCharacter(string newId)
        {
            OnCharacterSelect.Invoke(newId);
        }
    }
}
