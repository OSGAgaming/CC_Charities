using System;
using System.Collections.Generic;

namespace Charity
{
  public abstract class Routine
  {
    public CharityDatabase charityDatabase;

    internal virtual bool _Action() { return false; }

    internal virtual void CatchScope() { }
  }
}
