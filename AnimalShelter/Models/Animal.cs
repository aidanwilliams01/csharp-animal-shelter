using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace AnimalShelter.Models
{
  public class Animal
  {
    public string Name { get; set; }
    public DateTime AdmittanceDate { get; set; }
    public string Breed { get; set; }
    public string Type { get; set; }
    public int AnimalId { get; set; }
  
    public Animal(string name, DateTime admittanceDate, string breed, string type, int id)
    {
      Name = name;
      AdmittanceDate = admittanceDate;
      Breed = breed;
      Type = type;
      AnimalId = id;
    }

    public Animal() {}
  }
}
