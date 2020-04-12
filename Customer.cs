using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team_1.Models
{
    public class Customer
    {
        public string Customer_ID { get; set; }
        [Required(ErrorMessage = "customername is must")]
        //[RegularExpression("^[A-Za-z]{1,}$", ErrorMessage = " customername NOT IN CORRECT FORMAT")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Dob is  must")]

        [CustomDOB(ErrorMessage = "Invalid")]
        public System.DateTime DateOfBirth { get; set; }
        [RegularExpression("^(?:(?:\\+|0{0,2})91(\\s*[\\-]\\s*)?|[0]?)?[789]\\d{9}$", ErrorMessage = " contactnumber NOT IN CORRECT FORMAT")]
        //[RegularExpression("^[+]91(789){1}[0-9]{9}$",ErrorMessage ="Contatno is incorrect format!!!")]

        [Required(ErrorMessage = "contactno is must")]
        public long ContactNumber { get; set; }
        [Required(ErrorMessage = "Email is  must")]
        [EmailAddress(ErrorMessage = "Not a valid email")]
        public string EmailAddress { get; set; }
        [RegularExpression("^[A-Za-z]{1,}$", ErrorMessage = " country NOT IN CORRECT FORMAT")]
        [Required(ErrorMessage = "country is must")]
        public string Country { get; set; }
        [RegularExpression("^[A-Za-z]{1,}$", ErrorMessage = " city NOT IN CORRECT FORMAT")]
        [Required(ErrorMessage = "city is must")]
        public string City { get; set; }
        [Required(ErrorMessage = "pincode is must")]
        [RegularExpression("^[1-9]{1}[0-9]{5}$", ErrorMessage = "pincode NOT IN CORRECT FORMAT")]

        public int PinCode { get; set; }
        [Required(ErrorMessage = "state is must")]
        public string State { get; set; }
        public string CustomerType { get; set; }
        [Required(ErrorMessage = "password is must")]

        [RegularExpression("^([a-zA-Z0-9@*#$+]{8,25})$", ErrorMessage = "password not in correct format")]
        [Custompass(ErrorMessage = "Invalid")]
        public string Password { get; set; }
        [Required(ErrorMessage = "conpass is must")]
        [Compare("Password", ErrorMessage = "Password mismatch")]
        public string Confirmpassword { get; set; }
    }
}