# _Triangle Tracker_

#### _Epicodus Project May 11, 2020_

#### By _**Jessica Hvozdovich and Nathan Watkins-Hoagland**_

## Description

_A project to introduce the C# language and the .NET Core framework. The lesson is meant to practice creating automated testing methods using MSTest._

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Run the program with the command dotnet build.

## Known Bugs

There are no known bugs at the time of this update.
 
## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/WiseFool92/TriangleTestCSharp) here on GitHub._

## Technologies Used

* C#
* .NET Core
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Triangles with three equivalent sides are equilateral** | User Input:”Side 1: 3, Side 2: 3, Side 3: 3” | Output: "Equilateral" |
| **Triangles with two equivalent sides are isosceles** | User Input:”Side 1: 3, Side 2: 3, Side 3: 2” | Output: "Isosceles" |
| **Triangles with no equivalent sides are isosceles** | User Input:”Side 1: 3, Side 2: 2, Side 3: 4” | Output: "Scalene" |
| **Triangles with two sides that add up to less than the value of the third side are invalid** | User Input:”Side 1: 3, Side 2: 2, Side 3: 7” | Output: "Invalid" |

### License

This software is licensed under the MIT license.

Copyright (c) 2020 **_Jessica Hvozdovich and Nathan Watkins-Hoagland_**