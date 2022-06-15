namespace TestAUTHH
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Users { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public int ID_Role { get; set; }

        public virtual Role Role { get; set; }
    }
}
