using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.ClientList = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    public string Name { get; set; }

    //this is their specialty e.g. "Color", "Womens hair", "Mens hair", "Curly", etc.
    public string Skill { get; set; }
    public virtual ICollection<Client> ClientList { get; set; }
  }
}