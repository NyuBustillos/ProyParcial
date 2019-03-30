using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Parc.Models
{
    public enum Tipoestado
    {
        Activo,
        Inactivo,
    }
    public enum Tipounidad
    {
        Botella,
        Metro,
        Litro,
        Caja
    }
    public class Product
    {

        [Key]
        public int ProductId { get; set; };
        [Required]
        [Display(Name = "Product Name")]
        public string Nombre { get; set; };
        [Required]
        public decimal Precio { get; set; };
        public int Cantidad { get; set; };
        [Required]
        public Tipounidad Unidad { get; set; };
        public Tipoestado Estado { get; set; };


    }
}