using System;

namespace PongClone.Models

{
  public class User
  {
    public int UserId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber {get; set; }
    public string Email { get; set; }
    public List<TournamentUser> {get; set; }
  }
}