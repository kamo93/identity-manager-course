﻿using System.ComponentModel.DataAnnotations;

namespace IdentityManager.Models.Views;

public class RegisterViewModel
{
  [Required]
  public string Name { get; set; }

  [Required]
  [EmailAddress]
  public string Email { get; set; }

  [Required]
  [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
  [DataType(DataType.Password)]
  [Display(Name = "Password")]
  public string Password { get; set; }

  [Required]
  [DataType(DataType.Password)]
  [Display(Name = "Confirm password")]
  [Compare("Password", ErrorMessage = "The passwords do not match.")]
  public string ConfirmPassword { get; set; }
}
