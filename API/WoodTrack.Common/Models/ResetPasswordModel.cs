﻿namespace WoodTrack.Common;

public class ResetPasswordModel
{
    public string Email { get; set; } = default!;
    public string? NewPassword { get; set; }
}
