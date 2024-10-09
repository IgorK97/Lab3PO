//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class order_lines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order_lines()
        {
            this.ingredients = new HashSet<ingredients>();
        }
        [Key]
        public int id { get; set; }
        [Required]
        public int ordersId { get; set; }
        [Required]
        public int pizzaId { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public bool custom { get; set; }
        [Required]
        public decimal position_price { get; set; }
        [Required]
        public int pizza_sizesId { get; set; }
        [Required]
        public decimal weight { get; set; }
        [ForeignKey("ordersId")]
    
        public virtual orders orders { get; set; }
        [ForeignKey("pizzaId")]
        public virtual pizza pizza { get; set; }
        [ForeignKey("pizza_sizesId")]
        public virtual pizza_sizes pizza_sizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ingredients> ingredients { get; set; }
    }
}
