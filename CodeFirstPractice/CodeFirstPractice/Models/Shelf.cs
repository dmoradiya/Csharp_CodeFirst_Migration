using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CodeFirstPractice.Models
{
    [Table("shelf")]
    class Shelf
    {
        [Key]
        [Column(TypeName = "int(10)")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "int(10)")]
        public int ShelfMaterialID { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [ForeignKey(nameof(ShelfMaterialID))]
        [InverseProperty(nameof(Models.Shelf_Material.Shelves))]
        public virtual Shelf_Material Shelf_Material { get; set; }
    }
}
