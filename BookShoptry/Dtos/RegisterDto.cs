﻿namespace BookShoptry.Dtos;

public class RegisterDto
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string? Role { get; set; }
}
