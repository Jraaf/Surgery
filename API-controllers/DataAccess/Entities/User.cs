using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public int DoctorId { get; set; }

    public byte[] PasswordSalt { get; set; } = null!;
    [JsonIgnore]
    public virtual Doctor Doctor { get; set; } = null!;
}
