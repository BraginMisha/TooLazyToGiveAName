namespace individual_project_bragin_sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("'pick-up point$'")]
    public partial class C_pick_up_point__
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C_pick_up_point__()
        {
            order_ = new HashSet<order_>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_point { get; set; }

        public long index { get; set; }

        public int city { get; set; }

        [Required]
        [StringLength(255)]
        public string street { get; set; }

        public double house { get; set; }

        public virtual city_point_ city_point_ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_> order_ { get; set; }
    }
}
