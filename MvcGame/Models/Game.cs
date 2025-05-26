using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcGame.Models;

public class Game
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Player { get; set; }
    [StringLength(60, MinimumLength = 2)]
    [Required]
    public string? Character { get; set; }
    [Range(1, 30)]
    public int Level { get; set; }
    [Range(0, 99999)]
    public int Gold { get; set; }
    public string? Result { get; set; }
}