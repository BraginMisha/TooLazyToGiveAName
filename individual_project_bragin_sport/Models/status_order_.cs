namespace individual_project_bragin_sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("status_order$")]
    public partial class status_order_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public status_order_()
        {
            order_ = new HashSet<order_>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int status_id { get; set; }

        [Required]
        [StringLength(255)]
        public string status_order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_> order_ { get; set; }
    }
}
