﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace SeedingLibrary.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime? BirthDay { get; set; }

    public string Email { get; set; }

    public Gender Gender { get; set; }
}