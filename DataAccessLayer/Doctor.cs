using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Doctor
    {
        [Key]
        public long DoctorID { get; set; }
        public string DoctorName { get; set; }
        public DateTime DOB { get; set; }
        public int PassedOutYear { get; set; }
        public long MobileNumber { get; set; }
        public string Gender { get; set; }


    }
}
