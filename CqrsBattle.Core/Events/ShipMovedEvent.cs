using System;
using CqrsBattle.Core.Models;

namespace CqrsBattle.Core.Events
{
    public class ShipMovedEvent
    {
        public Guid ShipId { get; set; }
        public Coordinate Destination { get; set; }
    }
}