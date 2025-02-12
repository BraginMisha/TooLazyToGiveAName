namespace individual_project_bragin_sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user$")]
    public partial class user_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user_()
        {
            order_ = new HashSet<order_>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [Required]
        [StringLength(255)]
        public string Surname { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string otchestvo { get; set; }

        [Required]
        [StringLength(255)]
        public string login { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        public int account_level { get; set; }

        public int? Rating { get; set; }

        public virtual account_level_ account_level_ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_> order_ { get; set; }
    }
}
