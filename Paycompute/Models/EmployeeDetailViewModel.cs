﻿using Paycompute.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Paycompute.Models
{
    public class EmployeeDetailViewModel
    {

        public int Id { get; set; }
        [Required]
        public string EmployeeNo { get; set; }

       
        public string FirstName { get; set; }

       
        public string MiddleName { get; set; }

       
        public string LastName { get; set; }

        
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }

        public DateTime DOB { get; set; }

        public DateTime DateJoined { get; set; }
        public string Designation { get; set; }

        public string Email { get; set; }


        
        public string NationalInsuranceNo { get; set; }

        public PaymentMetod PaymentMetod { get; set; }

        public StudentLoan StudentLoan { get; set; }

        public UnionMember UnionMember { get; set; }

        
        public string Address { get; set; }

        public string City { get; set; }
        public string Phone { get; set; }


       
        public string PostCode { get; set; }

       

    }
}
