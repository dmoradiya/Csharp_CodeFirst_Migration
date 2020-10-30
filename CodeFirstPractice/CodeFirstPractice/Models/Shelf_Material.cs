using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstPractice.Models
{
    [Table("shelf_material")]
    class Shelf_Material
    {
        public Shelf_Material()
        {
            Shelves = new HashSet<Shelf>();
        }

        [Key]
        [Column(TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "varchar(25)")]
        public string MaterialName { get; set; }

        [InverseProperty(nameof(Models.Shelf.Shelf_Material))]
        public virtual ICollection<Shelf> Shelves { get; set; }
    }
}
