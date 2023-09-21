using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeamPlayers.models;

public class Team {
    
    [Key, Required, MaxLength(30)]
    public string? TeamName { get; set; }
    public string? City { get; set; }
    public string? Province { get; set; }
    public string? Country { get; set; }

    public List<Player>? Players { get; set; }
}