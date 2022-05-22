namespace DissidiaWebUI.Models
{
    public class EventCallbackArgs<T>
    {
        public string Action { get; set; }
        public T Model { get; set; }
    }
}
