using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaAdmin.Models;

public class Slider
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }
    


}