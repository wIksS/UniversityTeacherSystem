using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRInfoSystem.Models
{
    public class Teacher
    {
        private ICollection<Shedule> shedules;
        public Teacher()
        {
            //this.Shedules = new HashSet<Shedule>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string Phone { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}
