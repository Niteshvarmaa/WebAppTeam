using System;
using System.Collections.Generic;

namespace WebAppTeam.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Postion { get; set; }
        public string? Team { get; set; }
        public double? JerseyNo { get; set; }
    }
}
