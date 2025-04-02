namespace HelpMeAPI.DTos
{
    public class TicketDto
    {
    
        public string Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool TicketOpen = true;

    }
}
