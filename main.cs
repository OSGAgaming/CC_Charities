using System;
using System.Collections.Generic;
namespace Charity
{    
  public delegate bool CharityEventDelegate();

  partial class CharityDonationProcess 
  {
    public static event CharityEventDelegate CharityRoutine;

    private static CharityDatabase charityDatabase = new CharityDatabase();

    static List<Routine> Routines = new List<Routine>();

    public static int charityChosen = -1;
    public static int exitState = 0;

    public static void Main (string[] args) 
    {
      LoadCharities();

      foreach(Routine routine in Routines)
      {
        while(true)
        {
          bool ThrowState = routine._Action();
          if(ThrowState)
          {
            routine.CatchScope();
            continue;
          }
          else
          {
            break;
          }
        }
      }
      float Total = 0;
      foreach(CharityInfo CI in charityDatabase.Charities)
      {
        Total += CI.funds;
      } 
      DisplayCharityFunds();
      Logger.Header($"GRAND TOTAL DONATED TO CHARITY: " + Total);
      Console.WriteLine ("Thank you for your patience.");
    }
  }
}



