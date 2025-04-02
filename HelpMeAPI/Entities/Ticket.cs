using System;
using System.Collections.Generic;

namespace HelpMeAPI.Entities;

public partial class Ticket
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Body { get; set; } = null!;

    public bool? TicketOpen { get; set; }

    public string? ResolvedBy { get; set; }
}
