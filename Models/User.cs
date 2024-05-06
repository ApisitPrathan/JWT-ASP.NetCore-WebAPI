﻿namespace JWT_ASP.NetCore_WebAPI.Models
{
  public class User
  {
    public string UserName { get; set; }
    public string Password { get; set; }
    public string EmailAddress { get; set; }
    public string Role { get; set; }
    public string RefreshToken { get; set; }
    public bool IsActive { get; set; } = false;
  }
}