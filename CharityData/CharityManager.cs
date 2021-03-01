using System;
using System.Collections.Generic;

namespace Charity
{
  public class CharityDatabase
  {
    internal List<CharityInfo> Charities = new List<CharityInfo>();
  
    public void AppendCharity(string name) => Charities.Add(new CharityInfo(Charities.Count, name));

    public void AddFundsToCharity(int _id, float amount) 
    {
      for(int i = 0; i<Charities.Count; i++)
      {
        if(Charities[i].id == _id)
          Charities[i].funds += amount;
      }
    } 

    public int NoOfCs()
    => Charities.Count;
  }
}