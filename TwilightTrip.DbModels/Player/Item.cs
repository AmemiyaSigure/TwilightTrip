﻿using System.ComponentModel.DataAnnotations;

namespace TwilightTrip.DbModels.Player
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool Wearable { get; set; }

        [Required]
        public bool Tradable { get; set; }

        [Required]
        public bool Usable { get; set; }

        [Required]
        public bool Reusable { get; set; }

        [Required]
        public decimal Worth { get; set; }
    }
}
