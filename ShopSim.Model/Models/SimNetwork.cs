using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopSim.Model.Models
{
    [Table("SimNetworks")]
    public class SimNetwork
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        [MaxLength(255)]
        [Column(TypeName = "varchar")]
        public string Alias { set; get; }

        public string Image { set; get; }

        public string Description { set; get; }

        public string MetaDescription { set; get; }

        public string MetaKeywork { set; get; }

        [Required]
        public Boolean Status { set; get; }

        [Required]
        public Boolean HomeFlag { set; get; }

        public virtual IEnumerable<FirstNumber> FirstNumbers { set; get; }
    }
}