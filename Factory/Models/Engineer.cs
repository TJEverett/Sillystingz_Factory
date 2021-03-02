using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string NameFirst { get; set; }
    public string NameLast { get; set; }
    public virtual ICollection<EngineerMachine> Machines { get; set; }

    public Engineer()
    {
      this.Machines = new HashSet<EngineerMachine>();
    }
  }
}