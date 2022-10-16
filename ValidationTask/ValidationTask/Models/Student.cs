using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace ValidationTask.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please Enter your name.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Your name must contain minimum 2 and Maximum 50 character")]
        [RegularExpression(@"^([A-Za-z][A-Za-z_.\s]{3,50})$", ErrorMessage = "Only (A-Z, a-z, _,.,space) is allowed")]
        public String name { get; set; }


        [Required(ErrorMessage = "Please Enter your ID.")]
        [RegularExpression(@"^([0-9]{2}[-][0-9]{5}[-][0-3]{1})$", ErrorMessage = "Id should be like 'XX-XXXXX-X'")]
        public String ID { get; set; }
        [Required(ErrorMessage ="Please select your gender.")]
        public String gender { get; set; }
        [Required(ErrorMessage ="Please Enter your Email")]
        [EmailAddress(ErrorMessage ="Enter correct Email format(Ex: abc@xyz.com)")]
        [RegularExpression(@"^[0-9]{2}[-][0-9]{5}[-][0-3]{1}@\w+([\.-]?\w+)*(\.\w{2,3})+$")]
        public String email { get; set; }
        [Required(ErrorMessage ="Please Enter your password")]
        [StringLength(100, MinimumLength =8, ErrorMessage ="Password length must be between 8 to 100")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage ="Your Password must contain at least 1 uppercase, 1 lower case, 1 digit and 1 special character")]
        public String pass { get; set; }
        [Required(ErrorMessage ="Please Enter Confirm password")]
        [Compare("pass", ErrorMessage ="Password and Confirm Password do not match") ]
        public String cpass { get; set; }
        [Required(ErrorMessage ="Please Enter your date of birth")]
        [BirthdayValidation(ErrorMessage ="You must be 18 by 2022/01/01")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public String dob { get; set; }
    }
}