using System;
using System.Collections.Generic;
namespace Charity
{    
  partial class CharityDonationProcess 
  {
    public static void DisplayCharityFunds()
    {
      List<float> Buffer = new List<float>();
      foreach(CharityInfo CI in charityDatabase.Charities)
      {
         Buffer.Add(CI.funds);
      }

      float[] OrderedSet = Buffer.ToArray();
      Array.Sort(OrderedSet);
      Array.Reverse(OrderedSet);
      List<float> RepeatBuffer = new List<float>();
        for(int i = 0; i<OrderedSet.Length; i++)
        {
          for(int j = 0; j<charityDatabase.Charities.Count; j++)
          {
            var CI = charityDatabase.Charities[j];
            if(OrderedSet[i] == CI.funds)
            {
              if(!RepeatBuffer.Contains(j))
              Logger.Title("The " + CI.sId + " Charity has a total of: " + CI.funds);
              RepeatBuffer.Add(j);
            }
          }
        }
    }

    public static void DisplayCharities()
    {
      Logger.Title("-1: Show Funds");
      foreach(CharityInfo CI in charityDatabase.Charities)
      {
         Logger.Title(CI.id + ": Charity " + CI.sId);
      } 
      Console.WriteLine($"\n");
    }
    public static void LoadCharities()
    {
      charityDatabase.AppendCharity("Programming");
      charityDatabase.AppendCharity("Is");
      charityDatabase.AppendCharity("Fun");

      Routines.Add(new CharitySelection(charityDatabase));
      Routines.Add(new CharityDonation(charityDatabase));
      Routines.Add(new Callback());
    }
  }
}



