namespace individual_project_bragin_sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("goods$")]
    public partial class goods_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public goods_()
        {
            order_ = new HashSet<order_>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_goods { get; set; }

        [Required]
        [StringLength(255)]
        public string code { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string unit_of_measurement { get; set; }

        public double price { get; set; }

        public int size_max_price { get; set; }

        public int producer { get; set; }

        public int supplier { get; set; }

        public int product_category { get; set; }

        public double now_price { get; set; }

        public int Quantity_in_stock { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        public virtual product_category_ product_category_ { get; set; }

        public virtual produser_ produser_ { get; set; }

        public virtual suplier_ suplier_ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_> order_ { get; set; }
    }
}
