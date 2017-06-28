﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSim.Model.Models
{
    [Table("FirstNumbers")]
    public class FirstNumber
    {
        [Key]
        public int ID { set; get; }

        [Required]
        public int NetworkID { set; get; }

        [ForeignKey("NetworkID")]
        public virtual MenuGroup MenuGroup { set; get; }

        [Required]
        public int Number { set; get; }
    }
}