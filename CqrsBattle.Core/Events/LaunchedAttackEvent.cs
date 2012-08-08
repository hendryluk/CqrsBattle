using System;
using CqrsBattle.Core.Models;

namespace CqrsBattle.Core.Events
{
    public class LaunchedAttackEvent
    {
        public Guid ShipId { get; set; }
        public Coordinate Target { get; set; }
    }
}