﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CommonLayer.User
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int userId { get; set; }
        [Required]
        public string fName { get; set; }
        [Required]
        public string lName { get; set; }
        public string phoneNo { get; set; }
        public string address { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        public string CPassword { get; set; }
        public DateTime registeredDate { get; set; }
        public DateTime modifiedDate { get; set; }
    }
}
