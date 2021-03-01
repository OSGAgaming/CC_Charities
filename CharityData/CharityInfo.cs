using System;
using System.Collections;

namespace Charity
{
  internal class CharityInfo
  {
     public int id;
     public string sId;
     public float funds;

     public CharityInfo(int _id, string _sId)
     {
         id = _id;
         sId = _sId;
         funds = 0;
     }
  }
}