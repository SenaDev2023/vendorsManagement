using System;
using System.Collection.Generic;

class Commodity
{

    public string Name {get; set; }
    public string Description {get; set; }
    public int TotalQuantity {get; private set;}
    public List<Release> Releases {get; private set; } = new List<Release>();
    
    public commodity(string name, string description, int totalQuantity)
    {
        Name = name;
        Description = description;
        TotalQuantity = totalQuantity;
    }
    
    //Method to add a release and decrement the total quantity
    
    public void AddRelease (Release release)
    {
        if (release.Quantity > TotalQuantity)
        {
            throw new InvalidOperationException("Release quantity exceeds total availible quantity.");
        }
        Releases.Add(release);
        TotalQuantity -=release.Quantity;
        Console.WriteLine($"Release of{release.Quantity} lbs. added. Remaining quantity: {TotalQuantity} lbs.");
        }
    }
    
    class Release
    {
        
        public int Quantity {get; set; } // Quani
    }
    
    
    
}
