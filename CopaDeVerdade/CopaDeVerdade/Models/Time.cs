﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CopaDeVerdade.Models
{
    public class Time
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}