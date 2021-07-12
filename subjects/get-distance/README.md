# Instructions

Create 2 `GetDistance` methods:
The first one takes a second PointOfInterest as parameter, the second one is a static method that takes 2 PointOfInterest as parameters.

Both of them need to returns the distance in meters between the 2 points, rounded 2 digits after the decimal point.

# Expected Methods

```c#
public double GetDistance(PointOfInterest other)
{
    // Your code
}

public static double GetDistance(PointOfInterest p1, PointOfInterest p2)
{
    // Your code
}
```

# Usage

Here is a possible Program.cs file to test your code :

```c#
using System;
using CSharpDiscovery.Quest03;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] str)
        {
            var BordeauxCampus = new PointOfInterest();
            var ParisCampus = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);

            Console.WriteLine(BordeauxCampus.GetDistance(ParisCampus));
            Console.WriteLine(PointOfInterest.GetDistance(BordeauxCampus, ParisCampus));
        }
    }
}
```

and it's output :

```
$ dotnet run
496,92
496,92
$
```
