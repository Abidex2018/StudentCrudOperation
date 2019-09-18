using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegCrudOperation.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        //[Column(TypeName = "varchar")]
        [DisplayName("FullName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Name  must be between 3 and 200 characters")]
        public string Name { get; set; }

        //[Column(TypeName = "varchar")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Address is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Address  must be between 3 and 200 characters")]
        public string Address { get; set; }

       // [Column(TypeName = "varchar")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        //[Column(TypeName = "varchar")]
        [DisplayName("Matric No")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Matric Number is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Matric Number  must be between 4 and 20 characters")]
        public string MatriNo { get; set; }
    }
}
