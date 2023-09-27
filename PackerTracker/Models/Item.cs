using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
    public string Description { get; set; }
    public int Weight { get; set; }
    public int Id { get; }
    private static List<Item> _instances = new List<Item> { };


    public Item(string description, int weight)
    {
      Description = description;
      Weight = weight;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static int TotalWeight(List<Item> items)
    {
      int totWeight = 0;
      foreach (Item item in items)
      {
           totWeight += item.Weight;
      }
      return totWeight;
    }
    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Item Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
