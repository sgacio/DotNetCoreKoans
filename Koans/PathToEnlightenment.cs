using System;
using DotNetCoreKoans.Engine;

namespace DotNetCoreKoans.Koans
{
  public class PathToEnlightenment : Path
  {
    public PathToEnlightenment()
    {
      Types = new Type[] {
                // START: Adventure Mode
                typeof(AboutAsserts),
                //passed
                typeof(AboutNull),
                //passed
                typeof(AboutArrayAssignment),
                //passed
                typeof(AboutStrings),
                //passed
                typeof(AboutFloats),
                //passed
                typeof(AboutControlStatements),
                //passed
                typeof(AboutArrays),
                //passed
                typeof(AboutMethods),
                //passed
                // END: Adventure Mode

                // START: Explorer mode
                typeof(AboutDelegates),
                //passed 
                typeof(AboutLambdas),
                //passed
                typeof(AboutLinq),
                //passed
                typeof(AboutInheritance),
                //passed
                // END: Explorer Mode

                // START: Epic mode
                typeof(AboutGenericContainers),
                //passed
                typeof(AboutBitwiseAndShiftOperator),
                //passed
                };
    }
  }
}