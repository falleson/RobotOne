using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOne.Domain
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CreatedBy
        {
            get { return "System"; }
            set { }
        }


        public DateTime Created
        {
            get { return DateTime.Now; }
            set { }
        }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? Modified { get; set; }

        public bool IsEnabled { get; set; }
    }
}
