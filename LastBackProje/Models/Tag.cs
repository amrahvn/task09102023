﻿using System.ComponentModel.DataAnnotations;

namespace LastBackProje.Models
{
    public class Tag:BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
