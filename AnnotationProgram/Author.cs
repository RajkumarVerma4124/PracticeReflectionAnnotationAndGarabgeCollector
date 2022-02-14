using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AnnotationProgram
{
    public class Author
    {
        [Required(ErrorMessage ="{0} name should not be empty")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "{0} name should not be empty")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "{0} name should not be empty")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "{0} name should not be empty")]
        public string LastName { get; set; }
        
        [Phone]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "{0} should be exactly 10 digit")]
        public string PhoneNumber { get; set; }
       
        [EmailAddress]
        public string EmailId { get; set; }
        
        [RangeAttribute(18,30, ErrorMessage = "{0} should be between 18 to 30")]
        public int Age { get; set; }

    }
}
