﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TwilightTrip.DbModels.Npcs;

namespace TwilightTrip.DbModels.Senses
{
    public class Sense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public List<SenseLink> Links { get; set; }

        public List<Npc> Npcs { get; set; }
    }
}
