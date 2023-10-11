using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace EvilMart.Models
{
public class Category
{
    public int Id {get; set;}

[Required]
[MaxLength(50)]
    public string Name {get; set;}=String.Empty;

[MaxLength(200)]
    public string? Description {get; set;}=String.Empty;
}
}