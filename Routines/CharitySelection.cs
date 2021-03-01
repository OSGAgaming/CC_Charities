using System;
using System.Collections.Generic;

namespace Charity
{
public class CharitySelection : Routine
  {
    public int charityChosen => CharityDonationProcess.charityChosen;
    int chosen;
    internal override bool _Action()
    {
        Logger.Header("Which Charity would you like to donate to?");
        CharityDonationProcess.DisplayCharities();
        bool Valid = int.TryParse(Console.ReadLine(),out chosen);
        if(Valid)
        {
          if(chosen == -1)
          {
            CharityDonationProcess.DisplayCharityFunds();
            return true;
          }
          else
          CharityDonationProcess.charityChosen = chosen;
        } 
        return charityChosen < -1 || charityChosen > charityDatabase.NoOfCs() - 1 || !Valid;
    }

    internal override void CatchScope()
    {
      if(chosen != -1) 
      Logger.Warn("Chosen Charity does not exist");
    }

    public CharitySelection(CharityDatabase CD)
    {
      charityDatabase = CD;
    }
  }
}