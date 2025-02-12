namespace individual_project_bragin_sport.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("order$")]
    public partial class order_
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_order { get; set; }

        public int orderNumber { get; set; }

        public int id_goods { get; set; }

        public int kolichestvo { get; set; }

        public DateTime date_order { get; set; }

        public DateTime date_delivery { get; set; }

        public int pick_up_point { get; set; }

        public int? fio_clienta { get; set; }

        public double cod_verification { get; set; }

        public int status_order { get; set; }

        public virtual goods_ goods_ { get; set; }

        public virtual C_pick_up_point__ C_pick_up_point__ { get; set; }

        public virtual status_order_ status_order_ { get; set; }

        public virtual user_ user_ { get; set; }
    }
}
