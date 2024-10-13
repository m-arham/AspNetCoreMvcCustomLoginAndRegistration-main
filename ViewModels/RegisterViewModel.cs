using System.ComponentModel.DataAnnotations;

namespace UsersApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

           // New fields
        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; }
        
        
         

    

                    
                [Required(ErrorMessage = "Please select at least one hobby.")]
                public List<string> Industries { get; set; } = new List<string>();

                    public bool IsAccounting { get; set; }
                    public bool IsAdvertising { get; set; }
                    public bool IsArchitecture { get; set; }
                    public bool IsAutomotive { get; set; }
                    public bool IsAviation { get; set; }
                    public bool IsBankingFinancial { get; set; }
                    public bool IsBioTech { get; set; }
                    public bool IsBrokerage { get; set; }
                    public bool IsCarpentryElectrical { get; set; }
                    public bool IsChemicalsPlasticsRubber { get; set; }
                    public bool IsCommunicationsInformation { get; set; }
                    public bool IsComputerHardware { get; set; }
                    public bool IsComputerReseller { get; set; }
                    public bool IsComputerSoftware { get; set; }
                    public bool IsConstruction { get; set; }
                    public bool IsConsulting { get; set; }
                    public bool IsConsumerElectronics { get; set; }
                    public bool IsConsumerPackagedGoods { get; set; }
                    public bool IsEducation { get; set; }
                    public bool IsEnergyUtilities { get; set; }
                    public bool IsEnvironmentalServices { get; set; }
                    public bool IsEngineering { get; set; }
                    public bool IsFashionApparel { get; set; }
                    public bool IsFoodBeverage { get; set; }
                    public bool IsGovernmentPublicSector { get; set; }
                    public bool IsHealthcare { get; set; }
                    public bool IsHospitalityTourism { get; set; }
                    public bool IsInsurance { get; set; }
                    public bool IsHumanResources { get; set; }
                    public bool IsInformationTechnology { get; set; }
                    public bool IsInternet { get; set; }
                    public bool IsLegalLaw { get; set; }
                    public bool IsManufacturing { get; set; }
                    public bool IsMarketResearch { get; set; }
                    public bool IsMediaEntertainment { get; set; }
                    public bool IsMilitary { get; set; }
                    public bool IsNonProfitSocialServices { get; set; }
                    public bool IsPersonalServices { get; set; }
                    public bool IsPharmaceuticals { get; set; }
                    public bool IsPrintingPublishing { get; set; }
                    public bool IsPublicRelations { get; set; }
                    public bool IsRealEstate { get; set; }
                    public bool IsRetailWholesale { get; set; }
                    public bool IsSecurity { get; set; }
                    public bool IsShippingDistribution { get; set; }
                    public bool IsTelecommunications { get; set; }
                    public bool IsTransportation { get; set; }
                    public bool IsMarketingg { get; set; }
                    public bool IsSaless { get; set; }
                    public bool IsOtherr { get; set; }
                    public bool IsDontWork { get; set; }
                    public bool IsInformationTechnologyServices { get; set; }


                 
                    public string CountryCode { get; set; }  // For the country code
                    public string PhoneNumber { get; set; }  // For the phone number
                   

                    [Required(ErrorMessage = "Please select at least one department.")]
                    public List<string> InfluenceDepartments { get; set; } = new List<string>();
                                    public bool IsAdmin { get; set; }
                                    public bool IsCustServ { get; set; }
                                    public bool IsExecLead { get; set; }
                                    public bool IsFinance { get; set; }
                                    public bool IsHR { get; set; }
                                    public bool IsMarketing { get; set; }
                                    public bool IsLegal { get; set; }
                                    public bool IsOps { get; set; }
                                    public bool IsProcurement { get; set; }
                                    public bool IsSales { get; set; }
                                    public bool IsSupplyChain { get; set; }
                                    public bool IsTechHardware { get; set; }
                                    public bool IsTechSoftware { get; set; }
                                    public bool IsTechImpl { get; set; }
                                    public bool IsOther { get; set; }


                        [Required(ErrorMessage = "Date of Birth is required.")]
                public DateTime DateOfBirth { get; set; } // Option 2 field

                [Required(ErrorMessage = "Industry is required.")]
                public string Industry { get; set; } // Option 3 field

                [Required(ErrorMessage = "Please indicate if you have a PayPal account.")]
                public string HasPayPal { get; set; } // Option 4 field

                [Required(ErrorMessage = "Job Title is required.")]
                public string JobTitle { get; set; } // Option 5 field

                [Required(ErrorMessage = "Employment Status is required.")]
                public string EmployStatus { get; set; } // Option 6 field

                [Required(ErrorMessage = "Employee Count is required.")]
                public string EmployeeCount { get; set; } // Option 7 field

                [Required(ErrorMessage = "Income Before Taxes is required.")]
                public string IncomeBeforeTaxes { get; set; } // Option 8 field

                [Required(ErrorMessage = "Education Level is required.")]
                public string EducationLevel { get; set; } // Option 9 field

                [Required(ErrorMessage = "Department is required.")]
                public string Department { get; set; } // Option 10 field

                [Required(ErrorMessage = "Annual Revenue is required.")]
                public string AnnualRevenue { get; set; } // Option 11 field

                [Required(ErrorMessage = "Family Income is required.")]
                public string FamilyIncome { get; set; } // Option 12 field

                [Required(ErrorMessage = "Please indicate your Smartphone Usage.")]
                public string SmartphoneUsage { get; set; } // Option 13 field

                [Required(ErrorMessage = "Please indicate if a Webcam is available.")]
                public string WebcamAvailability { get; set; } // Option 14 field

                [Required(ErrorMessage = "You must agree to provide feedback.")]
                public string FeedbackAgreement { get; set; } // Option 15 field


}
}
