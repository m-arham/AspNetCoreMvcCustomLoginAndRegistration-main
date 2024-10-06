using Microsoft.AspNetCore.Identity;

namespace UsersApp.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
       
            public string Country { get; set; }    // Add this line for Country



             
    public string CountryCode { get; set; }  // For the country code
    public string PhoneNumber { get; set; }  // For the phone number
    public DateTime DateOfBirth { get; set; }


     public string Industry { get; set; } // Option 3 field

   
    public bool HasPayPal { get; set; } // Option 4 field

   
    public string JobTitle { get; set; } // Option 5 field


    public string EmpStatus { get; set; } // Option 6 field

   
    public int EmployeeCount { get; set; } // Option 7 field


    public decimal IncomeBeforeTaxes { get; set; } // Option 8 field


    public string EducationLevel { get; set; } // Option 9 field

    public string Department { get; set; } // Option 10 field


    public decimal AnnualRevenue { get; set; } // Option 11 field

   
    public decimal FamilyIncome { get; set; } // Option 12 field

    
    public bool SmartphoneUsage { get; set; } // Option 13 field

    
    public bool WebcamAvailability { get; set; } // Option 14 field

    
    public bool FeedbackAgreement { get; set; } // Option 15 field

    public string Industries { get; set; }  // List of industries the user is involved in


    public string InfluenceDepartments { get; set; } 


    }
}
