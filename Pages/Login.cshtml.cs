using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Piranha;
using Piranha.Manager;

namespace MyPiranhaExamples.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ISecurity _service;
        private readonly ManagerLocalizer _localizer;

        public LoginModel(ISecurity service, ManagerLocalizer localizer)
        {
            _service = service;
            _localizer = localizer;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            public string Username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            await _service.SignOut(HttpContext);

            if (!ModelState.IsValid || !await _service.SignIn(HttpContext, Input.Username, Input.Password))
            {
                ModelState.Clear();
                ModelState.AddModelError(string.Empty, _localizer.General["Username and/or password are incorrect."].Value);
                return Page();
            }

            if (!string.IsNullOrEmpty(returnUrl))
            {
                return LocalRedirect(returnUrl);
            }

            return new RedirectToPageResult("Index");
        }
    }
}
