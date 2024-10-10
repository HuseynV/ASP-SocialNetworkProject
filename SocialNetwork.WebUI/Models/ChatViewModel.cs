using SocialNetwork.Entities.Entities;

namespace SocialNetwork.WebUI.Models
{
    public class ChatViewModel
    {
        public string? CurrentUserId { get; set; }
        public Chat? CurrentChat { get; set; }
        public IEnumerable<Chat>? Chats { get; set; }
        public string? CurrentReceiver { get; internal set; }
        public string? CurrentUserName {get;set; }
        public string? CurrentReceiverImage { get;  set; }
    }
}