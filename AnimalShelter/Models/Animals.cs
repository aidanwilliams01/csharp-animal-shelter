using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public string Name { get; set; }
    public string AdmittanceDate { get; set; }
    public string Breed { get; set; }
    public int Type { get; set; }
    public int AnimalId { get; set; }
  
    public Animal(string name, string admittanceDate, string breed, int type, int id)
    {
      Name = name;
      AdmittanceDate = admittanceDate;
      Breed = breed;
      Type = type;
      AnimalId = id;
    }
  }
}
