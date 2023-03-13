﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Infrastructure.DTO
{
    public class TicketDto
    {
        public Guid Id { get; set; }
        public int Seating { get; set; }
        public decimal Price { get; set; }
        public Guid? UserId { get; set; }
        public string Username { get; set; }
        public DateTime PurchasedAt { get; set; }
        public bool IsPucrhased { get; set; }
    }
}
