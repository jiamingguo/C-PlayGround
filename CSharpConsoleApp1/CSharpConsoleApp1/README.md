# C#-PlayGround
Repo for learning C#

## Basic of Basics
- C# is a programming language based on .NET framework

## .NET framework
- Includes CLR and Class Library
- CLR: Common Language Runtime
-  It serves as the execution engine of .NET Framework. All .NET programs execute under the supervision of CLR, 
guaranteeing many properties and behaviors in the areas of memory management, security, and exception handling.
- CLR is like a JVM. Enabling cross platform deployment
- For computer programs to run on CLI, they need to be compiled into Common Intermediate Language (CIL): as opposed to 
being compiled into machine code.

## Code Structure
- Class -> NameSpace -> Assembly
- Assembly contains many NameSpaces; NameSpace contains Classes
- An assembly provides a fundamental unit of physical code grouping
- A namespace provides a fundamental unit of logical code grouping.
- An assembly is a collection of types and resources that forms a logical unit of functionality. 
All types in the .NET Framework must exist in assemblies; 
the common language runtime does not support types outside of assemblies. 
Each time you create a Microsoft Windows® Application, Windows Service, Class Library, or other application with 
Visual Basic .NET, you're building a single assembly. 
Each assembly is stored as an .exe or .dll file.

## Variables / Constants
```
int number;

int Number = 1;

const float pi = 3.14f;

```
- For local variables: Camel Case `int numberOne;`
- For Constant: Pascal Case `const int MaxZoom = 5;`
 
## Structs
- Structure
- Similar to Abstract Class
- Structs are value types and classes are reference types.
- value types always contains a value
- reference types can contain a null-reference, meaning that they don't refer to anything at all at the moment
- When you declare variables or fields, here's how the two types differ:
  - variable: value type lives on the stack, reference type lives on the stack as a pointer to somewhere in heap memory where the actual memory lives (though note Eric Lipperts article series: The Stack Is An Implementation Detail.)
  - class/struct-field: value type lives completely inside the type, reference type lives inside the type as a pointer to somewhere in heap memory where the actual memory lives.