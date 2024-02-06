using System;
using System.Collections.Generic;

namespace WebAppEFDbAs5.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
        public int? JerseyNumber { get; set; }
        public int? Position { get; set; }
        public string Team { get; set; } = null!;
    }
}
