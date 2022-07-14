﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SistemaDeContatos.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<IdentityUser> signInManager, ILogger<LoginModel> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        /// <summary>
        ///     Esta API oferece suporte à infraestrutura de interface do usuário padrão do ASP.NET Core Identity e não se destina a ser usada
        ///     diretamente do seu código. Esta API pode ser alterada ou removida em versões futuras.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///    Esta API oferece suporte à infraestrutura de interface do usuário padrão do ASP.NET Core Identity e não se destina a ser usada
        ///    diretamente do seu código. Esta API pode ser alterada ou removida em versões futuras.
        /// </summary>
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///    Esta API oferece suporte à infraestrutura de interface do usuário padrão do ASP.NET Core Identity e não se destina a ser usada
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string ErrorMessage { get; set; }

        /// <summary>
        ///   Esta API oferece suporte à infraestrutura de interface do usuário padrão do ASP.NET Core Identity e não se destina a ser usada
        ///     diretamente do seu código.Esta API pode ser alterada ou removida em versões futuras.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///    Esta API oferece suporte à infraestrutura de interface do usuário padrão do ASP.NET Core Identity e não se destina a ser usada
            ///    diretamente do seu código.Esta API pode ser alterada ou removida em versões futuras.
                        /// </summary>
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            /// <summary>
            ///     Esta API oferece suporte à infraestrutura de interface do usuário padrão do ASP.NET Core Identity e não se destina a ser usada
            ///     diretamente do seu código.Esta API pode ser alterada ou removida em versões futuras.
                        /// </summary>
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            /// <summary>
            ///     Esta API oferece suporte à infraestrutura de interface do usuário padrão do ASP.NET Core Identity e não se destina a ser usada
            ///     diretamente do seu código.Esta API pode ser alterada ou removida em versões futuras.
                        /// </summary>
            [Display(Name = "Lembre de mim?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

            // Limpe o cookie externo existente para garantir um processo de login limpo
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                // Isso não conta falhas de login para bloqueio de conta
                // Para habilitar falhas de senha para acionar o bloqueio de conta, defina lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // Se chegamos até aqui, algo falhou, reexiba o formulário
            return Page();
        }
    }
}
