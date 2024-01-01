﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TechShopBackendDotnet.Models;

[Table("customer")]
[Index("ResetTokenHash", Name = "reset_token_hash", IsUnique = true)]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Customer
{
    [Key]
    [Column("EMAIL")]
    public string Email { get; set; }

    [Required]
    [Column("NAME")]
    [StringLength(255)]
    public string Name { get; set; }

    [Required]
    [Column("PASSWORD")]
    [StringLength(255)]
    public string Password { get; set; }

    [Required]
    [Column("PHONE")]
    [StringLength(255)]
    public string Phone { get; set; }

    [Required]
    [Column("GENDER")]
    [StringLength(50)]
    public string Gender { get; set; }

    [Column("BIRTHDAY")]
    public DateOnly Birthday { get; set; }

    [Required]
    [Column("ADDRESS")]
    [StringLength(255)]
    public string Address { get; set; }

    [Required]
    [Column("WARD")]
    [StringLength(255)]
    public string Ward { get; set; }

    [Required]
    [Column("DISTRICT")]
    [StringLength(255)]
    public string District { get; set; }

    [Required]
    [Column("CITY")]
    [StringLength(255)]
    public string City { get; set; }

    [Column("IMAGE", TypeName = "mediumblob")]
    public byte[]? Image { get; set; }

    [Column("STATUS")]
    [StringLength(255)]
    public string Status { get; set; }

    [Column("reset_token_hash")]
    [StringLength(64)]
    public string? ResetTokenHash { get; set; }

    [Column("reset_token_expires_at", TypeName = "datetime")]
    public DateTime? ResetTokenExpiresAt { get; set; }
}