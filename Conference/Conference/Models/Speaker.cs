using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Conference.Models
{
    public class Speaker
    {
        public Int32 SpeakerID { get; set; }


        [Required(ErrorMessage= "Name is required")]// display te ja dekhacce setayuy bolbe 
        [Display(Name = "Speaker Name")]
        public string Name { get; set; }


        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }


     //   public virtual List<Session> Sessions { get; set; }

    }
}
