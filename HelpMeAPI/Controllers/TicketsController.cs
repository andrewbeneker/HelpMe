﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HelpMeAPI.Entities;
using HelpMeAPI.DTos;

namespace HelpMeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly HelpMeDbContext _context;

        public TicketsController(HelpMeDbContext context)
        {
            _context = context;
        }

        // GET: api/Tickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ticket>>> GetTickets()
        {
            List<Ticket> tickets = await _context.Tickets.ToListAsync();
            return Ok(tickets);
        }

        // GET: api/Tickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> GetTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        // PUT: api/Tickets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id)
        {
            
                var ticketEntity = _context.Tickets.Where(t => t.Id == id).FirstOrDefault();
               
                ticketEntity.TicketOpen = false;
                
                return Ok($"This ticket was resolved");
                await _context.SaveChangesAsync();
            
        }

        // POST: api/Tickets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ticket>> PostTicket(TicketDto ticketDto)
        {

            var ticketEntity = new Ticket()
            {
                Name = ticketDto.Name,
                Email = ticketDto.Email,
                Title = ticketDto.Title,
                Body = ticketDto.Body,
                TicketOpen = true,
            };

            _context.Tickets.Add(ticketEntity);
            await _context.SaveChangesAsync();

            return Ok("New Ticket Created");
        }

        // DELETE: api/Tickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TicketExists(int id)
        {
            return _context.Tickets.Any(e => e.Id == id);
        }
    }
}
