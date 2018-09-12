using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotOne.Domain
{
    public class User : EntityBase
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Role { get; set; }


        /// <summary>
        /// Foreign key for Group
        /// </summary>
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
