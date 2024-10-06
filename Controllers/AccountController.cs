using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UsersApp.Models;
using UsersApp.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace UsersApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<Users> signInManager; // Change from Users to ApplicationUser
        private readonly UserManager<Users> userManager; // Change from Users to ApplicationUser
        private readonly IEmailSender _emailSender;


           [Authorize]     
           public IActionResult Dashboard()
        {
            return View();
        }



       
        public IActionResult Login()
        {
            return View();
        }

        public AccountController(SignInManager<Users> signInManager, UserManager<Users> userManager, IEmailSender emailSender)
    {
        this.signInManager = signInManager; // Assigning the injected value
        this.userManager = userManager;
        this._emailSender = emailSender;
      
    }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Dashboard", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Email or password is incorrect.");
                    return View(model);
                }
            }
            return View(model);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Create a new ApplicationUser instance instead of Users
                Users user = new Users
                {
                    FullName = model.Name,
                    Email = model.Email,
                    UserName = model.Email,
                    Country = model.Country,          // Add the new fields her
                   
                  
                     Industries = string.Join(",",
    new List<string>
    {
        model.IsAccounting ? "Accounting" : null,
        model.IsAdvertising ? "Advertising" : null,
        model.IsArchitecture ? "Architecture" : null,
        model.IsAutomotive ? "Automotive" : null,
        model.IsAviation ? "Aviation" : null,
        model.IsBankingFinancial ? "Banking/Financial" : null,
        model.IsBioTech ? "Bio-Tech" : null,
        model.IsBrokerage ? "Brokerage" : null,
        model.IsCarpentryElectrical ? "Carpentry/Electrical Installations" : null,
        model.IsChemicalsPlasticsRubber ? "Chemicals/Plastics/Rubber" : null,
        model.IsCommunicationsInformation ? "Communications/Information" : null,
        model.IsComputerHardware ? "Computer Hardware" : null,
        model.IsComputerReseller ? "Computer Reseller (software/hardware)" : null,
        model.IsComputerSoftware ? "Computer Software" : null,
        model.IsConstruction ? "Construction" : null,
        model.IsConsulting ? "Consulting" : null,
        model.IsConsumerElectronics ? "Consumer Electronics" : null,
        model.IsConsumerPackagedGoods ? "Consumer Packaged Goods" : null,
        model.IsEducation ? "Education" : null,
        model.IsEnergyUtilities ? "Energy/Utilities/Oil and Gas" : null,
        model.IsEnvironmentalServices ? "Environmental Services" : null,
        model.IsEngineering ? "Engineering" : null,
        model.IsFashionApparel ? "Fashion/Apparel" : null,
        model.IsFoodBeverage ? "Food/Beverage" : null,
        model.IsGovernmentPublicSector ? "Government/Public Sector" : null,
        model.IsHealthcare ? "Healthcare" : null,
        model.IsHospitalityTourism ? "Hospitality/Tourism" : null,
        model.IsInsurance ? "Insurance" : null,
        model.IsHumanResources ? "Human Resources" : null,
        model.IsInformationTechnology ? "Information Technology/IT" : null,
        model.IsInternet ? "Internet" : null,
        model.IsLegalLaw ? "Legal/Law" : null,
        model.IsManufacturing ? "Manufacturing" : null,
        model.IsMarketResearch ? "Market Research" : null,
        model.IsMediaEntertainment ? "Media/Entertainment" : null,
        model.IsMilitary ? "Military" : null,
        model.IsNonProfitSocialServices ? "Non Profit/Social Services" : null,
        model.IsPersonalServices ? "Personal Services" : null,
        model.IsPharmaceuticals ? "Pharmaceuticals" : null,
        model.IsPrintingPublishing ? "Printing Publishing" : null,
        model.IsPublicRelations ? "Public Relations" : null,
        model.IsRealEstate ? "Real Estate/Property" : null,
        model.IsRetailWholesale ? "Retail Wholesale Trade" : null,
        model.IsSecurity ? "Security" : null,
        model.IsShippingDistribution ? "Shipping/Distribution" : null,
        model.IsTelecommunications ? "Telecommunications" : null,
        model.IsTransportation ? "Transportation" : null,
        model.IsMarketing ? "Marketing" : null,
        model.IsSales ? "Sales" : null,
        model.IsOther ? "Other" : null,
        model.IsDontWork ? "I don't work" : null,
        model.IsInformationTechnologyServices ? "Information Technology & Services" : null
    }.Where(industry => industry != null) // Filter out null values
),

                InfluenceDepartments = string.Join(",",
    new List<string>
    {
        model.IsAdmin ? "Administration" : null,
        model.IsCustServ ? "Customer Service" : null,
        model.IsExecLead ? "Executive Leadership" : null,
        model.IsFinance ? "Finance" : null,
        model.IsHR ? "Human Resources" : null,
        model.IsMarketing ? "Marketing" : null,
        model.IsLegal ? "Legal" : null,
        model.IsOps ? "Operations" : null,
        model.IsProcurement ? "Procurement" : null,
        model.IsSales ? "Sales" : null,
        model.IsSupplyChain ? "Supply Chain" : null,
        model.IsTechHardware ? "Technology Development Hardware" : null,
        model.IsTechSoftware ? "Technology Development Software" : null,
        model.IsTechImpl ? "Technology Implementation" : null,
        model.IsOther ? "Other" : null
    }.Where(department => department != null) // Filter out null values
),


                PhoneNumber = model.PhoneNumber,
                CountryCode = model.CountryCode,
                DateOfBirth = model.DateOfBirth,
                Industry = model.Industry,        // For the industry field
HasPayPal = model.HasPayPal,      // For the PayPal account field
JobTitle = model.JobTitle,        // For the job title field
EmpStatus = model.EmpStatus,      // For the employment status field
EmployeeCount = model.EmployeeCount, // For the employee count field
IncomeBeforeTaxes = model.IncomeBeforeTaxes, // For the income before taxes field
EducationLevel = model.EducationLevel, // For the education level field
Department = model.Department,    // For the department field
AnnualRevenue = model.AnnualRevenue, // For the annual revenue field
FamilyIncome = model.FamilyIncome, // For the family income field
SmartphoneUsage = model.SmartphoneUsage, // For the smartphone usage field
WebcamAvailability = model.WebcamAvailability, // For the webcam availability field
FeedbackAgreement = model.FeedbackAgreement,// For the feedback agreement field
                  



                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {

                     var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token }, Request.Scheme);
                
                // Send verification email
                await _emailSender.SendEmailAsync(user.Email, "Verify your email", 
                    $"Please confirm your email by clicking this link: <a href='{confirmationLink}'>link</a>");

                // Send user details email to a different email address
           await _emailSender.SendEmailAsync("arham.dowele@gmail.com", "New User Registration",
    $"A new user has registered:\n" +
    $"Full Name: {user.FullName},\n" +
    $"Email: {user.Email},\n" +
    $"Country: {user.Country},\n" +
    $"Country Code: {user.CountryCode},\n" +
    $"Phone Number: {user.PhoneNumber},\n" +
    $"Date of Birth: {user.DateOfBirth.ToShortDateString()},\n" +
    $"Education Level: {user.EducationLevel},\n" +
    $"Industries: {user.Industries},\n" +
    $"Influence Departments: {user.InfluenceDepartments},\n" +
    $"Has PayPal: {user.HasPayPal},\n" +
    $"Job Title: {user.JobTitle},\n" +
    $"Employment Status: {user.EmpStatus},\n" +
    $"Employee Count: {user.EmployeeCount},\n" +
    $"Income Before Taxes: {user.IncomeBeforeTaxes},\n" +
    $"Annual Revenue: {user.AnnualRevenue},\n" +
    $"Family Income: {user.FamilyIncome},\n" +
    $"Smartphone Usage: {user.SmartphoneUsage},\n" +
    $"Webcam Availability: {user.WebcamAvailability},\n" +
    $"Feedback Agreement: {user.FeedbackAgreement}"
    );


                
                    return RedirectToAction("VerifyEmail", "Account");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View(model);
                }
            }

            


            return View(model);
        }

        public IActionResult VerifyEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerifyEmail(VerifyEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.Email);

                if (user == null)
                {
                    ModelState.AddModelError("", "Something is wrong!");
                    return View(model);
                }
                else
                {
                    return RedirectToAction("ChangePassword", "Account", new { username = user.UserName });
                }
            }
            return View(model);
        }

        public IActionResult ChangePassword(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("VerifyEmail", "Account");
            }
            return View(new ChangePasswordViewModel { Email = username });
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.Email);
                if (user != null)
                {
                    var result = await userManager.RemovePasswordAsync(user);
                    if (result.Succeeded)
                    {
                        result = await userManager.AddPasswordAsync(user, model.NewPassword);
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }

                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email not found!");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Something went wrong. Try again.");
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}