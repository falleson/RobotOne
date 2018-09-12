using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOne.Domain
{
    public class Group : EntityBase
    {
        public int ParentId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

    }
}
