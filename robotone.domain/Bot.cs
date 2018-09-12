using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RobotOne.Domain
{
    public class Bot : EntityBase
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Phase { get; set; }
        public string Description { get; set; }
        
        public int GroupId { get; set; }
        public int UserId { get; set; }

        public virtual Group Group { get; set; }

    }
}
