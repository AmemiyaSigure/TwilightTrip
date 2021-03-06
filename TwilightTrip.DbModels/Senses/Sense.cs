﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TwilightTrip.DbModels.Senses
{
    public class Sense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        public List<SenseLink> OutcomeLink { get; set; }
        
        public List<SenseLink> IncomeLink { get; set; }
    }
}