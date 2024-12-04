using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public int DoctorId { get; set; }

    public byte[] PasswordSalt { get; set; } = null!;

    public virtual Doctor Doctor { get; set; } = null!;
}
