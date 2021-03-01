using System;
using System.Collections.Generic;

namespace Charity
{
public class CharityDonation : Routine
  {
    public CharityDatabase charityDatabase;
    public int charityChosen => CharityDonationProcess.charityChosen;

    internal override bool _Action()
    {
        Logger.Header("What is your shopping bill");

        float valueOfShoppingBill;
        bool Valid = float.TryParse(Console.ReadLine(),out valueOfShoppingBill);

        if(!Valid)
         return true;

        float valueOfDonation = valueOfShoppingBill/100f;

        charityDatabase.AddFundsToCharity(charityChosen,valueOfDonation);

        Logger.Title(
        "You have successfully donated a total of " 
          + valueOfDonation + "$ to " + 
        charityDatabase.Charities[charityChosen].sId + "!");

        return false;
    }

    internal override void CatchScope()
    {
      Logger.Warn("Invalid Donation Amount");
    }

    public CharityDonation(CharityDatabase CD)
    {
      charityDatabase = CD;
    }
  }
}