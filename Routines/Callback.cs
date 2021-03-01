 using System;
using System.Collections.Generic;

namespace Charity
{
 
 public class Callback : Routine
  {
    internal override bool _Action()
    {
        Logger.Header("Would you like to start again? y/n");

        string option = Console.ReadLine();
        
        if(option == "y")
          CharityDonationProcess.exitState = 0;
        else if(option == "n")
           CharityDonationProcess.exitState = -1;
        else
          return true;
          return false;
    }
  }
}