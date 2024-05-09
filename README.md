
C# language
===========

- [C# language](#c-language)
  - [A first application](#a-first-application)
      - [Project folder tree](#project-folder-tree)
    - [The various file extensions of a project source files](#the-various-file-extensions-of-a-project-source-files)
    - [Solution Explorer window](#solution-explorer-window)
    - [The References section in the Solution Explorer window](#the-references-section-in-the-solution-explorer-window)
    - [NuGet Packages](#nuget-packages)
    - [A sample console program](#a-sample-console-program)
    - [Program.cs](#programcs)
    - [Useful shortcut keys](#useful-shortcut-keys)
    - [ildasm](#ildasm)
  - [C# language elements](#c-language-elements)
    - [Types, variables and constants](#types-variables-and-constants)
      - [C# built-in (or predefined) types](#c-built-in-or-predefined-types)
      - [User defined types](#user-defined-types)
      - [Reference types](#reference-types)
      - [All types inherit, directly or indirectly from System.Object.](#all-types-inherit-directly-or-indirectly-from-systemobject)
      - [Integral (ordinal) types](#integral-ordinal-types)
      - [Unicode characters](#unicode-characters)
      - [Variables and constants](#variables-and-constants)
        - [Variable declaration syntax](#variable-declaration-syntax)
        - [Constant declaration syntax](#constant-declaration-syntax)
      - [Literal values](#literal-values)
      - [Character literals](#character-literals)
      - [Character escape sequences](#character-escape-sequences)
      - [String literals](#string-literals)
      - [Variable initialization](#variable-initialization)
      - [Blocks and scope](#blocks-and-scope)
    - [Expressions, Selection statements and Logical (boolean) operators](#expressions-selection-statements-and-logical-boolean-operators)
      - [Operators](#operators)
      - [Expressions](#expressions)
      - [Statements](#statements)
      - [Selection statements](#selection-statements)
      - [Logical (or boolean) operators](#logical-or-boolean-operators)
      - [Relational operators](#relational-operators)
    - [Iteration statements or Loops](#iteration-statements-or-loops)
      - [for](#for)
      - [while](#while)
      - [do-while](#do-while)
      - [foreach](#foreach)
      - [break statement](#break-statement)
      - [continue statement](#continue-statement)
    - [Implicitly Typed Local Variables: The keyword var](#implicitly-typed-local-variables-the-keyword-var)
    - [Nullable types](#nullable-types)
      - [Declaring nullable types](#declaring-nullable-types)
      - [A nullable type has members](#a-nullable-type-has-members)
      - [Nullable type convertions](#nullable-type-convertions)
      - [Nullable type operators](#nullable-type-operators)
      - [The ?? operator](#the--operator)
    - [Casting, convertions and boxing](#casting-convertions-and-boxing)
      - [Casting](#casting)
      - [Data convertion](#data-convertion)
      - [checked and unchecked statements](#checked-and-unchecked-statements)
      - [is and as operators](#is-and-as-operators)
      - [typeof operator and GetType() method](#typeof-operator-and-gettype-method)
      - [sizeof operator](#sizeof-operator)
      - [the ?: conditional operator](#the--conditional-operator)
      - [Operator precedence](#operator-precedence)
      - [Boxing and unboxing](#boxing-and-unboxing)
    - [Comments](#comments)
      - [TODO comments](#todo-comments)
      - [XML Documentation Comments](#xml-documentation-comments)
        - [Documentation generation](#documentation-generation)
    - [C# conditional preprocessor directives](#c-conditional-preprocessor-directives)
      - [Other directives](#other-directives)
    - [Exceptions](#exceptions)
      - [Exceptions are classes](#exceptions-are-classes)
      - [The finally part](#the-finally-part)
      - [Trapping unhandled user interface exceptions](#trapping-unhandled-user-interface-exceptions)
  - [Special types](#special-types)
    - [Enum types](#enum-types)
      - [Sets (bit-fields)](#sets-bit-fields)
    - [Arrays](#arrays)
      - [Accessing array elements](#accessing-array-elements)
      - [Arrays are Reference types.](#arrays-are-reference-types)
      - [Commonly used array methods](#commonly-used-array-methods)
      - [Arrays and methods](#arrays-and-methods)
      - [Jagged Arrays](#jagged-arrays)
    - [Strings](#strings)
      - [The empty string](#the-empty-string)
      - [The null string](#the-null-string)
      - [The System.String class](#the-systemstring-class)
      - [The StringBuilder class](#the-stringbuilder-class)
    - [The DateTime struct type](#the-datetime-struct-type)
      - [Initializing a DateTime value](#initializing-a-datetime-value)
      - [TimeSpan class](#timespan-class)
      - [Other classes related to date and time](#other-classes-related-to-date-and-time)
    - [Lists and Collections](#lists-and-collections)
      - [Commonly used list and collection related interfaces](#commonly-used-list-and-collection-related-interfaces)
      - [ArrayList class](#arraylist-class)
      - [Hashtable Class and dictionaries](#hashtable-class-and-dictionaries)
      - [SortedList Class](#sortedlist-class)
      - [Queue class and Stack class](#queue-class-and-stack-class)
      - [BitArray class](#bitarray-class)
      - [System.Collections.Specialized namespace](#systemcollectionsspecialized-namespace)
  - [Classes](#classes)
    - [Namespaces](#namespaces)
      - [The using directive](#the-using-directive)
    - [Delegates](#delegates)
      - [Multicasting](#multicasting)
      - [Delegate class and MulticastDelegate class](#delegate-class-and-multicastdelegate-class)
      - [Named methods and Anonymous methods](#named-methods-and-anonymous-methods)
    - [Classes](#classes-1)
      - [Class definition](#class-definition)
      - [Objects and object variables](#objects-and-object-variables)
      - [Inheritance](#inheritance)
      - [Access modifiers and class members](#access-modifiers-and-class-members)
        - [Keyword Accessability](#keyword-accessability)
      - [Constructors and the default constructor](#constructors-and-the-default-constructor)
      - [Methods](#methods)
      - [Method parameters](#method-parameters)
      - [Overloaded methods](#overloaded-methods)
      - [The params keyword](#the-params-keyword)
      - [Properties and fields](#properties-and-fields)
        - [Asymmetric Accessor Accessibility](#asymmetric-accessor-accessibility)
        - [Auto-implemented Properties](#auto-implemented-properties)
      - [Indexers](#indexers)
      - [Events](#events)
      - [Static classes and static members](#static-classes-and-static-members)
      - [Hiding members in derived classes](#hiding-members-in-derived-classes)
      - [Polymorphism, virtual and override methods and properties](#polymorphism-virtual-and-override-methods-and-properties)
      - [Abstract classes](#abstract-classes)
      - [Interfaces](#interfaces)
      - [Structs](#structs)
      - [The System.Object class](#the-systemobject-class)
      - [Object comparison](#object-comparison)
      - [Nested types](#nested-types)
      - [Partial classes and partial methods](#partial-classes-and-partial-methods)
      - [Anonymous types - Object and collection initializers](#anonymous-types---object-and-collection-initializers)
      - [Extension methods](#extension-methods)
      - [Operator overloading](#operator-overloading)
      - [Naming code elements](#naming-code-elements)
    - [Destructors and the Garbage Collector](#destructors-and-the-garbage-collector)
        - [GC methods](#gc-methods)
      - [IDisposable](#idisposable)
    - [Pointers and unsafe code](#pointers-and-unsafe-code)
      - [The /unsafe compiler option and the keyword unsafe](#the-unsafe-compiler-option-and-the-keyword-unsafe)
      - [The address of operator \& and the indication (de-reference) operator \*](#the-address-of-operator--and-the-indication-de-reference-operator-)
      - [Memory addresses can be converted to integers and vise versa](#memory-addresses-can-be-converted-to-integers-and-vise-versa)
      - [Struct pointer types, fixed size buffers and the keyword fixed and pinned variables](#struct-pointer-types-fixed-size-buffers-and-the-keyword-fixed-and-pinned-variables)
      - [The keyword stackalloc](#the-keyword-stackalloc)
      - [The pointer member operator -\>](#the-pointer-member-operator--)
      - [Pointer arithmetic](#pointer-arithmetic)
      - [Indexing a pointer](#indexing-a-pointer)
      - [Pointer comparisons](#pointer-comparisons)
      - [Heap and stack](#heap-and-stack)
      - [Recursive methods](#recursive-methods)
      - [IDE menus and tools related to classes](#ide-menus-and-tools-related-to-classes)
  - [Advanced language issues](#advanced-language-issues)
    - [Attributes](#attributes)
      - [Attribute class and applying attributes](#attribute-class-and-applying-attributes)
      - [Custom attributes](#custom-attributes)
    - [Common Language Runtime, Application Domains and Assemblies](#common-language-runtime-application-domains-and-assemblies)
      - [Common Intermediate Language (CIL)](#common-intermediate-language-cil)
      - [Common Language Infrastructure (CLI)](#common-language-infrastructure-cli)
      - [Managed and unmanaged code](#managed-and-unmanaged-code)
      - [Application and Process](#application-and-process)
      - [Application domains](#application-domains)
      - [Assemblies](#assemblies)
      - [GAC, shared and private assemblies](#gac-shared-and-private-assemblies)
      - [Common Language Runtime hosts (Application Domain hosts)](#common-language-runtime-hosts-application-domain-hosts)
      - [AppDomain class and Assembly class](#appdomain-class-and-assembly-class)
    - [Reflection](#reflection)
      - [Using Reflection](#using-reflection)
    - [Lambda Expressions](#lambda-expressions)
        - [Expression Lambda and Statement Lambda](#expression-lambda-and-statement-lambda)
        - [Parentheses and parameters](#parentheses-and-parameters)
      - [Variable scope in lambda expressions](#variable-scope-in-lambda-expressions)
    - [Generics](#generics)
      - [Terminology](#terminology)
        - [Type Parameter](#type-parameter)
        - [Generic Type Argument](#generic-type-argument)
        - [Constructed Type](#constructed-type)
        - [Open Constructed Type](#open-constructed-type)
        - [Closed Constructed Type](#closed-constructed-type)
        - [Type Inference](#type-inference)
        - [Generics are not covariant](#generics-are-not-covariant)
      - [The generic List class](#the-generic-list-class)
      - [Arrays with a lower bound of zero and the generic IList interface](#arrays-with-a-lower-bound-of-zero-and-the-generic-ilist-interface)
      - [Generic methods](#generic-methods)
      - [Generic inheritance](#generic-inheritance)
      - [Constraints on generic type parameters](#constraints-on-generic-type-parameters)
      - [Generic delegates](#generic-delegates)
      - [Predefined generic delegates](#predefined-generic-delegates)
      - [Array and List generic methods](#array-and-list-generic-methods)
      - [Predefined generic classes and interfaces](#predefined-generic-classes-and-interfaces)
      - [Generics and the keyword default](#generics-and-the-keyword-default)
    - [Iterators](#iterators)
      - [The keyword yield](#the-keyword-yield)
      - [The return type of iterator methods](#the-return-type-of-iterator-methods)
      - [Multiple iterators](#multiple-iterators)



 

A first application
-------------------

The MS Visual Studio IDE provides wizards to help in creating various types of applications and libraries.

A Windows Forms application uses graphical user interface, that is windows, called forms, buttons, text boxes and other user interface elements like that.

A Console application does not use graphical user interface. It just displays its output to an instance of the terminal window (command prompt).

To create a new project, use the menu `File | New | Project` and then choose one of the available options.

#### Project folder tree

The folder tree of a project in disk is as following

    bin
        Debug
        Release
    obj
        Debug
        Release
    Properties

A solution, is a group of projects, and it may contain multiple projects.

Visual Studio works in two modes: Debug and Release.

The `bin` and `obj` folders are regenerated in each compilation. It is safe to delete them if they don't contain referenced assemblies or other resources.

The `.exe` to deploy is at `bin\Release\.exe`

The `Properties` folder contains source code related to resources and project configuration. Most of that code is kept synchronized by the IDE. The Properties folder is displayed by the IDE as the Properties section of a project.

### The various file extensions of a project source files

*   `.sln` solution file, a solution is a group of projects, an xml file
*   `.csproj` project file, an xml file
*   `.cs` source code file, C# code
*   `.resx` resource file, an xml file

### Solution Explorer window

`Solution Explorer (right click) | Properties`, displays the property dialog of the solution. `Solution Explorer | Project (rigth click) | Properties`, displays the property pages for the project.

### The References section in the Solution Explorer window

It's a list of the binary dependencies of a project. Each entry is a reference to an assembly required by the project. `References (right click) | Add Reference`, displays the add reference dialog.

### NuGet Packages

TODO

### A sample console program

    using System;
    using System.Windows.Forms;

    namespace Lessons
    {
        static class Program
        {
            static void Main(string\[\] args)
            {
                MessageBox.Show("Hi there!");
            }
        }
    }

The `using` directive imports types defined in other namespaces. For example the full name of the `MessageBox` class is `System.Windows.Forms.MessageBox`

The `using` directive "imports" the namespace `System.Windows.Forms` where `MessageBox` class belongs to, so there is no need anymore to fully qualify the name of the `MessageBox` class.

Namespaces are type containers.

Namespaces may form a tree by containing nested namespaces.

Namespaces is a way to organize types and avoiding name clashing.

A `using` directive enables unqualified use of types that are members of a namespace.

In the above example the Lessons namespace contains the class `Program`. The class `Program` contains a method called `Main()`. In other words, the class `Program` is a member of the `Lessons` namespace where the `Main()` method is a member of the `Program` class.

### Program.cs

Visual Studio IDE creates a `Program.cs` file when creating a new project. The `Program.cs` file contains the class `Program` and the `Main()` method of the project.

The `[STAThread]` element above the `Main()` is an attribute that marks the method.

The `Main()` method is a special method. It is the "entry point" of the application, the method that is called to begin execution. When `Main()` exits, the application terminates.

The `Application` class is the class that controls the execution of the application.

### Useful shortcut keys

*   `F5` starts debugging
*   `Ctrl + F5` starts without debugging
*   `F9` to set/unset a breakpoint. Breakpoints are used in debugging by forcing execution to stop when reaches a breakpoint.
*   `F10` for step
*   `F11` for step into
*   `F12` on a type name, displays the type declaration
*   `Ctrl + F` and
*   `Ctrl + Shift + F` to Find and Replace

### ildasm

A .Net compiler, such as `csc`, the C# compiler, produces an assembler-like code called IL, CIL (Common Intermediate Language) or MSIL (Microsoft Intermediate Language). It is that IL code the CLR (Common Language Runtime) executes.

The `ildasm` application displays the IL of an application.

For the .Net 3.5 and MS Visual Studio 2008 the `ildasm.exe` is found at `C:\Program Files\Microsoft SDKs\Windows\v6.0A\bin`

C# language elements
--------------------

This part examines the C# language. It describes the basic language elements, such as types, expressions, statements etc.

### Types, variables and constants

A type

*   has a unique name
*   defines the memory amount required for a variable of that type
*   defines a set or range of possible values
*   defines the legal operations on that values

Types are either **Value** types or **Reference** types.

**Value types** variables

*   Directly contain their data
*   Each one has its own copy of data
*   Operations on one cannot affect another

**Reference types** variables (act as pointers)

*   Store **references** to their data (known as objects)
*   Two reference variables can reference the same object (the same data)
*   Operations on one can affect another

#### C# built-in (or predefined) types

    C# Type      .NET Framework Type    Space                    Range 
    --------------------------------------------------------------------------------- 
    sbyte        System.SByte           8bit  signed             -128 to 127
    short        System.Int16           16bit signed             -32768 to 32767
    int          System.Int32           32bit signed             -2147483648 to 2147483647
    long         System.Int64           64bit signed             -9223372036854775808 to 9223372036854775807

    byte         System.Byte            8bit  unsigned           0 to 255
    ushort       System.UInt16          16bit unsigned           0 to 65535
    uint         System.UInt32          32bit unsigned           0 to 4294967295
    ulong        System.UInt64          64bit unsigned           0 to 18446744073709551615

    char         System.Char            16bit Unicode character  U+0000 to U+ffff

    float        System.Single          Single-precision         1.5 x 10^-45  to 3.4 x 10^38    7 digits        4 bytes 
    double       System.Double          Double-precision         5.0 x 10^-324 to 1.7 x 10^308   15-16 digits    8 bytes        
    decimal      System.Decimal         Precise decimal type     1.0 x 10^-28  to 7.9 x 10^28    28-29 digits   16 bytes

    bool         System.Boolean         boolean type             true or false 

    object       System.Object          The ultimate base type of all other types    
    string       System.String          a sequence of Unicode characters

#### User defined types

User defined types are defined by special keywords, syntax and notation. User defined types are the following types.

*   enum types ( Value type )
*   struct types ( Value type )
*   array types ( Reference type )

#### Reference types

Reference types are the following types.

*   string
*   array
*   class
*   interface
*   delegate

All other types are Value types.

#### All types inherit, directly or indirectly from System.Object.

`System.ValueType` descendants are Value types.

`System.Object` descendants which do not inherit from `ValueType` are Reference types.

Non-struct user defined Value types inherit from `System.ValueType` class.

CLR Value types are `struct` types, except of the `System.Enum` Value type which inherits from `ValueType` class.

There is a predefined `struct` for any system defined Value type, including `enum`.

Check online help for the `System.Array` class, `System.String` class and `System.Object` class.

#### Integral (ordinal) types

Integral (ordinal) are types that have **ordinality**. That is a value of an integral type has a next and a prior value, except of the first and the last value. Thus an integral type forms a sequence of values. CLR integral types are

*   sbyte
*   short
*   int
*   long

*   byte
*   ushort
*   uint
*   ulong

*   char

#### Unicode characters

The first 128 code points (0 to 127) of [Unicode](https://en.wikipedia.org/wiki/Unicode) correspond to the letters and symbols on a standard U.S. keyboard. These first 128 code points are the same as those the [ASCII](https://en.wikipedia.org/wiki/ASCII) character set defines. The second 128 code points (128 to 255) represent special characters, such as Latin-based alphabet letters, accents, currency symbols, and fractions. Unicode uses the remaining code points (256 to 65535) for a wide variety of symbols, including worldwide textual characters, diacritics, and mathematical and technical symbols.

#### Variables and constants

A Variable is a carrier of a value. That value may changes while the program executes.

##### Variable declaration syntax

    typeName  variableName;
    typeName  variableName = value;
    
    int x;
    int y = 0;    

Variable names start with a letter or underscore and can contain letters, numbers and underscores.

A variable may initialized along with its declaration.

A constant is like a variable, a carrier of a value. That value remains unchanged after its initialization.

##### Constant declaration syntax

    const typeName constantName = value;
    
    const int MaxValue = 100;

Constant names are governed by the same rules as with variables. A constant is always initialized along whith its declaration.

The value of a constant remains the same for the lifetime of the constant and it can not be changed.

The value of a constant must be computable at compile time.

Constants fields are impicitly static.

#### Literal values

Suffixes are used to clarify the type of a literal. Otherwise the compiler uses its internal rules to decide the type of a literal. Here is a list of the possible literal values.

    rererence types             null
    boolean                     true, false
    integer                     integer-type-suffixes (for both decimal and hexadecimal forms)
                                     U u L l UL Ul uL ul LU Lu lU lu
    hexadecimal integer         0x hex-digits, e.g. 0x00FF             
    float			float type suffixes
                                     F f D d M m
                                Scientific notation (E, e) e.g.  -2.5e-3   /\* = -0.0025 \*/

#### Character literals

A character literal represents a single character, and usually consists of a character in quotes, as in `'a'`. It can also have any of the following sequence forms

    simple-escape-sequence, one of
       \\' \\" \\\\ \\0 \\a \\b \\f \\n \\r \\t \\v
    hexadecimal-escape-sequence 
       \\x0000
    unicode-escape-sequence
        U+0032                                  

#### Character escape sequences

    Escape sequence            Character name        Unicode code point
    --------------------------------------------------------------------- 
    \\'                         Single quote          0x0027
    \\"                         Double quote          0x0022
    \\\\                         Backslash             0x005C
    \\0                         Null                  0x0000
    \\a                         Alert                 0x0007
    \\b                         Backspace             0x0008
    \\f                         Form feed             0x000C
    \\n                         New line              0x000A
    \\r                         Carriage return       0x000D
    \\t                         Horizontal tab        0x0009
    \\v                         Vertical tab          0x000B                            

#### String literals

There are **Regular** string literals and **Verbatim** string literals.

A regular string literal consists of zero or more characters enclosed in double quotes, as in `"hello, world"`, and can include both simple escape sequences (such as `\t` for the tab character), and hexadecimal and Unicode escape sequences.

A verbatim string literal consists of an `@` character followed by a double-quote character, zero or more characters, and a closing double-quote character.

@"hello, world"

In a verbatim string literal, the characters between the delimiters are interpreted verbatim, with the only exception being a quote-escape-sequence, which represents one double-quote character. In particular, simple escape sequences, and hexadecimal and Unicode escape sequences are not processed in verbatim string literals.

A verbatim string literal can span multiple lines.

@"A verbatim string literal
can span multiple lines."

#### Variable initialization

A Value or Reference type variable is considered unassigned until its first time assignment which is called **initialization**.

It is a compile time error to use an unassigned variable.

Value type variables may initialized by either

*   directly assigning a literal value
*   assigning an already initialized variable
*   or by calling their default constructor.

Calling the default constructor of a Value type, returns a so called default value.

  // Value type initialization
  int x;                  // no initialization 
  x = 1;                  // now it's initialized
  int y = 5;              // explicit initialization by using a literal value
  int z = y;              // initialization by using another variable  
  int i = new int();      // default initialization of a Value type by using the default constructor    

Regarding Reference types a constructor call creates a new instance of the class, called **object**.

A Reference type variable is initialized by either

*   a call to a constructor
*   or assigning an already initialized variable.

    // Reference type initialization
    Test T = new Test();    // in creating an object, a constructor call is always required
    Test T2 = T;            // T2 now points to the same object as T
    int\[\] a = new int\[3\];   // arrays are Reference types, this creates an array object with all of its elements having a default initialization    

Strings and Arrays are Reference types but can be initialized by using a syntax very closed to the one used with Value types.

    string S = "C sharp";
    int\[\] a = {1, 2 }; 

Besides that the string type (`System.String` class) provides many parameterized constructors.

    string S = new string(' ', 8);  // a string of 8 spaces

#### Blocks and scope

A block is a set of source code lines surrounded by curly braces.

    {
      // code goes here
    }

A block imposes a **name scope**.

The scope of a local variable/constant spans to the block that is declared and its children blocks. In other words, a local variable/constant is not visible outside the block it is declared.

A child block can not declare a variable or constant declared in a parent scope too.

    int i = 0;
    {
      int i = 0; // error, i is declared in a parent outer scope
    }

Sibling blocks may declare variables/constants of the same name.

    {
      int x = 0;
    }

    {
      int x = 0;  // ok, x is declared in a simbling block/scope
    }

### Expressions, Selection statements and Logical (boolean) operators

Code sentences are written in a syntax which utilizes expressions, statements and operators.

#### Operators

C# provides a rich set of operators.

    Equality           ==  != 
    Relational         <  >  <=  >=  is  
    Conditional        &&  || ^ ?: 
    Increment          ++
    Decrement          --
    Arithmetic         +  -  \*  /  % 
    Assignment         =  \*=  /=  %=  +=  -=  <<=  >>=  &=  ^=  |=

#### Expressions

Expession is a fragment of code that **evaluates and returns a value**. That value can be a single value, object, method, or namespace.

    int i = 1;
    string s = "hi there";
    
    int x = 5;
    int y = 8;
    
    i = x \* y / 2;

#### Statements

A statement

*   Is the building-block of an application.
*   It defines an algorithmic action.
*   Is is usually terminated by a semicolon.

A series of statements, surrounded by curly braces, form a block of code.

A statement may declare a local variable, assign a value to a variable, call a method, create an object, create a loop or make a decision and branch to a new block of code.

#### Selection statements

A selection statement makes a decision and branches to a new block of code.

There are two selection statments.

*   if
*   switch

#### Logical (or boolean) operators

    &&         AND     binary     returns True if both operands are True
    ||         OR      binary     returns True if either one or both operands are True
    !          NOT     unary      negates the operand. True becomes False and False becomes True
    ^          XOR     binary     returns True if only and only if one of operands are True

> **NOTE** : The `&&` operator evaluates its second operand if and only if the first operand is true (short-circuit evaluation)

Two of the bitwise operators can be used with boolean operands

    &          AND     binary      returns True if both operands are True
    |          OR      binary      returns True if either one or both operands are True

> **NOTE** : The `&` operator always evaluates both boolean operands (long-circuit evaluation)

#### Relational operators

    ==           equal
    !=           not equal

    <            lesser
    >            greater
    <=           lesser or equal
    >=           greater or equal

### Iteration statements or Loops

Iteration statements are blocks of code which executed repeatedly. The common term is **loop**. C# supports four loop types

    for
    while
    do
    foreach

Loop statements iterate a block of statements as long as a condition stands true. The condition is re-evaluated after each iteration. If the condition is not true the loop terminates and execution is transferred to the next line after the last line of the loop code block.

#### for

The format definition of the `for` statement is

    for ( initialization expression ; conditional expression ; loop expression )
          statement

Here is an example

    for (int i = 0; i < 5; i++) 
    {
        DoSomething();              // this will be executed 5 times
    }    

The `for` loop is controlled by a conditional expression. It is executed while that conditional expression evaluates to `true`.

The `for` loop won't executes at all if that condition is not true.

The `for` loop may contain zero or more initialization expressions delimited by commas. An initialization expression gives initial values to one or more variables.

The `for` loop may contain zero or more loop expressions delimited by commas. A loop expression assigns new values to one or more variables in each iteration.

#### while

The format definition of the `while` statement is

    while ( conditional expression )
          statement

Here is an example

    int i = 0;
    
    while (i < 5)
    {
        DoSomething();      // this will be executed 5 times
        i++;
    }   

The `while` loop is controlled by a conditional expression. It is executed `while` that conditional expression evaluates to `true`.

The `while` loop won't executes at all if that condition is not `true`.

#### do-while

The format definition of the `do-while` statement is

    do
          statement
    while ( conditional expression ) ;

Here is an example

    int i = 0;
    
    do
    {
        DoSomething();      // this will be executed 5 times
        i++;
    } while (i < 5);

The `do-while` loop is controlled by a conditional expression found at the end of the loop statement.

The `do-while` loop executes at least once. It then continues to executed as long as its conditional expression evaluates to `true`.

#### foreach

The format definition of the `foreach` statement is

    foreach (Variable in IEnumerable expression)
            statement

Here is an example

    int\[\] numbers = int\[\] {1, 2, 3, 4, 5};
    
    foreach (int n in numbers)
    {
        DoSomething(n);         // this will be executed 5 times
    }

The `foreach` statement works in conjunction with a so called **"iterator"**.

For an object to be used as an iterator it is required to implement the `IEnumerable` interface.

A `foreach` statement continues execution as long as its iterator has a next value to provide.

Arrays are iterators by default, as most of the list classes and so they can be used with `foreach` statements.

#### break statement

A `break` statement forces a loop to terminate.

    for (int i; i < 5; i++)
    {
        if (i == 2)         
            break;
            
        DoSomething(i);     // this will be executed 2 times
    }

> **NOTE** : a `return` statement exits a method and may be used to `break` a loop execution too if it is placed inside a loop statement.

    void LoopMethod()
    {
        for (int i; i < 5; i++)
        {
            if (i == 2)         
                return;         // breaks the loop and exits the method
                
            DoSomething(i);     // this will be executed 2 times
        }
    }

#### continue statement

A `continue` statement forces the loop to not execute the rest lines to the end of the loop and go for the next iteration.

    for (int i; i < 5; i++)
    {
        if (i == 2)         
            continue;
            
        DoSomething(i);     // this will not be executed at the 3 iteration
    }

### Implicitly Typed Local Variables: The keyword var

Using the keyword `var` makes it possible to declare a local variable without specifying its type and let compiler conclude the actual type by the value which initializes that variable.

    var i = 123;
    var s = "C sharp";
    var b = false;
    var d = 1.2;
    var a = new\[\] { 1, 2, 3 };
    var a2 = new\[\] { "Hi", "there" }; 

It is not legal to declare an impliticly typed local variable without initialization.

    var x; // Error: Implicitly-typed local variables must be initialized    

It is not legal to use `var` in declaring class or `struct` fields. Just local variables.

    public class Test
    {
        var i = 0;    // not valid
    } 

The `var` keyword can be used

*   in local variables
*   in `for` statements
*   in `foreach` statements
*   in `using` statements

### Nullable types

A nullable type is a Value type based on an underlying Value type.

The range of the possible values of a nullable type contains the possible values of the underlying type **plus** a `null` value.

> **NOTE** : `null` is a constant defined by the system and denotes a not-existing memory value (null pointer)

Nullable types are instances of the generic `System.Nullable(T)` struct type.

#### Declaring nullable types

A variable of a nullable type is declared by using the `?` modifier after the name of the underlying Value type.

    int? i = null;

It is not valid to declare a nullable type for a Reference type. Reference types already support the null value;

    object? o = null;  // ERROR: not valid

> **NOTE** : C# 8.0 introduces nullable Reference types

The assignment of a nullable type is exactly the same as for any other Value type;

    int? i = null;
    i = 123;
    i++; 

#### A nullable type has members

Since a nullable type is a `System.Nullable(T)` struct type it has its own properties and methods.

The property `HasValue` is of type `bool`. It returns `true` when the variable contains a non-null value.

The property `Value` is of the same type as the underlying type. If `HasValue` is `true`, `Value` returns a valid value. If `HasValue` is `false`, accessing `Value` throws an `InvalidOperationException`.

    bool? a = null;
    bool b;

    if (a.HasValue)
        b = a.Value;
    else
        b = false;

The method `GetValueOrDefault()` returns a value of the same type as the underlying type.

If `HasValue` is `true`, `GetValueOrDefault()` returns `Value`, else returns the default value of the type.

    bool? a = null;
    bool b = a.GetValueOrDefault();    

#### Nullable type convertions

It is possible to cast a nullable to a normal type and the opposite.

    int? i = 123;
    //int x = i;       // Error : Cannot implicitly convert type 'int?' to 'int'. An explicit conversion exists (are you missing a cast?)
    int x = (int)i;    // explicit convertion, will throw an exception if the nullable type is null

    x = 345;
    i = x;             // implicit convertion, a non-nullable is converted to a nullable type, it always succeds     

#### Nullable type operators

Operators that are considered legal for the underlying type, can be used with the nullable type too.

    int? x = 100;           

    // any valid operator may be used
    x++;
    x += 1;
    x /= 2;
    x = x \* 2;            

As a general rule, if a single operand is `null` the whole expression returns `null.`

    int? y = null;
    x = x + y + 20;              // x is null here  

> **CAUTION** : The `&` and `|` bitwise operators when used with boolean nullable types return `null` if any of the operands is `null`.

    bool? b = null;
    bool a = (true & b) == true;   // a will always be false here because b is null

#### The ?? operator

Syntax:

    Result = ValueToEvaluate ?? DefaultValue;

The `??` operator returns the left operand if it is not `null`, else returns the right operand

    int? x = null;
    int y = x ?? 123;

### Casting, convertions and boxing

Values can be converted to values of another type by using **casting** and data convertion. **Boxing** is a special convertion type in which a Value-type value is converted to an object and the opposite.

#### Casting

**Casting** or **typecasting** is a term wich describes the convertion of an expression of one type into a value of another type, by using a special syntax.

    int i = 0;
    long n = (long)i;

Casting is governed by special language rules and is not always allowed by the compiler.

    int i = 0;
    bool b = (bool)i;    // Error: Cannot convert type 'int' to 'bool'	    

Casting is used in data convertions.

#### Data convertion

A conversion enables an expression of one type to be treated as a value of another type.

A convertion is called **implicit** if requires no casting.

A convertion is called **explicit** if requires casting.

For example, an implicit convertion from `int` to `long` it always succeeds, and never results in a loss of information.

    int i = 0;
    long n = i;

#### checked and unchecked statements

Arithmetic operations and convertions can execute in either checked or unchecked context.

In a checked context, arithmetic overflow raises an exception.

In an unchecked context, arithmetic overflow is ignored and the result is truncated.

The `/checked` compiler option lets you specify checked or unchecked context for all integer arithmetic statements that are not explicitly in the scope of a `checked` or `unchecked` keyword.

The `checked` keyword explicitly enables overflow checking in arithmetic operations and type convertions. It defines a block or context where arithmetic overflow raises an exception.

    checked
    {
       int i = long.MaxValue;
    }

    int j = checked(int.MaxValue + 10);

The `unchecked` keyword disables overflow checking in arithmetic operations and type convertions. It defines a block or context where arithmetic overflow does not raise an exception.

    unchecked
    {
       int i = long.MaxValue;
    }

    int j = unchecked(int.MaxValue + 10);

#### is and as operators

The `is` operator returns `true` if an object is not `null` and compatible with a given type, `false` else.

The `as` operator casts an expression of one Reference type to a value of another **compatible** Reference type.

If the conversion is not possible, `as` returns `null` instead of raising an exception.

    if (sender is Button)
      MessageBox.Show((sender as Button).Text);

#### typeof operator and GetType() method

The `typeof` operator returns a `System.Type` object of the passed type.

    Type T = typeof(bool);

The virtual method `System.Object.GetType()` has the same result when it is called on an instance

    Type T = sender.GetType();

The `System.Type` class represents the declaration of a type and provides many useful type information.

#### sizeof operator

The `sizeof` operator returns the size in bytes of the passed **Value** type.

    int i = sizeof(ulong);

#### the ?: conditional operator

The conditional operator `?:` returns one of two values depending on the value of a Boolean expression.

The conditional operator is of the form

    condition ? first\_expression : second\_expression;    

Here is an example.

    int i = 1 > 2 ? 3 : 4;   // i equals 4 here

#### Operator precedence

When an expression contains multiple operators, the precedence of the operators controls the order in which the individual operators are evaluated.

Divisions and multiplications are evaluated first and then additions and subtractions.

To control the order of execution use parentheses.

    double V = 4 + 4 / 2;   // V becomes 6

    V = (4 + 4) / 2;        // V becomes 4

#### Boxing and unboxing

**Boxing** is an implicit conversion of a Value type to the type `System.Object` or to any interface type implemented by this Value type. Boxing a Value type allocates an object instance on the heap and copies the value into the new object.

**Unboxing** is an explicit conversion from the type `System.Object` to a Value type or from an interface type to a Value type that implements the interface.

Boxing/Unboxing is not supported on nullable types.

    int i = 100;        // a Value type
    object Obj = i;     // boxing
    int x = (int)Obj;   // unboxing 

### Comments

C# supports single and multi-line comments.

    // single line comment

    /\*
      multi-line comment
    \*/    

A single-line comment can be placed either in a line alone or after a line of code.

    // increment the i
    i++;
    
    ...    
    
    i++;  // increment the i

A multi-line comment can be placed anyhwere, even in the middle of a code line.

    /\* increment the i \*/
    i++;
    
    ...    
    
    i++;  /\* increment the i \*/
    
    ...
    
    if (1 > 2 /\* is this possible?\*/ )
    {
    }

#### TODO comments

By starting a comment with the word `TODO`

   // TODO complete this method

places that comment in a special Task List. That list is accessed from menu `View | Task List`

#### XML Documentation Comments

The Visual Studio IDE automatically places a comment template above any code element (type, class, method, property, etc) when typing three slashes, i.e. `///`

    /// <summary>
    ///
    /// </summary>
    public MainForm()
    {
        InitializeComponent();
    }
   
    /// <summary>
    ///
    /// </summary>
    /// <param name="S"></param>
    /// <param name="Form"></param>
    /// <returns></returns>
    public int GetSomeInfo(string S, Form Form)
    {
    }

There is a whole group of supported elements tags and attributes the IDE recognizes, such as

    <summary>
    <param>
    <returns>

    <code>
    <example>

    <remarks>
    <seealso>

More information on those elements and attribute can be found in online documentation.

##### Documentation generation

The IDE generates an xml file which includes all the comments.

Go to `Solution Explorer | (right click) | Properties | Build | Output` and check the XML documentation file check box providing a filename.

To turn that XML documentation file into a usable documentation use a tool such as the freeware NDoc tool. 

*   *   [http://ndoc.sourceforge.net/](http://ndoc.sourceforge.net/)

### C# conditional preprocessor directives

Conditional preprocessor directives are used in conditional compilation.

Although C# compiler does not have a separate preprocessor the directives are processed as if there was one.

To define a user defined directive

    #define NET\_CF                 

The `#define` directive defines a symbol, in the above case `NET_CF`.

Directives defined by `#define` should be at the top of the source document. You can not use the `#define` directive to define constants and macros as in C/C++.

To undefine the same symbol

    #undef NET\_CF        

Defined symbols are used in conditional compilation.

The directives `#if`, `#elif`, `#else` and `#endif` are used to check if a symbol is defined

    #if NET\_CF
       // Compact Framework specific code  
    #else
       // normal .Net code here
    #endif

Conditional compilation may also achieved by using the `ConditionalAttribute` attribute. See documenation for more info.

You can not assign a value to a defined symbol (as in C/C++).

The scope of a symbol created by using `#define` is the file in which it is defined.

To define a symbol having an application scope you use the `/define` compiler option or the `Solution Explorer | (right click) | Properties | Build | General | Conditional compilation symbols` text box.

#### Other directives

The `#region` directive specifies a block of code that can be expanded or collapsed in the code editor of the IDE. The `#endregion` marks the end of that block

    #region 
    void Method1() {}
    void Method2() {} 
    #endregion

    #warning generates a level one warning 
    #error generates an error
    #pragma warning enables and disable certain warnings.

### Exceptions

An exception is a special instance (object) that is created by the the .Net runtime or user code in a case of an error.

An Exception object denotes an error.

Code that might throw exceptions should be placed in a `try-catch` block.

The `catch` part of the block is where exceptions are trapped and handled.

    try
    {
       // guarded application code
    }
    catch
    {
        // exception handling code
    }

If a line of code throws an exception, then any existing lines, next to that line, are not executed.

If the line of a code found inside a `try-catch` block throws an exception, then execution control is transfered to the `catch` part of the block. That exception is considered "catched", that is handled.

An unhandled exception goes out of the block caused the exception, until to find and appropriate `catch` block.

If an exception goes unhandled, which is the case when there is not any outer `catch` block, then it may reach the `Main()` method. In that case the operating system terminates the execution of the application.

#### Exceptions are classes

Exceptions are classes that form a hierarchy. The ultimate ancestor of exceptions is the Exception class.

                                Exception
      SystemException                          ApplicationException
      OutOfMemoryException
      NullReferenceException

It is possible to have custom user exception classes defined. A user exception should inherit the `ApplicationException` class or any descendant of it.

#### The finally part

A `try` block may optionally contain a `finally`part. Thus it may have the form

    try-catch-finally
    try-finally

The `finally` part is always executed even if an exception is thrown into the `try` block.

The `finally` part is used for clean-up and finalization purposes.

    try
    {
       // guarded application code
    }
    catch
    {
        // exception handling code
    }
    finally
    {
        // always executed code
    }

or

    try
    {
       // guarded application code
    }
    finally
    {
        // always executed code
    }

#### Trapping unhandled user interface exceptions

The `Application` object offers a way to trap otherwise unhandled exceptions caused by user interface threads. It is the `Application.ThreadException` event of type `System.Threading.ThreadExceptionEventHandler` which is defined as

    public delegate void ThreadExceptionEventHandler(object sender, ThreadExceptionEventArgs e);

The best place to place a generic exception handler is the `Main()` method in the `Program` class

    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false); 

        /\* adding a main exception handler method which is going to handle any unhandled exception
           thrown from inside any of the UI threads, NOT any other thread \*/
        Application.ThreadException += new ThreadExceptionEventHandler(MainExceptionHandler);

        /\* forcing all UI exceptions go throur the newly installed main exception handler \*/
        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

        Application.Run(new MainForm());
    }

    static void MainExceptionHandler(object sender, ThreadExceptionEventArgs e)
    {
        MessageBox.Show("Hi from MainExceptionHandler. An exception is thrown: " + Environment.NewLine + e.Exception.Message);
    }

> **CAUTION**: Exceptions caused by other threads are not handle by this generic handler.

Special types
-------------

This part describes some "special" types such as the `Enum`, `Array` and `String` type and the various `List` and `Collection` types.

### Enum types

An **enumeration** type is a group of constants.

    enum Day {Sun, Mon, Tue, Wed, Thu, Fri, Sat};         

An enumeration type has an underlying integer type which can be of any integer type except of the `char` type.

The default underlying type is `int`.

Each constant in the group of constants may have an integer value.

By default, the first constant has the value 0, the second 1 and so on.

It is possible to override those default integer values

    enum Day {Sun = 1, Mon = 2, Tue = 3, Wed = 3, Thu, Fri, Sat};

If you not define an integer value for a constant, it is assigned one, depending on the ordinality of the constant. For example `Fri = 5` above.

To override the default underlying `int` type use a type designator.

    enum Day: byte  {Sun, Mon, Tue, Wed, Thu, Fri, Sat};       

To declare a variable and assign a value

    Day D = Day.Wed;

A variable of an `enum` type can be assigned any value that is considered a valid value for the underlying integer type. That is, possible values are not limited to the group of constants the `enum` type declares.

The default value of an `enum` type named `EnumTypeName` is `(EnumTypeName)0`

The `System.Enum` class is the base type for all `enum` types. It provides many useful utility methods.

#### Sets (bit-fields)

A set type is a data type which defines a collection of values of the same base type.

C# does not provide a set type but we can simulate set variables.

By applying the `FlagsAttribute` attribute to an `enum` type and by assigning values of powers of two (0, 1, 2, 4, 8 and so on) to its constants we convert the `enum` type into a **bit-field**, that is a set of flags.

    \[Flags\]
    enum Day {Sun = 0, Mon = 1, Tue = 2, Wed = 4, Thu = 8, Fri = 16, Sat = 32 };
    
    Day WeekEnd = Day.Sat | Day.Sun; // a "set"

    Day WorkDays = Day.Mon | Day.Tue | Day.Wed | Day.Thu | Day.Fri ; // a "set"    

It is not meaningful for a value to be included twice in a set, although it is not an error if you do that.

There are some operations we can apply to sets:

*   **Union** is the construction of a new set which contains the elements of two other sets.
*   **Subtraction** is the construction of a new set which contains the elements of a set after subtracting the elements of another set
*   **Intersection** is the construction of a new set which contains just the common elements of two other sets.
*   **Difference** is the construction of a new set which contains the not common elements of two other sets.
*   **Membership** is a check operation that results in true if a set A is a subset of a set B.

In order to simulate sets, we just apply bit-masking to enum values. Here are those operations.

    C = A | B                           // Union
    C = A & B                           // Intersection
    C = A ^ B                           // Difference
    C = A ^ (A & B)                     // Subtraction
    bool Result = (A & B) == A          // Membership

### Arrays

An array is a sequence of elements of the same type.

Individual elements are accessed by using integer indexes. The first index is 0, the second 1 and so on.

An array may have more than one dimension (rank).

To declare an array variable

    DataType\[\] VariableName;

An example for an `int` array variable

    int\[\] numbers;

To declare an `int` array with 2 dimensions (rank 2)

    int\[,\] numbers;

To declare a single-dimensional array with 5 elements

    int\[\] numbers = new int\[5\];

To declare the same array and set its element values using an initializer

    int\[\] numbers = new int\[\] { 1, 2, 3, 4, 5 };   

Alternatively, you may omit the new operator and the array size definition when initializing element values

    int\[\] numbers = { 1, 2, 3, 4, 5 };  

To declare a 2-dimensional int array with 2 Rows and 3 Columns

    int\[,\] twoDimNumbers = new int \[2, 3\];    

To initialize elements of a 2-dimensional array

    int\[,\] twoDimNumbers = {   { 1, 2, 3 }, 
                               { 4, 5, 6 } 
                             };                                  

#### Accessing array elements

    int x = numbers\[0\];         // x = 1 
    x = twoDimNumbers\[0, 0\]     // x = 1
          
    int x = numbers\[3\];         // x = 4 
    x = twoDimNumbers\[0, 2\];    // x = 3    

    numbers\[1\] = 123;
    twoDimNumbers\[0, 1\] = 456;

#### Arrays are Reference types.

The declaration of an array does NOT create the array. You must use the new operator or use an initializer in order to create the instance of the array.

The default element values of an un-initialized array are

*   zero for numbers
*   false for booleans
*   empty string for strings
*   and null for objects and other Reference types

Assigning an array variable to another makes both variables pointing to the same array instance (object) in memory. It does NOT create copy of the array. The `Array` class is the base class all arrays inherit from. The `Array` class provides many usefull methods for handling arrays.

The method

    public int GetLength(int dimension)

of the `Array` class returns the length of an array dimension.

To get the length of single-dimensional array, use

    int\[\] numbers = { 1, 2, 3, 4, 5 };
    int i = numbers.GetLength(0); 

To get the length of the two dimensions of two-dimensional array

    int\[,\] twoDimNumbers = {   { 1, 2, 3 }, 
                               { 4, 5, 6 } 
                            };
                            
    int Rows    = twoDimNumbers.GetLength(0);
    int Columns = twoDimNumbers.GetLength(1);   

The property `Length` of the `Array` class returns the total number of elements in all the dimensions of an array

    int Len = twoDimNumbers.Length; // Len = 6 here    

#### Commonly used array methods

    Sort()              sorts the elements in one-dimensional Array objects
    Clear()             sets a range of elements in the Array to zero, to false, depending on the element type.
    Clone()             creates a shallow copy of the Array.  
    Copy() 
    and CopyTo()        copies a range of elements in one Array to another Array 
    IndexOf()           gets the index of the first occurrence of a value in a one-dimensional Array

#### Arrays and methods

A method can return an array

    public int\[\] GetArray()
    {
        return new int {5, 6, 7};
    }


    int\[\] x = GetArray();

An array argument passed to a method is a reference to an array instance, **not** a copy of the array.

    int\[\] numbers = new int\[\] { 1, 2, 3, 4, 5 };   

    public void HandleArray(int\[\] A)
    {
       A\[0\] = 9;
    }

    // numbers\[0\] = 9 now

#### Jagged Arrays

A jagged array is an array of arrays, that is the elements of a jagged array are arrays. The element arrays of a jagged array can be of a varying length.

Declaring a jagged array

    int\[\]\[\] jagged = new int\[3\]\[\];

Declaring the elements of a jagged array

    jagged\[0\] = new int\[4\];
    jagged\[1\] = new int\[3\];
    jagged\[2\] = new int\[5\];

Declaring and initializing a jagged array

    jagged\[0\] = new int\[\] { 1, 2, 3, 4 };
    jagged\[1\] = new int\[\] { 5, 6, 7 };
    jagged\[2\] = new int\[\] { 8, 9, 10, 11, 12 };

Accessing jagged array elements

    int x = jagged\[1\]\[2\];  // x = 7

See documentation for more information on creating, initializing and using jagged arrays.

### Strings

A C# string is a Reference type.

A string is a read only array of characters that is declared by using the `string` keyword.

    string S;
    string S2 = "Hi there";

﻿It is possible to create a new string by using the concatenation operators `+` and `+=`

    string S = "Hi" + " there";

The equality operators `==` and `!=` also work on strings.

    string S2 = "Hi there";
    
    bool a = (S == S2);
    bool b = (S != "Hi there")   

Accessing a string as an array of characters

    for (int i = 0; i < S.Length; i++)
        S2 += S\[i\].ToString() + Environment.NewLine;

#### The empty string

An empty string represents a blank text field. It is valid to call methods on empty strings because they are valid `System.String` objects.

    string S = "";
    string S2 = string.Empty;

    if ((S == string.Empty) && (S2 == string.Empty))
        MessageBox.Show("both strings are empty");

#### The null string

A `null` string does not refer to an instance of `System.String` class.

Calling a method on a `null` string causes a `NullReferenceException`.

Besides that it is valid to use `null` strings in concatenation and comparison operations with other strings.

    string S = "Hi there";
    string S2 = null;

    // concatenating a string and a null string
    S = S + S2; 
    
    // comparing an empty string to a null string returns false
    S = "";
    bool b = S == S2;

The `IsNullOrEmpty()` static method returns `true` if a string is null or empty

    if (string.IsNullOrEmpty(S2))

﻿The `IsNullOrWhiteSpace()` static method returns `true` if a string is null, empty, or consists only of white-space characters.

    if (string.IsNullOrWhiteSpace(S2))

#### The System.String class

The `System.String` class provides many useful instance or static methods for comparing, splitting, trimming, padding, concatenating and many other string related tasks.

#### The StringBuilder class

The `StringBuilder` class represents a mutable string.

    public sealed class StringBuilder : ISerializable
    {
        public StringBuilder();
        public StringBuilder(int capacity);
        public StringBuilder(string value);
        public StringBuilder(int capacity, int maxCapacity);
        public StringBuilder(string value, int capacity);
        public StringBuilder(string value, int startIndex, int length, int capacity);

        public int Capacity { get; set; }
        public int Length { get; set; }
        public int MaxCapacity { get; }

        public char this\[int index\] { get; set; }

        public StringBuilder Append(bool value);
        public StringBuilder Append(byte value);
        public StringBuilder Append(char value);
        public StringBuilder Append(char\[\] value);
        public StringBuilder Append(decimal value);
        public StringBuilder Append(double value);
        public StringBuilder Append(float value);
        public StringBuilder Append(int value);
        public StringBuilder Append(long value);
        public StringBuilder Append(object value);
        public StringBuilder Append(sbyte value);
        public StringBuilder Append(short value);
        public StringBuilder Append(string value);
        public StringBuilder Append(uint value);
        public StringBuilder Append(ulong value);
        public StringBuilder Append(ushort value);
        public StringBuilder Append(char value, int repeatCount);
        public StringBuilder Append(char\[\] value, int startIndex, int charCount);
        public StringBuilder Append(string value, int startIndex, int count);
        public StringBuilder AppendFormat(string format, object arg0);
        public StringBuilder AppendFormat(string format, params object\[\] args);
        public StringBuilder AppendFormat(IFormatProvider provider, string format, params object\[\] args);
        public StringBuilder AppendFormat(string format, object arg0, object arg1);
        public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2);
        public StringBuilder AppendLine();
        public StringBuilder AppendLine(string value);
        public void CopyTo(int sourceIndex, char\[\] destination, int destinationIndex, int count);
        public int EnsureCapacity(int capacity);
        public bool Equals(StringBuilder sb);
        public StringBuilder Insert(int index, bool value);
        public StringBuilder Insert(int index, byte value);
        public StringBuilder Insert(int index, char value);
        public StringBuilder Insert(int index, char\[\] value);
        public StringBuilder Insert(int index, decimal value);
        public StringBuilder Insert(int index, double value);
        public StringBuilder Insert(int index, float value);
        public StringBuilder Insert(int index, int value);
        public StringBuilder Insert(int index, long value);
        public StringBuilder Insert(int index, object value);
        public StringBuilder Insert(int index, sbyte value);
        public StringBuilder Insert(int index, short value);
        public StringBuilder Insert(int index, string value);
        public StringBuilder Insert(int index, uint value);
        public StringBuilder Insert(int index, ulong value);
        public StringBuilder Insert(int index, ushort value);
        public StringBuilder Insert(int index, string value, int count);
        public StringBuilder Insert(int index, char\[\] value, int startIndex, int charCount);
        public StringBuilder Remove(int startIndex, int length);
        public StringBuilder Replace(char oldChar, char newChar);
        public StringBuilder Replace(string oldValue, string newValue);
        public StringBuilder Replace(char oldChar, char newChar, int startIndex, int count);
        public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count);
        public override string ToString();
        public string ToString(int startIndex, int length);
    }

The `StringBuilder` class permits read-write access to individual charactes.

The `StringBuilder` class receives special treatment from the compiler.

Use the `StringBuilder` class in place of the `string` type anytime massive operations on strings are going to be performed since it is faster than the `string` type and it uses the memory in a more compact way.

### The DateTime struct type

`DateTime` is defined as a struct. That is `DateTime` is a Value type.

`DateTime` is used to express an instant of time. `DateTime` contains both date and time information.

The `DateTime` may contain values ranging from 12:00:00 midnight, January 1, 0001 Anno Domini (Common Era) to 11:59:59 P.M., December 31, 9999 A.D. (C.E.)

`DateTime` values are measured in ticks. A tick is a 100-nanosecond unit. A DateTime value is the number of ticks passed since 12:00 midnight, January 1, 0001 A.D. (C.E.) in the default calendar, which is the `GregorianCalendar` calendar.

A `DateTime` value is always expressed in the context of an explicit or default calendar. It is possible to initialize a `DateTime` variable to any of the available calendars by using a `DateTime` constructor which gets a calendar as a parameter. `System.Globalization.Calendar` class is the base class for Calendars.

The Bace Class Library (BCL) provides calendars such as the following

    System.Globalization.EastAsianLunisolarCalendar
    System.Globalization.GregorianCalendar
    System.Globalization.HebrewCalendar
    System.Globalization.HijriCalendar
    System.Globalization.JapaneseCalendar
    System.Globalization.PersianCalendar
    System.Globalization.JulianCalendar
    System.Globalization.KoreanCalendar
    System.Globalization.TaiwanCalendar
    System.Globalization.ThaiBuddhistCalendar
    System.Globalization.UmAlQuraCalendar

The read-only property `DateTime.Kind` returns a `DateTimeKind` enum value indicating the kind of time that `DateTime` is based on. `DateTimeKind` enum type is defined as

*   **Unspecified**. The time represented is not specified as either local time or Coordinated Universal Time (UTC).
*   **Utc**. The time represented is UTC.
*   **Local**. The time represented is local time.

The `DateTime` struct provides special constructors which get a `DateTimeKind` value as a paramerer.

Coordinated Universal Time (UTC) is an international time standard. UTC is the time as measured at zero degrees longitude, which is the UTC origin point. Greenwich Mean Time (GMT) is the old standard replaced by UTC.

International standards devide earth into special zones called time zones. A time zone has a uniform standard time which is called the **local time**. Local time is relative to UTC and is associated with a time zone offset. That is a time zone computes its local time as an offset from UTC. The time zone offset at the UTC origin point is zero.

Daylight saving time (summer) is not applicable to UTC. Optionally a local time may affected by daylight saving time (summer). Daylight saving adds or subtracts an hour from the duration of a day. see also:

*   [http://msdn.microsoft.com/en-us/library/ms973825.aspx](http://msdn.microsoft.com/en-us/library/ms973825.aspx)
*   [http://blogs.msdn.com/bclteam/archive/2004/05/21/136918.aspx](http://blogs.msdn.com/bclteam/archive/2004/05/21/136918.aspx)
*   [http://blogs.msdn.com/brada/archive/2004/04/13/112784.aspx](http://blogs.msdn.com/brada/archive/2004/04/13/112784.aspx)

#### Initializing a DateTime value

The most common way is to use the static `DateTime.Now` or `DateTime.Today` property both of which return a local time value

    DateTime DT = DateTime.Now;
    DateTime DT = DateTime.Today;

Another common way is to use one of the parameterized constructors of the `DateTime` struct, passing year, month, day etc. values you want to be encoded

    DateTime DT = new DateTime(1999, 12, 31);

or use a call to the static `DateTime.Parse()` method

    DateTime DT = DateTime.Parse("1999-12-31");

#### TimeSpan class

The `System.TimeSpan` class, is quite similar to the `DateTime` struct, represents a time interval. `TimeSpan` is used in many situations but mostly when adding or subtracting `DateTime` values.

#### Other classes related to date and time

The BCL provides a set of date and time related classes.

*   `DateTimeOffset` class
*   `TimeZoneInfo` class
*   `DaylightTime` class
*   `DateTimeFormatInfo` class
*   `DaylightTime` class
*   `DateTimeStyles` Enumeration

### Lists and Collections

Lists and collections are ordered groups of elements.

Unlike arrays, lists and collections may grow and shrink at will. New elements may be added and old elements may be altered or deleted.

In general lists are groups of heterogenous elements while collections are groups of homogenous elements. This distinction may not be that clear since an element of type `object` may represent almost anything and almost anything can cast to an object.

Lists and collections provide some methods and properties common to both categories although not all these classes belong to the same hierarchy.

An `Add(),` a `Remove()` and a `Clear()` method is provided in most cases.

A `RemoveAt(int Index)` and an `IndexOf()` method is provided by indexed list and collection classes.

Also properties like `Count`, `IsSynchronized`, `SyncRoot`, `IsFixedSize` and `IsReadOnly` are also present in most cases.

**Syncronization** is a term wich refers to thread safety.

Accessing elements in a list or collection is not thread safe by default. A few classes provide a `Syncronize()` method which creates a thread safe wrapper around the instance and returns it.

All list and collection classes provide the `SyncRoot` property which can be used in providing thread safe access, along with the `IsSynchronized` property.

Also some list and collection classes can generate read only or fixed size wrapper objects.

And since all of these list and collection classes implement the `IEnumerable` interface, they can be used with the foreach statement.

> **NOTE** : Generic lists and collections are not included in this description.

#### Commonly used list and collection related interfaces

List and collection classes implement a host of interfaces. Next will examine some of the most common of them.

An `IEnumerator` is returned by an `IEnumerable` object. An `IEnumerator` is an object that provides the facility to iterate the elements of the object it represents. `IEnumerator` is an old citizen of the COM universe.

For an object to be part of a foreach statement it has to implement the `IEnumerator` interface.

    public interface IEnumerator
    {
        object Current { get; }   // Gets the current element in the collection.
        bool MoveNext();          // Advances the enumerator to the next element of the collection.
        void Reset();             // Sets the enumerator to its initial position, which is before the first element in the collection.
    }

`IEnumerable` is implemented by classes as a mean to provide an `IEnumerator` object.

    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }

`IClonable` is implemented by classes as a mean to clone themselves, that is to provide a new instance with the same state (value) as the existing instance.

    public interface ICloneable
    {
        object Clone();
    }

`ICollection` represents a collection object.

    public interface ICollection : IEnumerable
    {
        int Count { get; }                      // Gets the number of elements
        bool IsSynchronized { get; }            // Gets a value indicating whether access to this instance is thread-safe
        object SyncRoot { get; }                // Gets an object that can be used to synchronize access to this instance
        
        void CopyTo(Array array, int index);    // Copies the elements of this instance to a System.Array object
    }

`IList` represents a collection of objects that can be accessed by index using an array notation

    public interface IList : ICollection, IEnumerable
    { 
        bool IsFixedSize { get; }               // return true if this is a fixed-size object
        bool IsReadOnly { get; }                // return true if this is a read-only object
        object this\[int index\] { get; set; }    // Gets or sets the element at the specified index.
        
        int Add(object value);                  // Adds an item to the list
        void Clear();                           // Removes all items
        bool Contains(object value);            // Returns true if this instance contains the specified value.
        int IndexOf(object value);              // Returns the index of the specified value in the list, -1 if not found
        void Insert(int index, object value);   // Inserts an item to list at the specified index.
        void Remove(object value);              // Removes the first occurrence of a specific object from the list
        void RemoveAt(int index);               // Removes the item at the specified index.
    }

#### ArrayList class

`System.Collections.ArrayList` class is a ...classic class. It represents a balance between a list and a collection. It implements `IList`, `ICollection`, `IEnumerable` and `IClonable`.

The element type of the `ArrayList` is `System.Object` which means that any type can be used as an item.

`ArrayList` can be sorted. It provides a `Sort()` method. It also can be reversed or copied to an `array`. The static `ArrayList.Adapter(IList list)`  can convert to an `ArrayList` any type which implements the `IList` interface such as an array or another list or collection.

#### Hashtable Class and dictionaries

A **dictionary** is a list class where each element is a key/value pair.

The terms **dictionary**, **map** and **associative array** denote the same thing: a class where each element is a key/valuepair.

`System.Collections.Hashtable` implements `IDictionary`.

    public interface IDictionary : ICollection, IEnumerable
    {
        bool IsFixedSize { get; }
        bool IsReadOnly { get; }
        ICollection Keys { get; }
        ICollection Values { get; }
        
        object this\[object key\] { get; set; }

        void Add(object key, object value);
        void Clear();
        bool Contains(object key);
        IDictionaryEnumerator GetEnumerator();
        void Remove(object key);
    }

Each element in a `Hashtable` must have a unique non-null key and is stored as a `DictionaryEntry` struct object.

    public struct DictionaryEntry
    {
        public DictionaryEntry(object key, object value);

        public object Key { get; set; }
        public object Value { get; set; }
    }
    
    ...

    Hashtable ht = new Hashtable();
    ...
    
    foreach (DictionaryEntry de in ht) 
    {
        ...
    }

Elements in a `Hashtable` are organized based on the **hash** code of the key.

The properties `Keys` and `Values` of a `Hashtable` return an `ICollection` of items requested.

        public virtual ICollection Keys { get; }
        public virtual ICollection Values { get; }

The public virtual void `Add(object key, object value)` is used in adding new elements and the public virtual void `Remove(object key)` in removing.

The methods

        public virtual bool Contains(object key);
        public virtual bool ContainsKey(object key);
        public virtual bool ContainsValue(object value);

return `true` if the requested item exists.

#### SortedList Class

The `System.Collections.SortedList` class is a dictionary where its elements are sorted by the keys and are accessible by key and by index. The public virtual `object GetKey(int index)` returns the key by index where the public virtual `object GetByIndex(int index)` returns the value by index.

#### Queue class and Stack class

`System.Collections.Queue` is a first-in, first-out (**FIFO**) list of objects where `System.Collections.Stack` is a last-in, first-out (**LIFO**) list of objects. They are both `ICollection` and `IEnumerable` objects.

#### BitArray class

`System.Collections.BitArray` class is an array of bit values.

The number of elements a `BitArray` contains it is defined by the constructor called. Each value is represented as a boolean value where `true` means the bit is on (1) and `false` means the bit is off (0).

The `BitArray` class provides `Get()` and `Set()` methods for getting/setting the value of a certain element.

It also provides methods like `And(), Or(), Not()` and `Xor()` for performing massive bit setting.

#### System.Collections.Specialized namespace

The `System.Collections.Specialized` namespace containes specialized lists, collections and dictionaries for handling many coding situations.

Classes
-------

This part describes **namespaces**, **delegates** and the C# **object model**.

### Namespaces

A namespace is a type container, that is a namespace is a fictional space for type names. Thus a namespace imposes a scope for those type names.

A namespace is used in avoiding name clashing and in organizing classes and types.

Namespaces can be nested.

    namespace A
    {
      namespace B
      {
      }
    }

or

    namespace A.B
    {
    }

It is valid to have multiple namespaces declarations, with the same or different name, into the same source document.

The compiler constructs the final namespace content at compile time. Thus a namespace may exist more than once in the same source file or may spread in multiple source files or compiled assemblies.

A class or type declared outside of any namespace, becomes a member or the **global** namespace.

Also, top level namespaces are considered members of the global namespace, that is the global namespace is the "root" namespace.

In accessing a member of the global namespace the keyword `global` is used along with the namespace alias qualifier (`::`)

    global::MyClass C = new global::MyClass();

It is possible to use the same name for a class in two or more distinct namespaces.

    namespace namespaceA
    {
       class SomeClass {}
    }

    namespace namespaceB
    {
       class SomeClass {}
    }
    
    ...

    class Test
    {    
        public void SomeMethod()
        {
            namespaceA.SomeClass A = new namespaceA.SomeClass();
            namespaceB.SomeClass B = new namespaceB.SomeClass();               
        }
    }

#### The using directive

The `using` directive is used to import a namespace name into the scope of a source file or into the scope of a namespace, thus allowing the use of un-qualified type names.

    using System;
    
    namespace someNamespace
    {
        using System.Windows.Forms;
        
        class Test
        {
            static public void DisplayFullName()
            {
                Type T = typeof(int);           // Type is a member of System 
                MessageBox.Show(T.FullName);    // MessageBox is a member of System.Windows.Forms
            }
        }
    }

Also, the `using` directive is used in creating **aliases** for namespace names.

    using System;
    using Forms = System.Windows.Forms;             // creating an alias for System.Windows.Forms
    
    namespace someNamespace
    {       
        class Test
        {
            static public void DisplayFullName()
            {
                Type T = typeof(int);                   // Type is a member of System 
                Forms.MessageBox.Show(T.FullName);      // Forms is an alias for System.Windows.Forms
            }
        }
    }

### Delegates

A `delegate` is a Reference type.

A variable of a `delegate` type references a method. That is the value of a `delegate` variable is the address of a method.

The declaration of a `delegate` type contains the keyword `delegate` and for the rest it just resembles the declaration of a method without a body.

    public delegate CalculationDelegate(int x, int y);

A non-null `delegate` value is callable with exactly the same way a method is and it actually executes the method it represents.

A `delegate` type variable is assigned by either passing the name of a method or by calling the `delegate` constructor passing the name of the method.

For a method to be assignable to a `delegate` type variable it should have **the same signature** as the delegate, that is the same number and type of parameters and the same return type. Otherwise it is considered not valid. That method may belong to a class or struct and may be a static or an instance method.

    public delegate int CalculationDelegate(int x, int y);

    public int Add(int x, int y)
    {
        return x + y;
    }

    public void Calculate(CalculationDelegate Handler)
    {
        int i = Handler(3, 4);              // calling the delegate

        MessageBox.Show(i.ToString());
    }

    private void button1\_Click(object sender, EventArgs e)
    {
        //CalculationDelegate d = new CalculationDelegate(Add); // it is the same as the following
        CalculationDelegate d = Add;

        int i = d(1, 2);                    // calling the delegate

        MessageBox.Show(i.ToString());

        Calculate(d);                       // passing a delegate value as a parameter
    }

Delegates are, the well known to other programming languages, **callback** functions.

Since a `delegate` variable contains a method, it's now possible to pass a method as a parameter to another method.

#### Multicasting

A `delecate` variable can be assigned **more than one** method and invokes them **all** when it is invoked. This is called **multicasting** and that kind of delegates are called **multicast** delegates.

Multicast delegates contain a so called **invokation list** which is where a `delegate` keeps the methods it has to invoke.

The adding and removing of multiple methods to that invokation list is done by using the following operators.

    +
    -
    += 
    -=

For example

    CalculationDelegate d += new CalculationDelegate(Add); 

#### Delegate class and MulticastDelegate class

User defined `Delegate` types are actually derived from the `System.MulticastDelegate` class which in turn is derived from `System.Delegate` class.

The methods and properties defined by those classes can be called on a delegate variable.

    public delegate void CalculationDelegate(int x, int y);

    public void Add(int x, int y)
    {
        int Res = x + y;

        MessageBox.Show(Res.ToString());
    }

    public void Subtract(int x, int y)
    {
        int Res = x - y;

        MessageBox.Show(Res.ToString());
    }

    public void Multiply(int x, int y)
    {
        int Res = x \* y;

        MessageBox.Show(Res.ToString());
    }

    public void Divide(int x, int y)
    {
        int Res = x / y;

        MessageBox.Show(Res.ToString());
    }

    /\* multicast delegates \*/
    private void button1\_Click(object sender, EventArgs e)
    {
        CalculationDelegate d = Add; 
   
        d += Subtract;

        CalculationDelegate c = Multiply;
        d += c;

        CalculationDelegate f = Divide;
        d = d + f;
   
        d(10, 2);

        MessageBox.Show(d.GetType().BaseType.FullName);

        d = d - f;

        int i = d.GetInvocationList().GetLength(0);
        MessageBox.Show(i.ToString());
    }

#### Named methods and Anonymous methods

A method is assignable to a delegate value because it has a name. That is delegates are constructed using named methods.

Starting from C# 2.0 **anonymous methods** introduced.

An Anonymous method is a code block defined by using the keyword `delegate`, any parameters to that delegate, and the code block itself.

An Anonymous method is assignable to a delegate value just like any other compatible method is.

    public delegate void StringDelegate(string Text);

    public void Display(string S)
    {
        MessageBox.Show("Named method: " + S);
    }

    private void button1\_Click(object sender, EventArgs e)
    {
        // a named method
        StringDelegate d = Display;

        // an anonymous method
        d += delegate(string S) 
                {
                    MessageBox.Show("Anonymous method: " + S); 
                };

        d("Hi there!");
    }

### Classes

A class is a user defined type. It combines operations (behavior = methods) and data (state = properties).

Members of a class are

*   Methods
*   Properties
*   Fields
*   Events

A class imposes a name scope which may include other nested types such as

*   other nested classes
*   enum types
*   struct types
*   delegate types

see also:

*   [http://en.wikipedia.org/wiki/Class\_(computer\_science)](http://en.wikipedia.org/wiki/Class_(computer_science))
*   [http://en.wikipedia.org/wiki/Category:Object-oriented\_programming](http://en.wikipedia.org/wiki/Category:Object-oriented_programming)

#### Class definition

Formal definition.

    class ClassName
    {
    }

Example.

    class Man
    {
    }

#### Objects and object variables

A class is a type and a type acts as a mold in creating objects based on that mold.

An object occupies a memory block formatted according to the pattern, the mold, provided by a class.

The term **instance**, meaning a class's instance, refers to an object created using a class.

An object comes into existence after an operation known as "**object construction** " takes place.

Object construction is the formation of a memory block based on a mold a certain class provides.

A new object is created by using the keyword `new` and a special method call **constructor**.

    Man A = new Man();  // object constuction

An object is an instance of a class.

An object resides in **heap** memory. An object variable points to that object in memory. It is possible to have many variables pointing (referring) to the same object in memory. Object variables are pointer variables after all.

    Man B = A;          // B now refers to the same object as A

An uninitialized object variable refers to `null` (points to nowhere in memory).

It is an error to call any member of an object variable which is `null`.

The `null` literal value can be assigned to any object of any class type.

    Man A = null;
    object Obj = null;

A class stores its data in plain variables called **fields**. Any individual object contains **its own copy of data**, that is its own copy of those fields.

Although two objects may have the same set of data, they are not necessarily the same object. That is objects have **identity**. Their identity is defined by the different location in the memory each one occupies.

    class Man
    {
        public string Name;  // a field
    }
    
    ...
    
    Man A = new Man();
    A.Name = "John";
    
    Man B = new Man();
    B.Name = "John";

`A` and `B` are two different objects, above.

An object variable can not be declared as of a nullable type (This has changed in C# 8).

Classes are Reference types. Only Value types can be declared as nullable types. 

    Man? M = null;  // not valid

﻿TODO: Nullable Reference types.

#### Inheritance

Classes, unlike Structs, support **inheritance**.

Inheritance is a term which describes the definition of a new class based on another class.

C# supports single inheritance only. 

A class can inherit implementation from one and only one base class. The base class is denoted by using a colon after the name of the new class and then the name of the base class. If you don't explicitly define the ancestor (base) class, then the new class inherits from `System.Object`.

A derived class inherits all non-private members of its base class.

A derived class forms a new type but it has as many effective types as are the base classes it subsequently inherits from. That is a class `C` that inherits `B` that inherits `A`, is also considered an `A` and a `B` class too.

    class Man
    {
        public string Name;
    }
    
    class Teacher: Man  // Teacher class inherits from Man class
    {
        public void Teach()
        {
        }
    }

    ...
    
    Teacher T = new Teacher();
    T.Name = "John";            // Name field, inherited from Man
    T.Teach();

Since a derived class contains all of its ancestor classes, an object of a derived class can be assigned to a variable of any of its base classes. This is refered to as **type compatibility**.

    Man M = T;    

An object can be cast to its own type and any of its ancestor (base) types.

Thus any object variable can be cast to `System.Object` type, because `System.Object` is the ultimate base class type.

The `is` operator returns `true` when the object being checked is not `null` and can be cast to the provided type whithout throwing an exception.

The ability for an object to represent more than one type is called **polymorphism**.

Object variables can only access members of its declared type, not of the actual type they may contain.

    Man M = new Teacher();
    M.Teach();               // member not found error, Man class does not provide a Teach() method.

see also:

*   [http://en.wikipedia.org/wiki/Inheritance\_(computer\_science)](http://en.wikipedia.org/wiki/Inheritance_(computer_science))
*   [http://en.wikipedia.org/wiki/Encapsulation\_(computer\_science)](http://en.wikipedia.org/wiki/Encapsulation_(computer_science))

#### Access modifiers and class members

Class members define their **visibility** to other code elements by using special keywords.

##### Keyword Accessability

A `private` member is accessible by class code only.

A `protected` member is accessible by class code and any descendant in the same or other assemblies.

An `internal` member is accessible by any code in the same assembly.  

`protected internal` is a compination of `protected` and `internal.`

A `public` member is accessible by any code in the same or other assemblies.

A top level (a not nested) type may defined as `public` or `internal`. Classes follow this rule too.

Class default accessability is `internal`.

A type nested to a class may have any of the above five degrees of accessability.

#### Constructors and the default constructor

Constructors are special methods used in creating and initializing instances of types called objects.

A constructor is defined by just using the name of the class and a pair of parentheses.

A constructor has no return type but it may include a parameter list.

A class may have multiple constructors but each one has to provide a different parameter list from the others.

A special constructor, called the **default constructor**, is a constructor with no parameters at all. Every class has a default constructor. If the programmer ommit the default constructor the compiler provides one which just sets member fields to their default values.

Here is a default constructor which initializes a private field called name.

    class Man
    {
        private string name;
    	
        public Man()
        {
            name = "no name";
        }
    }

Here is a parameterized constructor

    class Man
    {
        private string name;

        public Man(string Name)
        {
            this.name = Name;
        }
    }

The keyword `this` refers to the current object (instance of a class) for which a member is executed.

A constructor may call another constructor by using the keyword `this` and passing the required arguments. Here are some examples.

    class Man
    {
        private string name = "";
        private int age = 0;

        public Man()
        {
            name = "no name";
            age = 0;
        }

        public Man(string Name) : this(Name, 30)
        {
        }

        public Man(string Name, int Age) : this()
        {
            name = Name;
            age = Age;
        }
    }

A constructor may call a base constructor by using the keyword `base` in place of `this`.

    class Teacher: Man
    {
        public Teacher(): base()
        {
        }

        public Teacher(string Name): base(Name)
        {
        }
    }

If a base class does not provide a default constructor, the derived class must explicitly call a base constructor by using the keyword `base`.

If a base class constructor is not called explicitly by using the `base` keyword, the base default constructor, if there is one, is called implicitly by the system.

The object is actually created before any constructor is executed. It is the combination of the `new` keyword and the name of the class that actually allocates the memory for the new object. So, **the primary job of a constructor is to initialize the newly created object**. That's why the official name of a constructor in .Net is `Initializer`.

#### Methods

A method is a code block and imposes a scope.

A method defines algorithic actions in the form of souce lines, may or may not accept parameteters and may or may not return a value.

The syntax of a method includes

*   the access specifier
*   the return type
*   the name of the method
*   a pair of parentheses which may enclose parameters separated by commas
*   a pair of curly braces to denote the code block of the method

    public int Add(int x, int y)
    {
        return x + y;
    }

    public void Exec()
    {
    }

The keyword `void` indicates a method that has no return type.

The return type and the parameter number, types and positions is considered **the signature of the method**.

A method is called by using its name and passing any arguments it may expects. If it is a method which returns a non-void type then its return value may or may not stored to a local variable of the same or a compatible type.

In some way a non-void method equals to the value it returns.

    int i = Add(2, 5);

The keyword `return` is used to designate the end of method execution and may return a value. That is a method exits when the execution reaches a `return` statement.

A non-void method is always required to return a value. A void method terminates when there is no more lines to execute or a `return` statement is reached.

    int Add(int x, int y)
    {
        return x + y;
    }

    void Exec()
    {
        if (1 > 2)
        {
            return;
        }
        else
        {
        }
    }

#### Method parameters

**Parameters** are called the **formal** parameters declared in the **parameter list** in the header of a method.

**Arguments** are called the values passed to the method when it is called. Arguments could be literal values or variables.

Inside the body of the method, parameters act as local variables. Their scope spans to the whole method.

The name of the variable passed as an argument to a method it is not required to be the same as the declared parameter.

A value passed as an argument to a method actually assigns the corresponding declared parameter. That is passing an argument is an assignment just like any other assignment.

Parameters are passed either **by value** or **by reference**. Passing by value requires no special syntax.

Changes to parameters passed by value which take place inside the method body, are not propagated outside of the method.

Passing by reference requires special syntax. Parameters must declared using the keyword `ref`. Arguments must be passed also using the keyword `ref`. Changes to parameters passed by reference which take place inside the method body, are propagated outside of the method.

The keyword `ref` requires that the variable be initialized before it is passed.

Passing by reference means **passing the address** of something. Literal values have no address so can not be passed by reference.

Also, for the same reason, **properties can not be passed by reference**. A property is the shop front of a value.

Both Value types and Reference types may be passed either by value or by reference.

    public void PassByValue(int x)
    {
        x++;
    }
    
    public void PassByRef(ref int x)
    {
        x++;
    }
    
    ...
    
    int x = 1;              // must be initialized if is to be passed by ref
    PassByValue(x);         // x remains 1 here
    PassByRef(ref x);       // x is 2 here

Value of a Reference type is considered the object itself. Not its data.

    public class Man
    {
        public string Name = "John";
    }
    
    public void ManByValue(Man M)
    {
        M = new Man();      // this object is discarded upon method exit
        M.Name = "Jane";    
    }
 
    public void ManByRef(ref Man M)
    {
        M = new Man();      // this object is propagated outside the method
        M.Name = "Jane";
    }
 
    ...
 
    Man M = new Man();
    ManByValue(M);
    ManByRef(ref M);

> **CAUTION** : Arrays are Reference types.

The keyword `out` works like the keyword `ref`. It is used to pass parameters **by reference**.

Passing parameters by reference using `out` requires no argument initialization from the caller side. The method being called, is required to initialize any passed in `out` parameter before it returns.

    public void StrOut(out string S)
    {
        S = "out parameter: Hi there!";            // out parameters must initialized before exit
    }

    ...

    string S;
    StrOut(out S);              // out parameters require no initialization

#### Overloaded methods

Overloaded methods are methods belonging to the same class, having the same name, but different parameter list.

The return type is not considered when overloading. Just the paremeter number and types.

Upon calling an overloaded method the system uses the number and type of arguments passed in order to find the right overloaded version. Constructors could be overloaded too.

    public void Display(string Text)
    {
        MessageBox.Show(Text);
    }
    
    public void Display(string Text, int Param)
    {
        Display(Text + ": " + Param.ToString());
    }

#### The params keyword

A method may declare one or more array parameters.

    public void Exec(string\[\] a)
    {
        string Text = "";
        foreach (string s in a)
            Text += s + Environment.NewLine;
            
        MessageBox.Show(Text);
    }
    
    ...
    
    Exec( new string\[\] {"hi", "there"} );

The keyword `params` may applied to the last parameter, which must be of some `array` type.

Only a single parameter may declared as a `params` parameter and must be the last one.

The keyword `params` makes it possible to pass a variable number of arguments using commas.

    public void Exec2(params string\[\] a)
    {
        string Text = "";
        foreach (string s in a)
            Text += s + Environment.NewLine;
            
        MessageBox.Show(Text);
    }
    ...
    
    Exec2("hi", "there");

#### Properties and fields

Fields are members that provide storage location for a value. Fields give the ability to classes and structures to contain and encapsulate data.

    public class Item
    {        
        public string Name = "";  
        public double Price = 0;
    }

A field may initialized along with its declaration. The system initializes fields just before the constructor is called.

If the constructor assigns a new value to a field, then this new value overwrites any value was assigned to that field upon its declaration.

A field may be marked as a constant field using the keyword `const`. A constant field must initialized along with its declaration.

    public class Temperature
    {
        public const double WaterFreezingPoint = 0;
    }

A field may be marked as a read only field using the keyword `readonly`.

A `readonly` field must initialized along with its declaration or inside of a constructor.

    public class Temperature
    {
        public readonly double WaterFreezingPoint;
        
        public Temperature()
        {
            WaterFreezingPoint = 0;
        }
    }

Usually fields are marked as `private` or `protected`. It' not an error to have class fields as `public`.

Fields play the role of a storage medium where properties read and write values stored in fields or elsewhere.

Properties are members that provide read-only or read-write access to a value. A property may have a `get` or a `set` part or both. Those parts are called **accessors**.

Usually a property uses a `private` or `protected` field to read and write the value it represents.

The syntax of a property includes the type of the property and the property name whith no parentheses at all, and a `get` and, if it's a writeble property, a `set` accessor.

The keyword `value` denotes a special variable defined by the compiler and it is only available inside the `set` accessor. That `value` special variable contains the new value being assigned to the property.

    public class Item
    {        
        protected string name = "";  

        public Item(string Name)
        {
            this.Name = Name;
            Price = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price { get; set; } // auto-implemented property
    }

A property works like a field. It provides the means to access a value. The difference is that a field is an actual storage location for that value, just like a variable is, while a property is simply the shop front for that value.

**A field has an address** and can be passed by reference.

**A property has no address** and can not be passed by reference.

A property associates specific actions with reading and writing its value and those actions allow that value to be computed.

##### Asymmetric Accessor Accessibility

The get and set accessor may have different access levels.

    public class Item
    { 
        public double Price { get; protected set; }  
    }

##### Auto-implemented Properties

Auto-implemented properties are properties the declare just empty `get` and `set` accessors. The system provides an anonymous backing field to read and write the value.

Auto-implemented properties do **not**  require both accessors.

Attributes can not be applied to auto-implemented properties.

Auto-implemented properties support asymmetric accessor accessibility.

#### Indexers

Indexers are a special kind of properties which are defined by using the keyword `this` and a syntax similar to an array.

Since indexers resemble arrays, a similar syntax is used in accessing the "elements" of an indexer.

An indexer may have both a `get` and a `set` accessor and may be indexed by any type, not just integers.

Indexers can be overloaded.

Indexers can have more than one parameters, thus resempling a two-dimensional array.

    public class PriceList
    {
        private ArrayList list = new ArrayList();

        public Item Find(string Name)
        {
            foreach (Item item in list)
                if (item.Name == Name)
                    return item;

            return null;
        }

        public bool Contains(string Name)
        {
            return Find(Name) != null;
        }

        public int Count
        {
            get { return list.Count; }
        }

        public double this\[string Name\]
        {
            get { return Find(Name).Price; }
            set 
            { 
                Item item = Find(Name);
                if (item == null)
                {
                    item = new Item(Name);
                    list.Add(item);
                }
                item.Price = value;
            }
        }

        public Item this\[int Index\]
        {
            get 
            { 
                return ((Item)list\[Index\]); 
            }

        }
    }

#### Events

Events are class members. They are used to send notifications to one or more targets when something of interest occurs.

**Publisher** is called the event owner, the one that sends the notification.

**Subscriber** (or **Listener**) is called the receiver of such a notification.

An event may have many subscribers. All subscribers will be notified in the case of an event.

An event is declared using an access modifier, the keyword `event` and a `delegate` type.

An event is actually a member of a `delegate` type, which is declared using the keyword `event`.

    public delegate void NameChangeDelegate();

    public class Man
    {
        public event NameChangeDelegate NameChanged;
    }

Usually an event is triggered when a property changes, when a condition is met or when a method is called. This is something for the class writer to decide.

An event can be triggered only by its owner (publisher). No other code can call the event. This is the major difference between events and plain delegates.

    public class Man
    {
        private string name = "";
        
        public event NameChangeDelegate NameChanged;
        
        public string Name
        { 
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    
                    if (NameChanged != null)
                      NameChanged();
                }
            }
        }
    }

There is a .Net guideline which suggests that there should be a separate method which calls the event and that method should be named be prefixing **On** to the event name.

    public class Man
    {
        private string name = "";
        protected void OnNameChanged()
        {
            if (NameChanged != null)
              NameChanged();
        }
        
        public event NameChangeDelegate NameChanged;
        
        public string Name
        { 
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnNameChanged();
                }
            }
        }            
    }

Another .Net quideline suggests that delegate types used with events should follow the pattern imposed by the `EventHandler` delegate. The `EventHandler` delegate is used in many events and it is declared as

    public delegate void EventHandler(object sender, EventArgs e);

As sender is passed the Publisher, which is **the source of the event**. Of course if the event is static the passed argument should be `null`.

The `EventArgs` is declared as

    public class EventArgs
    {
        public static readonly EventArgs Empty;
        public EventArgs() { ... }
    }

Following those guidelines, our example becomes as

    public class Man
    {
        private string name = "";
        protected void OnNameChanged()
        {
            if (NameChanged != null)
              NameChanged(this, EventArgs.Empty );
        }
        
        public event EventHandler NameChanged;
        
        public string Name
        { 
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnNameChanged();
                }
            }
        }
    }

After the introduction of the **null-conditional operator**, the `?.` in C# the following code

    if (NameChanged != null)
        NameChanged(this, EventArgs.Empty);

could be written as

    NameChanged?.Invoke(this, EventArgs.Empty );

If the `EventHandler` delegate is not enough to convey the required information then a user defined `delegate` type and a user defined `EventArgs` descendant can be used.

    public class NameEventArgs: EventArgs
    {
        private string oldName;
        private string newName;
        
        public NameEventArgs(string OldName, string NewName)
        {
            oldName = OldName;
            newName = NewName;
        }
        
        public string OldName { get { return oldName; } }
        public string NewName { get { return newName; } }
    }
    
    public delegate void NameEventHandler(object sender, NameEventArgs e);
    
    
    public class Man
    {
        private string name = "";
        
        protected void OnNameChanged(string OldName, string NewName)
        {
            if (NameChanged != null)
              NameChanged(this, new NameEventArgs(OldName, NewName) );
        }
        
        public event NameEventHandler NameChanged;
        
        public string Name
        { 
            get { return name; }
            set
            {
                if (name != value)
                {                    
                    OnNameChanged(name, value);
                    name = value;
                }
            }
        }
    }	

A listener code links to an event by providing a method compatible to the event delegate signature and using the familiar `+=` operator. A listener code may later unsubscribe from that event. The listener's method that handles the event is called **event handler**.

    public void Man\_NameChanged(object sender, NameEventArgs e)
    {
        MessageBox.Show("Old name: " + e.OldName + ", New name: " + e.NewName);
    }
	
    ...
    
    Man M = new Man();
    M.NameChanged += Man\_NameChanged;
    
    ...
    
    M.Name = "John";	

An event is actually a special kind of property which is required to always have a `set` and a `get` accessor. Actually an event may contain an `add` and a `remove` accessor, much like a property contains a `set` and a `get` accessor. If the programmer ommits the `add` /`remove` accessor the system provides one along with a private delegate field. Here is a manual implementation.

    public class Man
    {
        private string name = "";
        private event NameEventHandler nameChanged;
	
        protected void OnNameChanged(string OldName, string NewName)
        {
            if (nameChanged != null)
                nameChanged(this, new NameEventArgs(OldName, NewName));
        }
	
        public event NameEventHandler NameChanged
        {
            add { nameChanged += value; }
            remove { nameChanged -= value; }
        }
	
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    OnNameChanged(name, value);
                    name = value;
                }
            }
        }
    }	

see also:

*   [http://en.wikipedia.org/wiki/Event\_(computing)](http://en.wikipedia.org/wiki/Event_(computing))

#### Static classes and static members

A static member is defined using the keyword `static`.

A static member can be a field a property, a method, an event or a constructor.

Indexers and desctructors can not declared as static.

If a member is not decorated by the `static` keyword it is considered an instance member.

A static member belongs to the class itself. Not to a specific object (instance of a class). That's why a static member cannot be referenced through an object. Instead, a static member is referenced through the class name.

    class Executor
    {
        static public void Exec()
        {
        }
    }    
    
    ...
    
    Executor Ex = new Executor();
    Ex.Exec();                      // illegal
    
    Executor.Exec();                // legal	

It is valid to overload a static method.

It is not valid to override a static method or static property.

It is possible to declare a fully static class. In that case all members of that class should be static too.

It is not allowed to create an istance of a static class. Static classes considered **sealed**, that is they can not be inherited.

Static classes always inherit from `System.Object`.

Classes and static classes may have static constructors. A static class can not have instance constructors. A static constructor can not have parameters. Static constructors are not callable by user code. The class loader calls automatically the static constructor the first time the class is used and just before any other call.

    static class Executor
    {
        static public Executor()
        {
        }
        
        static public void Exec()
        {
        }
    }

It is not valid to use the keyword `this` to refer to static members. This is because the keyword `this` is used to denote the current instance for which a member is executed. Static members are bound to the class, not a certain instance.

It is not possible to refer to an instance member from inside a static member. A static member is executed on the class, not on any specific object.

Every instance of a class (object) has its own separate copy of fields (data) a class declares. In contrast there is only one copy of each static field, which is common to all instances. A constant field is implicitly a static field.

Static classes is a convenient way to organize methods in related groups.

    static public class TemperatureConverter
    {
	
        static public double CelsiusToFahrenheit(double Value)
        {
            return ((Value \* 9) / 5) + 32;
        }
	
        static public double FahrenheitToCelsius(double Value)
        {
            return ((Value - 32) \* 5) / 9;
        }
	
        static public double CelsiusToKelvin(double Value)
        {
            return Value + 273.15;
        }
	
        static public double KelvinToCelsius(double Value)
        {
            return Value - 273.15;
        }
    }

An old trick to have a non-static class functioning as a **singleton** object is to hide the default constructor by declaring it private and provide a static member which returns the single allowed instance of the class.

    public sealed class Singleton
    {
        static private Singleton instance = null;
	 
        private Singleton()
        {
        }
	
        static public Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
	
        public void Exec()
        {
            MessageBox.Show("executing");
        }
        
    }	

A `sealed` class can not be inherited.

#### Hiding members in derived classes

A derived class may redeclare an inherited member (field, property, method) with the same name, and parameters if the member is a method, as is found to its base class.

    public class Man
    {
        public void SayGoodMorning()
        {
            MessageBox.Show("good morning");
        }
	
    }
	
    public class Italian: Man
    {
        public void SayGoodMorning()
        {
            MessageBox.Show("buon jorno");
        }
    }

The compiler thinks that this replacement is done unintentionally and issues a warning: "_Warning: 'Lessons.Italian.SayGoodMorning()' hides inherited member 'Lessons.Man.SayGoodMorning()'. Use the new keyword if hiding was intended_."

The `new` keyword is used to decorate the member and to suppress that warning.

    public class Italian: Man
    {
        new public void SayGoodMorning()
        {
            MessageBox.Show("buon jorno");
        }
    }    

A derived class may access any of the non-private inherited members by using the keyword `base` and the name of the inherited member. This is done mostly from inside the code of a method or property in a derived class, thus extending the inherited behavior.

    public class Italian: Man
    {
        new public void SayGoodMorning()
        {
            base.SayGoodMorning();
            MessageBox.Show("buon jorno");
        }
    }

#### Polymorphism, virtual and override methods and properties

**Polymorphism** is the behavior of an object according to its type determined at runtime.

Polymorphism, in general, is the ability of one type to be used as another type. This is done because of inheritance. In C# all types ultimately inherit from `System.Object`. So any type can be used as if it was a System.Object.

In particular, polymorphism is the ability of an object to respond to a method or a property call, not according to the declared type of the object variable, but **according to the actual type the variable contains at runtime**. That is the compiler determines the actual type first and then calls the appropriate version of the member being called. This mechanism is called **late binding**or **dynamic binding**.

In C# polymorohism is achieved by declaring a method or property as `virtual` in a base class and redeclaring the same method or property as `override` in the derived class.

    public class Man
    {
        public virtual void SayGoodMorning()
        {
        }
	
        public string GetCountry()
        {
            return "unknown";
        }
    }
	
    public class Italian: Man
    {
        public override void SayGoodMorning()
        {
            MessageBox.Show("buon jorno");
        }
	
        new public string GetCountry()
        {
            return "Italy";
        }
    }
	
    public class French : Man
    {
        public override void SayGoodMorning()
        {
            MessageBox.Show("bon jour");
        }
	
        new public string GetCountry()
        {
            return "France";
        }
    }
	
    public class German : Man
    {
        public override void SayGoodMorning()
        {
            MessageBox.Show("guten morgen");
        }
	
        new public string GetCountry()
        {
            return "Deutschland";
        }
    }

In the above example the method `SayGoodMorning()` is declared as `virtual` in the base class `Man` while the three derived classes `Italian`, `French` and `German`, mark it as `override`.

The `SayGoodMorning()` is a **polymorphic** method.

In contrast, the `GetCountry()` method is a **non-polymorphic** one. So descendants should mark it with the `new` keyword in order to suppress the relevant compiler warning.

When a polymorphic member, as the `SayGoodMorning()` method, is about to be called at runtime the compiler has first to discover **the actual type** wherethrough the method call is about to be done, in order to determine the right version of the method to call.

That is a polymorphic call takes place because **there is a variable of a base type which actually contains an object of a derived type**.

	
    Italian italian = new Italian();
    French french = new French();
    German german = new German();
	
    Man\[\] men = new Man\[\] { italian, french, german };
	
    foreach (Man m in men)
        m.SayGoodMorning();                 // a polymorphic call
	
    foreach (Man m in men)
        MessageBox.Show(m.GetCountry());    // non-polymorphic call
	
    MessageBox.Show(italian.GetCountry());  // non-polymorphic call
    MessageBox.Show(french.GetCountry());   // non-polymorphic call
    MessageBox.Show(german.GetCountry());   // non-polymorphic call
	 
    MessageBox.Show(((Man)german).GetCountry());    // calling the base non-polymorphic method

> **NOTE**: Polymorphism may also achieved through the use of interfaces.

By default C# methods and properties are not virtual. Fields cannot be virtual at all. Only methods, properties, events and indexers can be virtual.

A method remains virtual regardless of the hierachy depth, how many descendants are in between and if they or they don't override the virtual method.

The virtuality is interrupted if a derived class redeclares the virtual method not as overriden one but using the keyword new, which hides the inherited virtual method. The new method may declared again as virtual though, thus starting a new polymorphic chain.

The keyword `sealed` may used with an overriden method or property in order to prevent further overrides. That is the keyword `sealed` prevents the polymorphich chain to go further down. But again derived classes may redeclare a sealed virtual method using the new keyword.

see also:

*   [http://en.wikipedia.org/wiki/Polymorphism\_in\_object-oriented\_programming](http://en.wikipedia.org/wiki/Polymorphism_in_object-oriented_programming)

#### Abstract classes

An abstract class is a class marked with the keyword `abstract` and may contain one or more methods or properties marked again with the keyword `abstract`.

If a class contains abstract members then it has to be marked as an abstract class.

Abstract members contain no implementation. Just the declaration of the member.

It is not possible to create an object using an abstract class.

Abstract classes used in enforcing an inheritance specification. Non-abstract derived classes should implement all abstract members they inherit.

Abstract members are implicitly virtual members. For example the `System.IO.Stream` class is an abstract class. It serves as a base class enforcing an interface specification to many stream derived classes which provide the same public interface as the `System.IO.Stream` class but they deal with a variety of storage medium.

    public abstract class Vehicle
    {
        public abstract string Move();
        public abstract int Weight { get; }
    }
	
    public class Airplane : Vehicle
    {
        public override string Move()
        {
            return "Airplane is flying";
        }
	
        public override int Weight { get { return 12000; } }
    }
	
    public abstract class Wheeled : Vehicle
    {
        public override string Move()
        {
            return "Wheeled is moving";
        }
    }
	
    public class Car : Wheeled
    {
        public override string Move()
        {
            string Result = base.Move();
            return Result + " -- Car is speeding up";
        }
	
        public override int Weight { get { return 1500; } }
    }	

#### Interfaces

Interfaces are Reference types.

An interface declaration resembles a class declaration. An interface may contain methods, properties and events but no fields. It provides no implementation for any of its members. The implementation of the methods and properties is done in the class or struct that implements the interface.

All interface members are considered public. Thus it is not valid to define accesibility for interface members.

    public interface ICarDriver
    {
        void Drive();
	
        string LisenceNumber { get; set; }
    }

A class or struct may implement one or more interfaces.

If a class inherits another class and implements interfaces at the same time the base class must come first in the ancestor list.

     class SomeClass: BaseClass, IInterface1, IInterface2
     {
     }

A class or struct that implements interfaces, it must implement all the methods and properties of all the interfaces it implements.

A class or struct that implements interfaces it may contain other methods or properties not found in any of the interfaces it implements.

    class Doctor : ICarDriver
    {
        private string lisenceNumber = "";
	
        public Doctor(string LisenceNumber)
        {
            this.lisenceNumber = LisenceNumber;
        }
	
        public void Operate()
        {
            MessageBox.Show("Doctor is operating");
        }
	
        public void Drive()
        {
            MessageBox.Show("Doctor is driving his car");
        }
	
        public string LisenceNumber
        {
            get { return lisenceNumber; }
            set { lisenceNumber = value; }
        }
    }

An interface is not directly instantiated. Instead you create an object that implements an interface and then assign an interface variable.

An object may assigned to an interface variable if its type (class or struct) implements the interface of that interface variable.

    ICarDriver Driver = new Doctor(textBox1.Text);

It is not possible to directly call members of the implementor object that are not members of the interface, through an interface variable without a proper typecasting.

    if (Driver is Doctor)
        (Driver as Doctor).Operate();

Interfaces actually promote polymorphism.

see also:

*   [http://en.wikipedia.org/wiki/Interface\_(computer\_science)](http://en.wikipedia.org/wiki/Interface_(computer_science))

#### Structs

Structs are Value types.

All structs inherit directly from `System.ValueType`, which inherits from `System.Object`.

A struct declaration resembles a class declaration.

A struct can not contain a default constructor. A default constructor is always provided by the compiler which initializes all fields to their default values.

A struct may contain parameterized constructors though. A parameterized constructor must initialize all fields.

A struct may have static members.

In most of the cases a struct contains fields and methods only, although a struct may have properties and events. Struct fields can not be initialized when declared, unless they are declared as const or static.

    public struct SomeStruct
    {
        public const int SomeField = 0;
    }

Structs may implement interfaces but they cannot inherit from classes or other structs.

Just declaring a struct variable, creates an instance of the struct with all of its fields uninitialized.

A struct variable is considered uninitialized while a single field is uninitialized. A constructor call initializes struct fields to their default or parameterized values.

    public struct Temperature
    {
        public double Value;
    }
    
    ...
    
    Temperature A = new Temperature();

Since structs are Value types they can be instantiated without calling a constructor.

    Temperature A;
    A.Value = 30;

A struct can be used as a nullable type and can be assigned a null value.

    Temperature? A = null;

Assigning a struct variable to another copies field values from one struct to another.

    Temperature B = new Temperature(30);
    A = B;

see also:

*   [http://en.wikipedia.org/wiki/Struct](http://en.wikipedia.org/wiki/Struct)

#### The System.Object class

In .Net the `System.Object` class is the root of all types. It is the ultimate base class for all classes and structs.

    public class Object
    { 
        public Object();
        
        public virtual bool Equals(object obj);                         // Determines whether the specified System.Object is equal to the current System.Object.
        public static bool Equals(object objA, object objB);            // Determines whether the specified System.Object instances are considered equal.
        public virtual int GetHashCode();                               // Serves as a hash function for a particular type.
        public Type GetType();                                          // Gets the System.Type of the current instance.
        protected object MemberwiseClone();                             // Creates a shallow copy of the current System.Object.
        public static bool ReferenceEquals(object objA, object objB);   // Determines whether the specified System.Object instances are the same instance.
        public virtual string ToString();                               // Returns a System.String that represents the current System.Object.
    }

Since everything is an object every method defined in the Object class is available to any object in the system. `System.ValueType` struct, a direct System.Object descendant, is the ancestor of all Value types. And since simple types are structs System.Object is the ultimate base class for them too.

    public abstract class ValueType
    { 
        protected ValueType();
                
        public override bool Equals(object obj);
        public override int GetHashCode();
        public override string ToString();
    }

The virtual `ToString()` returns a descriptive text representing the object. The `System.Object` version of the method returns just the full name of the type. Many structs and classes override `ToString()` in order to provide a more suitable descriptive text.

    public struct Temperature : IComparable
    {
        public Temperature(double Value)
        {
            this.Value = Value;
        }
	
        public override string ToString()
        {
            return "Celsius: " + Value.ToString();
        }
	 
        public int CompareTo(object obj)
        {
            if (obj is Temperature)
                return Value.CompareTo(((Temperature)obj).Value);
            else
                throw new ArgumentException();
        }
	
        public double Value;
    }

#### Object comparison

It is not possible to use the relational operators `==` and `!=` when comparing structs. A struct must overload those operators if they are to be used on that struct. It is possible to use those `==` and `!=` relational operators to compare references though. It is not possible to use the `>=` and `<=` relational operators, neither with objects nor with structs, without overloading those operators for the type. More on operator overloading later.

Hopefully the `System.Object` class provides some methods for performing comparisons.

The static `ReferenceEquals()` works with objects only just comparing instances.

The static `Equals()` checks reference equality for Reference types, and bitwise equality for Value types.

The virtual `System.Object.Equals()` works exactly as the static version while the overriden `System.ValueType.Equals()` uses reflection to check the corresponding fields of the struct in comparison.

    public struct Temperature
    {        
        public Temperature(double Value)
        {
            this.Value = Value;
        }
        
        public double Value;
    }
    
    public class Man
    {
        public Man(int Age)
        {
            this.Age = Age;
        }
	
        public int Age;
    }
	
    ...
	
    Temperature T1 = new Temperature(32);
    Temperature T2 = new Temperature(32);
	
    //if (T1 == T2)
    //    MessageBox.Show("T1 == T2");          // Error: Operator '==' cannot be applied to operands of type 'Lessons.Temperature' and 'Lessons.Temperature'
	
    if (object.Equals(T1, T2))
        MessageBox.Show("Equals(T1, T2) ");     // true
	
    if (T1.Equals(T2))
        MessageBox.Show("T1.Equals(T2)");       // true
                
    ...        
        
    Man M1 = new Man(32);
    Man M2 = new Man(32);
	
    if (M1 == M2)
        MessageBox.Show("M1 == M2");            // false         
	
    if (object.Equals(M1, M2))
        MessageBox.Show("Equals(M1, M2) ");     // false        
	
    if (M1.Equals(M2))
        MessageBox.Show("M1.Equals(M2)");       // false

There may be situations where the above behavior is not what you want.

In such cases you can override the virtual `Equals()` method to provide the more complex comparison you may require. The compiler will issue a warning if you don't override at the same time the also virtual `GetHashCode()`. The `GetHashCode()` method returns an integer hash code which represents the object.

**Hash** algorithm is an algorithm which converts a possibly large and variable sized amount of data into a small and single bit of information, usually an integer.

Here is an example of overriding those methods for the Temperature struct.

    public struct Temperature
    {          
        ...
        
        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
	
            if (obj is Temperature)
                return Value == ((Temperature)obj).Value;
            else
                return false;
        }
	
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        
        ...
        
    }

#### Nested types

A class or struct may be a container for other types. Those inner types are called **nested types**.

Nested types are private by default.

Nested types can access private and protected members of the outer type, including any inherited private or protected members.

Outer types can not access private or protected members of a nested type.

The full type name of a nested type contains the name of its outer type.

    public class Outer
    {
        public enum InnerEnum { a, b, c };      // nested enum type
        public delegate void InnerDelegate();   // nested delegate type
	
        public class Inner                      // nested class type
        {
            private int x = 0;
            private Outer outer;
	
            public Inner()
            {
            }
	
            public Inner(Outer Outer)
            {
                this.outer = Outer;
                outer.x = 1;       // inner types can access private or protected members of outer types
            }
        }
	
	
        private int x = 0;
        private Inner inner;
	
        public Outer()
        {
            inner = new Inner(this);
            //inner.x = 1;          // Error: outer types can not access private or protected members of inner types
        }
	
        public Inner InnerObject
        {
            get { return inner; }
        }
    }
        
    ...
	
    Outer.Inner inner = new Outer.Inner();
    Outer.InnerEnum ie = Outer.InnerEnum.a;

#### Partial classes and partial methods

The keyword `partial` makes it possible to split the definition of a class, struct, interface or method to more than one places in a source file or even in different source files, but always in the same namespace, module and assembly. The compiler merges the different parts at compile type in order to form the full type, including attributes defined on the type. That is the final type is the combination of all the parts at compile time.

A partial class or struct may contain nested types. Those nested types may be partial too.

All the parts must be declared using the partial keyword.

All the parts must define the same accessibility level.

If a class part is declared abstract, then the whole class is considered abstract.

If a class part is declared sealed, then the whole class is considered sealed.

If a class or interface part declares a base type, then the whole class or interface inherits that base type.

**Partial methods** are valid with partial classes or partial structs only.

Partial methods have two distinct parts: the signature and the implementation. Those two parts may be in separate parts of a partial class or struct, or in the same part. If the implementation is not supplied, then the method and all calls to the method are removed at compile time.

Partial methods can not declare access modifiers. They are always private and therefore they can not be virtual.

Partial methods always have void as return type.

It is not valid to create a delegate to a partial method.

    namespace Lessons
    {
        public partial class PartialClass
        {
            private int x;
	
            public PartialClass()
            {
            }
	
            partial void PartialMethod();
        }
	
        public partial class PartialClass
        {
            public PartialClass(int X)
            {
                this.x = X;
            }
	
            partial void PartialMethod()
            {
                x++;
            }
	
            public int X
            {
                get { return x; }
            }
        }
    }

Partial types are basically useful to programming environments such as the MS Visual Studio which they split form classes into two source files in order to separate user logic from the construction and the initialization of the controls in a form.

#### Anonymous types - Object and collection initializers

**Anonymous types** is a language feature introduced with C# 3.0 which allows on-the-fly creation of types with no name along with object initialization.

Anonymous types may have properties only.

Anonymous type objects are assigned to local variables only which are declared by using the keyword `var`. That syntax instructs the compiler to use type inference for the variable.

    var m = new { Name = "John", Age = 32 };

> **NOTE** : Anonymous types mostly used in Language Integrated Query (LINQ) expressions. More on LINQ later.

Anonymous types are created by using the `new` operator with an object initializer.

Anonymous types are class instances, that is objects. They directly inherit from `System.Object`.

Anonymous types may contain read-only properties only. It is not possible to contain methods or events.

Anonymous type object variables have always **method scope**. To pass a variable like that to an other method, typecast it to `System.Object`.

The compiler generates type information for anonymous types as with any other type. Two or more anonymous type objects that have the same number and type of properties, in the same order, are considered to be of the same type.

**Object initializers** make it possible to create an object without calling a specific constructor and at the same time initialize any accessible field or property of the newly create object.

    public class Man
    {
        public string Name;
        public int Age;   
    }
	
    ...
	
    Man m = new Man { Name = "John", Age = 32 }; 

Object intitializers can not be used with a nullable struct.

Object initializers may be used with arrays, anonymous arrays, collections and generic collections. Especially with collections, object initializers is a way to avoid multiple calls to an `Add()` method.

    Man\[\] men = new Man\[\]                       // initializing an array                             
    {
        new Man { Name = "John", Age = 32 },
        new Man { Name = "Jane", Age = 30 },
        null
    };
	   
    ...
	
    var men = new\[\]                             // initializing an anonymous array                             
    {
        new Man { Name = "John", Age = 32 },
        new Man { Name = "Jane", Age = 30 },
        null
    };
	   
    ...
	
    ArrayList men = new ArrayList              // initializing list     
    {
        new Man { Name = "John", Age = 32 },
        new Man { Name = "Jane", Age = 30 },
        null
    }; 
    
    ...
	
    List men = new List               // initializing generic list  
    {
        new Man { Name = "John", Age = 32 },
        new Man { Name = "Jane", Age = 30 },
        null
    };

#### Extension methods

Extension methods are methods that extend classes, structs or interfaces.

Extension methods are declared as static methods in a type not related to the type they extend.

An extension method is declared with at least a single parameter which determines the type the method extends. That special parameter should be the first one in the parameter list and it should be prefixed by the keyword **this**.

Although extension methods are declared as static they are called as if they were instance methods of the type the extend. The calling code should omit that first special parameter when calling the method. The purpose of that first special parameter of an extension method is to help compiler in associating the extension method with the type it extends.

An extension method comes into scope and is available to client code when the namespace it belongs to, is explicitly imported with the using directive.

A method defined in the type with the same name and parameter list as an extension method has higher priority over the extension method. That means that at runtime the compiler favors methods defined in the type against extension methods with the same signature. So an extension method will never be called if it has the same signature as a method defined in the type.

    namespace Lessons
    {
        public struct Temperature  
        {
            public Temperature(double Value)
            {
                this.Value = Value;
            }
	
            public double Value;
	
        }
    }
	
    namespace Lessons.Extensions
    {
	
        static public class Extensions
        {
            static public IList ToList(this string S, char Separator)
            { 
                string\[\] a = S.Split(new char\[\] { Separator } );
                IList list = new ArrayList(a);
                return list;
            }
	
            static public double AsFahrenheit(this Temperature temperature)
            {
                return ((temperature.Value \* 9) / 5) + 32;
            }
	
            static public double AsKelvin(this Temperature temperature)
            {
                return temperature.Value + 273.15;
            }
        }
    } 
	 
    ... 
	
    string S = "I like extension methods";
    IList list = S.ToList(' ');             // an extension method is called as if it was an instance method
    
    ... 
	 
    Temperature t = new Temperature(0);
    double d = t.AsFahrenheit();            // calling an extension method of a custom class

#### Operator overloading

User defined classes and structs may overload one or more of the standard operators.

However not all operators can be overloaded, some of them require to be overloaded in pairs, for example `==` and `!=`, and some others impose restrictions.

The overloading is done by declaring a static function using the keyword `operator` suffixed with the operator symbol itself, the return type according to the operator and the required number and type of parameters, again according to operator. Binary operators require two parameters.

    public enum TemperatureKind
    {
        Celsius,
        Fahrenheit,
        Kelvin
    }
	
    public struct Temperature
    {
        public Temperature(double Value)
            : this(TemperatureKind.Celsius, Value)
        {
        }
	
        public Temperature(TemperatureKind Kind, double Value)
        {
            this.Value = Value;
            this.Kind = Kind;
        }
	
        static public double CelsiusToFahrenheit(double Value)
        {
            return ((Value \* 9) / 5) + 32;
        }
	
        static public double FahrenheitToCelsius(double Value)
        {
            return ((Value - 32) \* 5) / 9;
        }
	
        static public double CelsiusToKelvin(double Value)
        {
            return Value + 273.15;
        }
	
        static public double KelvinToCelsius(double Value)
        {
            return Value - 273.15;
        }
	
        public double Value;
        public readonly TemperatureKind Kind;
	
        public override bool Equals(object obj)
        {
            if (obj != null)
                throw new ArgumentNullException("obj");
	
            if (obj is Temperature)
                return (Value == ((Temperature)obj).Value) && (Kind == ((Temperature)obj).Kind);
            else
                return false;
        }
	
        public override int GetHashCode()
        {
            return (Value.ToString() + "|" + Kind.ToString()).GetHashCode();
        }
	
        public static bool operator ==(Temperature T1, Temperature T2)
        {
	
            return (T1.Value == T2.Value) && (T1.Kind == T2.Kind);
        }
	
        public static bool operator !=(Temperature T1, Temperature T2)
        {
            return (T1.Value != T2.Value) || (T1.Kind != T2.Kind);
        }
	
    }

#### Naming code elements

Naming code elements require special care. A proper name decreases the need for documentation and comments.

Class, interface and struct names should be nouns.

    Serializer
    Customer
    Car
    Engine
    CarEngine
    IDriver.

Properties and fields should be nouns also or contain a noun.

    Name
    Age
    totalSize.

Follow the convention: use camel casing with private fields.

    totalSize
    maxPressureDrop
    minimum

Avoid underscores.

    \_member
    m\_width
    total\_size
    Calculate\_Pressure\_Drop()

Underscores and upper casing (SCREAMING CAPS) sometimes are used with constant or read only fields.

    static public readonly DOWNLOADER\_SEMAPHORE\_NAME = ".....";

Methods should contain a verb denoting the operation. Use pascal casing.

    Load()
    ProcessCustomers()
    Serialize()

Method names sometimes omit the verb and instead use a preposition.

    CelsiusToKelvin()
    ByName()
    ByIndex()
    FromXML()
    ToXML()
    ToString()

Use descriptive parameter and local variable names. Do not use cryptic abbreviations.

### Destructors and the Garbage Collector

Memory allocation is done every time the `new` operator is used in order to create a new instance of a Reference type.

The de-allocation is done automatically by a special CRL component called **Garbage Collector**. The `System.GC` class represents the Garbage Collector of the CLR.

The idea of garbage collection is not a new one. Clipper, Java and the plain old VB all use a form of garbage collection.

Traditional Object Oriented Programming (OOP) languages, such as C++ or Delphi's Object Pascal use a special kind of method, called **destructor**, in order to finalize an object and release its memory. Those systems let programmers to call destructors at their disposal.

In the .Net kingdom manual memory deallocation is considered an evil thing and a source of many errors and memory leaks. Memory deallocation is done automatically by the Garbage Collector (GC) at mostly unpredictable points of time and basically when memory pressure is high.

When an application starts execution the CLR reserves a compact area of memory called the **managed heap**. All Reference types are allocated on that managed heap.

Memory for objects is allocated all the time while the application executes. However, memory is not infinite and at some point available memory becomes low. At that point is the time for the Garbage Collector to do its job. The exact time is calculated by special algorithms.

Garbage Collector performs passes, called **collections**. This is because it "collects" unused objects.

The first task of the Garbage Collector is to search the managed heap and discover objects that are not "reachable", that is they are no longer being referenced by application code. Those objects considered garbage. The Garbage Collector marks those objects as unused. In a next pass (collection) Garbage Collector releases those objects and reclaims their memory.

All those allocations and deallocations have a direct consequence. Managed heap becomes fragmented just like a hard disk. Memory de-fragmentation is done by the Garbage Collector by moving (relocating) objects in memory in order to join fragmented and unused pieces of memory in an effort to compact free memory. That means that a .Net object is movable and its position in memory changes. Actually things are much more complicated.

Garbage Collector uses a **generetional** architecture. Each object is assigned a generation, which is actually a number such as 0, 1 and so on and Garbage Collector may change the generation of an object while relocating an object in the managed heap.

While in the .Net world the GC is the lord of memory, still destructors exist. Similarly the need for manual object release still exists in some cases because not all resources used by managed objects are managed resources. Sometimes a managed object handles resources not belonging to CLR's managed environment, such as operation system's file handles, network connections, device contexts or even not managed memory.

A C# destructor

*   is defined in a class only, structs have no destructors
*   is defined using a tilde (~) and the name of the class
*   is parameterless and has no access modifiers
*   it is not callable from user code
*   it can not be inherited or overloaded

    public class Item
    {
        public Item()
        {
        }
        
        ~Item()
        {
        }
    }

Destructors are called automatically either by the Garbage Collector or when the application terminates.

In C# a destructor is actually an override of the `System.Object.Finalize()` method.

In .Net "Finalizer" is a term synonymous to destructor. Finalizers are called in chain.

The compiler implicitly translates a destructor code into the following.

    ~Item()
    {
        try
        {
            // user code here
        }
        finally
        {
            base.Finalize();
        }
    }

Avoid empty destructors.

Garbage Collector places each object that contains a destructor into a special list called **finalization queue**.

Objects with destructors require two Garbage Collector passes (collections) in order to be released. In the first pass the destructor is called on the object and the object is removed from the finalization queue. In the second pass the object is actually released and its memory is reclaimed.

##### GC methods

The `Collect()` method initiates an immediate garbage collection .

The `SuppressFinalize(Object obj)` instructs the GC not to call the destructor on the specified object.

The `KeepAlive(Object obj)` forces GC not to collect the specified object. That object will be alive from the start of the method which contains the `KeepAlive()` call, until the `KeepAlive()` call itself. So placing the `KeepAlive()` call as the last line on a method ensures that the passed in object will be alive as long as that method executes.

see also:

*   [http://en.wikipedia.org/wiki/Garbage\_collection\_(computer\_science)](http://en.wikipedia.org/wiki/Garbage_collection_(computer_science))

#### IDisposable

Sometimes a class is required to handle unmanaged resources such as file handles or database connections and keep those resources available as long as the object is in scope.

Alive and reachable (in scope) are two different things regarding .Net objects.

An object may be not reachable by any application code, but still alive, sitting quietly in the managed heap and waiting for the next pass of the Garbage Collector.

A class containing unmanaged resources has to ensure that those resources will be deallocated either by an explicit call or, if that is not done, by its destructor. Such a class has to implement the `IDisposable` interface pattern.

    public interface IDisposable
    {
        void Dispose();
    }

Here is a sample `IDisposable` implementation, implemented as the documentation suggests.

    public class Disposable: IDisposable
    {
        private bool disposed = false;    // true if the protected Dispose() is called
	
        /\* The disposing parameter is true when this method is called
           by the public Dispose() method, that is by application code.
           The disposing parameter is false when this method is called 
           by the destructor, that is by the GC.   \*/
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // dispose managed resources here 
                }
	
                // dispose unmanaged resources here
	
                disposed = true;
            }            
        }
	
        ~Disposable()
        {
            Dispose(false);
        }
	
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);  // instructs GC not bother to call the destructor
        }
	 
    }

In the above implementation there are two `Dispose()` methods. A public and a protected.

The public `Dispose()` implements the `IDisposable.Dispose()` method. Application code calls that public non-virtual `Dispose()` while the GC calls the destructor at an appropriate time.

Both, the public `Dispose()` and the destructor, call the protected virtual `Dispose()`. It is that protected `Dispose()` that actually performs any de-allocation.

The execution of the protected `Dispose()` is controlled by two flags. The private field `disposed` prevents method code from executing twice. The parameter `disposing` tells the method what resources to dispose according to the caller. If the caller is the destructor the pattern suggests to ignore managed resources. Unmanaged resources are disposed no matter who the caller is.

The public `Dispose()` also gets the object off the finalization queue because after that `Dispose()` call there is nothing to gain by calling the destructor.

Some classes, like `System.IO.Stream`, which implement `IDisposable`, contain a `Close()` method which actually calls the public `Dispose()` method.

Here is another implementation of the `IDisposable` pattern. This `Disposable` class may serve as a general base class for classes required to handle unmanaged resources.

    public class Disposable : IDisposable
    {
        private bool disposed = false;     
	
	 
        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    DisposeManagedResources();
	
                DisposeUnmanagedResources();
	
                disposed = true;
            }
        }
	
        protected virtual void DisposeManagedResources()
        {
        }
	
        protected virtual void DisposeUnmanagedResources()
        {
        }
	
        ~Disposable()
        {
            Dispose(false);
        }
	
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);   
        }
	
        public bool IsDisposed
        {
            get { return disposed; }
        }
	
    }

The proper handling of a class which implements `IDisposable` requires to use the object inside a `try-finally` block or inside a `using` statement.

The `Dispose()` should be called by application code from inside the `finally` clause of the `try-finally` block.

The `using` statement is used with `IDisposable` objects and it calls their `Dispose()` automatically when the block exits.

Here is two incomplete examples which use the `System.IO.StreamReader` class.

    StreamReader SR = new StreamReader("SomeFile.TXT");
    try
    {
        // code goes here
    }
    finally
    {
        SR.Close();
    }

...

    using (StreamReader SR = new StreamReader("SomeFile.TXT")) 
    {
        // code goes here
    } 

### Pointers and unsafe code

A **pointer** is a type. The data a variable of a pointer type may store is an address of a memory location or the `null` literal.

A variable of a Value type is an easy way to have access to the content the variable represents. The content of such a variable, resides in a memory location and a memory location is identified by its address.

It is possible to assign such a memory address to a variable of a pointer type. It is also possible to access the content of a memory location through a pointer variable.

A pointer is assigned the address of a memory location which contains the actual data. Hence the pointer name.

Although a pointer is a type it is neither a descendant of `System.Object` nor of `System.ValueType`.  There is no `ToString()` method and the rest well known members. Pointer types live in their own kingdom.

Pointer type variables are declared using a base type or `void` and the operator `*`. So, pointer types maybe either **typed** or **untyped** (`void` based).

It is not valid to use a Reference type as a base to declare a pointer type.

The base type of a pointer can be

*   void
*   sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, or bool
*   an enum type
*   another pointer type
*   any user defined struct which contains no Reference types.

Pointers can only be used in an unsafe context.

#### The /unsafe compiler option and the keyword unsafe

The CLR's Common Type System (CTS) acts as a specification of how types are declared and used.

**Type safety** exists when the CLR is able to verify the type of data a variable contains.

In .Net **safe code** is considered a code which uses types that are **verifiable**. Code which uses types that are not verifiable is considered **unsafe code**.

Pointers are unsafe types.

An application may contain unsafe code, only if it is compiled using the `/unsafe` compiler option.

Furthermore a type, that is a class, struct etc, or a method, property or a code block may contain unsafe code only if it is marked using the keyword `unsafe`.

    unsafe public class  UnsafeClass
    {
        static public void Process(int\* x)
        {
        }
    }
    
    public class SafeClass
    {
        unsafe static public void Process(int\* x)
        {
        }
    }
    
    ...
	
    // an unsafe code block
    
    unsafe
    {
        // code here
    }

The `/unsafe` compiler option and the keyword `unsafe` is the only way to use pointers in C#.

Go to `Solution Explorer | right click | Properties | Build` and check the "Allow unsafe code". This sets the `/unsafe` compiler option.

#### The address of operator & and the indication (de-reference) operator \*

Here is an unsafe block example.

    unsafe
    {
        int i = 1234;
	
        int\* P = null;                  // declare a pointer to an integer
        P = &i;                         // assign P the address of i, using the address of operator &
	
        int x = \*P;                     // get the data value the P points to, using the indication operator \*
        MessageBox.Show(x.ToString());  // it is the initial value of i
 
        \*P = 4567;                      // assign the value 4567 as the content of the address P points to            
        MessageBox.Show(i.ToString());  // suddenly i has a new value
    }

Lets shed some light. Pointers are declared using a base type and the operator `*`.

    int\* P;	

The `null` literal value may be assigned to any pointer variable;

    P = null;

The **address of** operator `&` returns the address of a Value type variable or a Value type field member.

    P = &i;

The **indication operator** `*` is used in accessing the data stored to the address a pointer points to.

    int x = \*P

    \*P = 4567;

A pointer may be assigned another pointer, thus making both reference the same address.

    int\* P1;
    int\* P2;
    
    int x = 123;
    P1 = &x;
    P2 = P1; 

The indirection operator `*` is used to access the content of the location a pointer points to.

The indirection operator can not be used with a pointer of type `void*`.

A pointer of type `void*` can be cast to any pointer type and the opposite.

The indirection operator can not be used with a `null` pointer.

#### Memory addresses can be converted to integers and vise versa

Memory addresses are numbered using integers. Thus it is possible to represent a memory address as an integer. Since pointer values are addresses only, pointers can cast to integer values and the opposite.

    unsafe
    {
        int\* P = null;                  // P points to the "null address", that is "address zero"
	
        int x = (int)P;                 // get the address P points to, as an integer
        MessageBox.Show(x.ToString());
	
        P = &x;                         // assign P the address of x
	
        x = (int)P;                     // get the address P points to, as an integer
        MessageBox.Show(x.ToString());
	
        int\* P2 = (int\*)x;              // convert an integer back to a pointer
	
        MessageBox.Show((\*P2).ToString());
    }

It is possible to declare multiple pointers in the same declaration. And again it is possible to assign a pointer to pointer.

    unsafe
    {
        int\* P1, P2;
        int x = 123;
	
        P1 = &x;
        MessageBox.Show(((int)P1).ToString());
	
        P2 = P1;                            // assign a pointer to another
        MessageBox.Show(((int)P1).ToString());
    }

#### Struct pointer types, fixed size buffers and the keyword fixed and pinned variables

A struct can be used as a base type for a pointer type as long as it contains only Value type data.

This is a problem when a struct has to contain a string field and as we know strings are Reference types. The keyword `fixed` may be used with an unsafe struct in order to create a fixed size character buffer.

The `fixed` keyword may be used to create a fixed size buffer of any Value type though.

    unsafe public struct Item
    {
        public fixed char Name\[48\];     // this actually becomes a char\* pointer
        public double Price;
    } 

Fixed size buffers

*   can be used only in an unsafe context
*   can be used as instance fields of a struct
*   can be only single-dimensional arrays
*   required to define their size (no Name\[\] is allowed)

Class instances, that is objects, are subject to garbage collection and after such a collection an object may have changed its location in memory.

The keyword `fixed` is used to mark a code block instructing the GC not to relocate any object enclosed by the fixed statement. This is called "**pinning** ".

Objects enclosed by a `fixed` statement remain in the same memory location until the block ends. Pointers pointing to fixed variables can not be changed.

    Coords c = new Coords(10, 20);      // Coords is class, a class instance is subject to garbage collection
	
    unsafe
    {
        fixed (ulong\* pX = &c.x, pY = &c.y)
        {
            \*pX = 100;
            \*pY = 200;
            
            //pX++;                     // Error:	Cannot assign to 'pX' because it is a 'fixed variable'	
        }
    }

After the code in a `fixed` statement is executed, any pinned variables are unpinned and are subject to garbage collection again.

#### The keyword stackalloc

Using the keyword `stackalloc` makes it possible to allocate a block of memory on the stack and make a local variable point to it.

`stackalloc` is valid with local variables only.

`stackalloc` variables are not subject to garbage collection, so no pinning with the keyword `fixed` is required.

The memory allocated by a `stackalloc` statement is automatically de-allocated when the enclosing method terminates.

The CLR performs **buffer overrun detection** against `stackalloc` variables. When the CRL detects a buffer overrun it terminates the application as soon as possible. Buffer overruns may be happened because a malicious code tries to execute and the CLR has no way to know if a certain buffer overrun is because of a coding error or because of a security threat.

    unsafe
    {
        const int BufSize = 92;
	
        char\* Buf = stackalloc char\[BufSize\];
	 
        ...
    }

#### The pointer member operator ->

The pointer member operator `->` is used in accessing a member of a struct through a pointer variable.

    Item item = new Item();
    Item\* pItem = &item;
    pItem->Price = 2.5;

#### Pointer arithmetic

The increment and decrement operators, `++` and `--`, may be used with pointer expressions except of `void*` types. Those operatos increment or decrement the address stored to the pointer by `sizeof(PointerType)`.

The size of a pointer type is 32 bits in 32bit systems.

    Item\* pItems = stackalloc Item\[2\];
    pItems++;                                           // make pItems to point to the second element
    pItems--;                                           // decrease pItems by an element

Similarly adding or subtracting a `int`, `uint`, `long`, or `ulong` value to a pointer variable increments or decrements the address stored to the pointer by `sizeof(PointerType)` times the used value.

    pItems + 1;
    pItems - 1;

#### Indexing a pointer

Memory location content may accessed by indexing a pointer variable just like an array.

    unsafe
    {
        int\* P = stackalloc int\[2\];
        P\[0\] = 1234;                        // assign an int value as the content to the location P\[0\] points to
        P\[1\] = 5678;                        // assign an int value as the content to the location P\[1\] points to
	
        int\* P2 = P;
        int x = (int)P2;                    // get the address of P\[0\]
        MessageBox.Show(x.ToString());      // display the address
        MessageBox.Show(P2\[0\].ToString());  // display the content
	
        P2++;                               // increment the pointer
        x = (int)P2;                        // get the address of P\[1\]
        MessageBox.Show(x.ToString());      // display the address
        MessageBox.Show(P2\[0\].ToString());  // display the content
    }

#### Pointer comparisons

The comparison operators `== != < > <= >=` may used to compare pointers of any type. Those operators actually compare the pointer addresses as if they were unsigned integers.

see also:

*   [http://en.wikipedia.org/wiki/Pointers](http://en.wikipedia.org/wiki/Pointers)

#### Heap and stack

When the execution of an application starts, a large memory block is allocated by the operating system to that application. That memory is divided into two parts. The **heap** and the **stack**.

Class instances, that is Reference type objects created by using the `new` operator, are allocated using **heap** memory. If there is no more free heap memory to allocate an object, an `OutOfMemoryException` is thrown.

Any time a method is called it is placed in the **stack** along with its parameters and the return address. When the method returns, the method is extracted from the stack. Stack is also known as **call stack**, **execution stack**, **run-time stack**, **function stack** etc.

A, so called, **stack frame** consists of the method pointer, method parameters, local variables and the return address of the method. Any time a method is called, an appropriate stack frame is allocated on the stack and the stack grows. Any time a method returns, the corresponding stack frame is deallocated and the stack shrinks. If there is no more stack memory to allocate a stack frame, a `StackOverflowException` is thrown.

Stack pointer is a pointer which points to the end of the last stack frame. Stack pointer indicates the current top of the stack.

see also:

*   [http://en.wikipedia.org/wiki/Call\_stack](http://en.wikipedia.org/wiki/Call_stack)

#### Recursive methods

A recursive method is a method which recursively calls itself. Recursive methods grow the stack and they must provide a condition to stop recursion and exit the stack. Otherwise a StackOverflowException is near.

    void RecursiveMethod(int x)
    {
        if (x > 5)
            return;
	
        x++;
	
        RecursiveMethod(x);
    }

see also:

*   [http://en.wikipedia.org/wiki/Recursion\_(computer\_science)](http://en.wikipedia.org/wiki/Recursion_(computer_science))

#### IDE menus and tools related to classes

Examine the menu `View | Class View`

Examine the menu `View | Object Browser`

Advanced language issues
------------------------

This part describes advanced language issues such as Attributes and Generics.

### Attributes

Attributes are used to mark code elements such as types, fields, properties and methods.

Attributes describe the nature and provide additional information of a code element to the CLR thus affecting application behavior.

Attributes become part of the metadata information.

Predefined attributes have a keyword-like meaning to the compiler.

Attributes are used in describing additional characteristics of a code element such as security and serialization behavior or visibility of a control at design-time.

#### Attribute class and applying attributes

Attributes are classes which ultimately inherit from `System.Attribute` class. The FCL declares many `Attibute` class descendants in various namespaces and for various purposes.

Here are some predefined attribute classes

    System.CLSCompliantAttribute
    System.ContextStaticAttribute
    System.FlagsAttribute
    System.SerializableAttribute
    System.ObsoleteAttribute

An attribute is placed immediately before the code element and is surrounded by square brackets. Inside the brackets the name of the class attribute is placed, perhaps ommitting the `Attibute` last word from the class name, and then, inside a parentheses pair in a constructor-like syntax, a series of possible parameters.

Here is an example with all possible combinations.

    //\[FlagsAttribute()\]
    //\[FlagsAttribute\]
    //\[Flags()\]
    \[Flags\]
    enum Day { Sun = 0, Mon = 1, Tue = 2, Wed = 4, Thu = 8, Fri = 16, Sat = 32 };

Here is an example using the `BrowsableAttribute` class which accepts parameters. The `BrowsableAttribute` specifies whether a property or event should be displayed in the **Properties window** of the MS Visual Studio.

    public class UselessComponent : Component
    {
        \[Browsable(false)\]
        public int UselessProperty { get; set; }
	
        \[Browsable(true)\]
        public string Name { get; set; }
    }

> **NOTE** : Component descendant classes contained in an application or library are automatically displayed by the Tool box window and may be dropped to a form or user control.

An attribute may not be applicable to all code elements. The `System.AttributeTargets` enum type specifies the code elements on which it is valid to apply a certain attribute.

    public enum AttributeTargets
    {
        All = 0x7fff,
        Assembly = 1,
        Class = 4,
        Constructor = 0x20,
        Delegate = 0x1000,
        Enum = 0x10,
        Event = 0x200,
        Field = 0x100,
        GenericParameter = 0x4000,
        Interface = 0x400,
        Method = 0x40,
        Module = 2,
        Parameter = 0x800,
        Property = 0x80,
        ReturnValue = 0x2000,
        Struct = 8
    }

An `Attribute` class maybe marked with the `System.AttributeUsageAttribute` attribute in order to define the possible targets and other characteristics of that attribute.

For example the `CLSCompliantAttribute` is declared as following

    \[AttributeUsageAttribute(AttributeTargets.All, Inherited = true, AllowMultiple = false)\]
    public sealed class CLSCompliantAttribute : Attribute
    {
    ...
    }

The Inherited named parameter determines whether the attribute extends its scope to derived classes and overriding members. The AllowMultiple named parameter determines whether the attribute can be declared more than once on a given program element. There are two types of parameters in an attibute: Positional and named. Positional parameters are required and must come before any named parameters while named parameters are optional. Positional parameters are actually parameters of one of the many constructors the individual Attribute class may have while named parameters are read/write properties of that same Attribute class. When an attribute defines multiple targets, it is possible to differentiate its application scope by using an attribute target and a colon.

	
    \[assembly: CLSCompliant(true)\]
	
	
	

#### Custom attributes

A custom attribute is an `Attribute` class descendant which is marked by the `AttributeUsageAttribute`. Being a class it may provide methods and properties as any other class.

    \[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)\]
    public class CodeHistoryAttribute : Attribute
    {
        private string developer;
        private string revision; 
        
        public CodeHistoryAttribute(string Developer, string Revision)
        {
            this.developer = Developer;
            this.revision = Revision;
        }
	
        public string Developer { get { return developer; } }
        public string Revision { get { return revision; } }
        public string Comments { get; set; } 
    }
	
	
    \[CodeHistory("teo", "1.0", Comments = "this is the initial version")\]
    public class Demo
    {
        public void Exec()
        {
        }
    }

It is possible to access custom attribute information of a code element. One way to achieve this is to use one of the overloaded versions of the `Attribute.GetCustomAttribute()` static method.

    CodeHistoryAttribute a = (CodeHistoryAttribute)Attribute.GetCustomAttribute(typeof(Demo), typeof(CodeHistoryAttribute));
	
    string S = "Developer: " + a.Developer + Environment.NewLine +
               "Revision: " + a.Revision + Environment.NewLine +
               "Comments: " + a.Comments;  

### Common Language Runtime, Application Domains and Assemblies

The .Net is actually two things:

*   the Common Language Runtime (CLR)
*   and the Framework Class Library (FCL or BCL).

CLR is an application execution environment. The CLR makes it possible to code and compile an application once and then execute it in any platform or CPU the CLR supports. The CLR provides a host of services. Some of them are

*   Memory management
*   Thread management
*   Exception handling
*   Garbage collection
*   Security

The Framework Class Library (FCL) is a huge class library provided by the CLR. Classes are organized into hierarchical namespaces and contain classes for building user interfaces for desktop and web applications, accessing data, communicating, encrypting etc.

.Net is a standard administrated by European Computer Manufacturers Association (ECMA).

Microsoft .Net is Microsoft's implementation of .Net. There are at least two other implementations,

*   tthe mono project (http://www.mono-project.com/)
*   and the (now decommissioned) DotGNU project (http://www.gnu.org/software/dotgnu/)

see also:

*   [http://www.ecma-international.org/](http://www.ecma-international.org/)
*   [http://en.wikipedia.org/wiki/Common\_Language\_Runtime](http://en.wikipedia.org/wiki/Common_Language_Runtime)
*   [http://en.wikipedia.org/wiki/Base\_Class\_Library](http://en.wikipedia.org/wiki/Base_Class_Library)
*   [http://en.wikipedia.org/wiki/Framework\_Class\_Library](http://en.wikipedia.org/wiki/Framework_Class_Library)

#### Common Intermediate Language (CIL)

Compilers that target CLR compile to Common Intermediate Language (CIL), formerly called Microsoft Intermediate Language (MSIL). CIL is an object-oriented assembly language and it is actually a CPU and platform independent assembly-like instruction set and can be executed in any environment the CLR supports. see also:

*   [http://en.wikipedia.org/wiki/Common\_Intermediate\_Language](http://en.wikipedia.org/wiki/Common_Intermediate_Language)

#### Common Language Infrastructure (CLI)

CLR is the actual implementation of the Common Language Infrastructure (CLI) open specification standard (ECMA-335 and ISO/IEC 23271). CLI is a specification regarding the executable code and the runtime environment. CLI's design allows multiple high level programming languages to be used in writing applications, as long as they comform to the standard. Applications are written and compiled once and they are able to run in any platform the CLR supports. CLI makes it possible to have a single application written in multiple high level programming languages.

Among other things, CLI defines the following

*   the Common Type System (CTS)
*   the metadata, that is type information
*   the Common Language Specification (CLS)
*   the Virtual Execution System (VES)

CTS defines a set of data types that are common to all programming languages targeting CLR. Metadata defines type information in a language neutral manner. So type information is understandable by any language or tool targeting CLR.

CLS defines a set of rules, such as member visibility and instance construction that are common to all programming languages targeting CLR. CLS-compliant code of one language can interoperate with CLS-compliant code of another language. CLS is a subset of CTS.

VES loads and executes CLR applications. VES is the actual executor of the CIL bytecode.

see also:

*   [http://en.wikipedia.org/wiki/Common\_Language\_Infrastructure](http://en.wikipedia.org/wiki/Common_Language_Infrastructure)

#### Managed and unmanaged code

**Managed code** is application code which is executed under the management of a virtual execution machine like VES. **Unmanaged code** is application code which is executed directly by the computer's CPU.

Code that targets the CLR is managed code, since the CLR manages the whole code execution. Code that does not target CLR is unmanaged code.

Manage code is type safe code according to rules befined by the CTS. Manage code is said to be "**verifiable** " because its type safety is verified.

see also:

*   [http://en.wikipedia.org/wiki/Managed\_code](http://en.wikipedia.org/wiki/Managed_code)

#### Application and Process

**Application** is a term used in computing to denote a software tool which functions and operates on a computer, by means provided by the computer, possibly displaying some sort of user interface. An application enables people to use the computer in order to accomplish a specific task and is what is commonly called computer program.

In a multi-tasking environment it is required to isolate running applications, otherwise an application may affect the execution of another application. Traditionally this isolation context is called "**a process** ". An operating system **process** forms the boundaries of the execution of an application. In an unmanaged execution environment, those process boundaries prevent an application from directly accessing memory addresses or calling code which belongs to another running application.

**Process** is an operating system kernel object. When an application starts the operating system creates a process object associated with that application. An application may spawn multiple processes though.

see also:

*   [http://en.wikipedia.org/wiki/Process\_(computing)](http://en.wikipedia.org/wiki/Process_(computing))
*   System.Diagnostics.Process class

#### Application domains

In the CLR, managed code must successfully pass a verification test before it is allowed to run. That verification process prevents an application from accessing invalid memory addresses or perform any other not valid action that may harm other running applications. The CLR's ability to verify code resembles the process boundaries isolation offered by an operating system process and it comes with much lower performance cost.

**Application domains** is the CLR's way of imposing isolation between running applications. An application domain is contained within an operating system process. A single operating system process may contain several application domains. When a CRL application starts, a default application domain is created inside an operating system process.

see also:

*   [http://en.wikipedia.org/wiki/Application\_Domain](http://en.wikipedia.org/wiki/Application_Domain)
*   `System.AppDomain` class

#### Assemblies

An assembly contains CIL code, metadata, that is type information, dependency information, security information and resources.

An assembly is the unit of deployment, versioning and security in the .Net system.

There are two types of assemplies: application assemblies (EXE) and library assemblies (DLL).

An application assembly that starts an application must contain an entry point, such as a `Main()`.

CLR recognizes the type of an assembly by examining a special flag each assembly contains. File extension is irrelevant. That is a library assembly may have either `.dll` or `.exe` as its extension.

The CIL code an assembly contains is compiled into machine code at runtime by the CLR Just In Time (JIT) compiler.

An assembly actually contains three things

*   1\. a manifest which contains name, version and culture information, dependency and security requirements and metadata information for all contained types
*   2\. one or more, so called, modules, that is code files compiled into CIL code
*   3\. resources

A module may be written in a different programming language although this happens very rarely. For more information on creating multi-language assemblies check the `/addmodule` compiler option. MS Visual Studio does not support multi-language assemblies.

It is also possible to create multi-file assemblies using command line tools such as the Assembly Linker (Al.exe). More information can be found in the online documentation.

For the contents of an assembly to be available to an application, the application has to define a **reference** to that assembly by using either the `/reference` compiler option or the References item of the project tree in the **Solution Explorer**.

For an assembly to be executed it must be loaded into an application domain. A typical application loads several assemblies into a single application domain.

It is possible to explicitly load an assembly into an application domain by code.

It is not possible to unload an assembly. Only a complete application domain can be unloaded.

see also:

*   [http://en.wikipedia.org/wiki/.NET\_assembly](http://en.wikipedia.org/wiki/.NET_assembly)
*   `System.Reflection.Assembly` class

#### GAC, shared and private assemblies

Assemblies that may be used by multiple applications are installed in the **Global Assembly Cache** (GAC) and they are called **shared assemblies**. GAC is found at `C:\Windows\Assembly`.

For an assembly to be installed in GAC it must have a **strong name**. A strong name consists of the assembly's identity which is its simple text name, version number, and culture information, plus a public key and a digital signature.

MS Visual Studio and other IDEs can be used to assign a strong name to an assembly. Also a strong name can be generated by the Assembly Linker (Al.exe) tool which comes with the SDK.

Finally a strong name can be inserted by using the `AssemblyKeyFileAttribute` or the `AssemblyKeyNameAttribute` attributes directly in source code.

Assemblies that are not in GAC and are used locally by an application are called **private assemblies**. Private assemblies do not require a strong name because versioning information and security standards are more flexible than for shared assemblies.

The Global Assembly Cache command line tool (Gacutil.exe) makes it possible to inspect and manipulate the contents of the global assembly cache.

#### Common Language Runtime hosts (Application Domain hosts)

The execution of any type of CLR application requires a CLR host. A CLR host is a managed or unmanaged application which

*   loads the CLR into an operating system process,
*   creates application domains inside that process,
*   and loads assemblies into those application domains.

Windows shell is a CLR host which starts applications (.exe) from the shell.

ASP.NET is also a CLR host which loads the CLR into a process which in turn handles web requests submitted to a web server.

#### AppDomain class and Assembly class

The `System.AppDomain` class corresponds to the application domain. The `System.Reflection.Assembly` class corresponds to the assembly.

### Reflection

**Reflection** is the procedure by which application code can inspect its content regarding types, and query those types in order to discover their members. Reflection is about type information at runtime.

In CLR, Reflection is possible because of metadata information stored inside an assembly.

Reflection in CLR constructs objects which describe type information regarding types contained in assemblies, modules and types.

Reflection can also be used to dynamically create an instance of a type and invoke a certain member of the type.

The `System.Type` class is the primary tool of the provided reflection functionality. `System.Type` provides members which return information about a type, such as its constructors, methods, fields and properties. Those `System.Type` members return information using instances of classes with descriptive names. Here are some of the returned types

    System.Reflection.MemberInfo
    System.Reflection.ConstructorInfo
    System.Reflection.MethodInfo
    System.Reflection.PropertyInfo
    System.Reflection.FieldInfo
    System.Reflection.EventInfo

`System.Type` also provides a number of bool read only properties, again with descriptive names, such as

    IsClass
    IsValueType
    IsEnum
    IsInterface
    IsByRef
    IsArray
    IsNested
    IsSealed

`System.Type` also provides a number of utility methods such as

    InvokeMember()
    IsSubclassOf()
    GetType(string typeName) 

The `AppDomain` and `Assembly` class also provide reflection capabilities.

#### Using Reflection

Getting the currently executing assembly and an array of the types it contains

    Assembly A = Assembly.GetExecutingAssembly();           // another way to get the current assembly
    Type\[\] types = A.GetExportedTypes();                    // gets an array of all public types

Supposing there is a `Lessons.dll` assembly with the following code

    namespace Lessons
    {
        public class Item
        {
            public Item(string Name, double Price)
            {
                this.Name = Name;
                this.Price = Price;
            }
	
            public void IncreasePriceBy(double Percent)
            {
                Price += Price \* Percent / 100;
            }
	
            public string Name { get; set; }
            public double Price { get; set; }
        }
    }

Loading an assemply dynamically

    Assembly LessonsAssembly;       // a reference for a dynamic loaded assembly
    
    ...
    
    if (File.Exists(FileName))
        LessonsAssembly = Assembly.LoadFrom(FileName);      // load the Lessons.dll assembly dynamically 

Accessing types and member info from an assembly

    Type t = LessonsAssembly.GetType("Lessons.Item");       // get a type from the dynamically loaded assembly
    PropertyInfo\[\] props = t.GetProperties();               // get the properties of a type
    MethodInfo\[\] methods = t.GetMethods();                  // get the methods of a type

Invoking a constructor

    ConstructorInfo ci = t.GetConstructor(new Type\[\] {typeof(string), typeof(double) });    // get a constructor of a type
    object o = ci.Invoke(new object\[\] {"Hard disk", 5 });                                   // invoke the constructor

Getting and setting property values and invoking a method

    pi = t.GetProperty("Name");
    pi.SetValue(o, "Mouse", null);                          // set the value of a property
    MessageBox.Show(pi.GetValue(o, null).ToString());       // display its value
	
    MethodInfo mi = t.GetMethod("IncreasePriceBy");         // get a method
    mi.Invoke(o, new object\[\] { 10 });                      // invoke the method, the method affects the Price property

### Lambda Expressions

A **lambda expression** is a form of an **anonymous method** introduced in C# 3.0.

Anonymous methods of the C# 2.0 and lambda expressions of C# 3.0 are collectively known as **anonymous functions**. Both forms are used in creating delegate values "on the fly" and may contain expessions and statements.

Lambda expressions are also used in creating **Expression Trees**. Here is an old sample, taken from the Delegates section above and enhanced with a lambda expression example.

    public delegate void StringDelegate(string Text);
	
    public void Display(string S)
    {
        MessageBox.Show("Named method: " + S);
    }
	
    private void button1\_Click(object sender, EventArgs e)
    {
        // a named method
        StringDelegate d = Display;
	
	
        // an anonymous method
        d += delegate(string S)
        {
            MessageBox.Show("Anonymous method: " + S);
        };
	
	
        // a lambda expression
        d += (S) =>
        {
            MessageBox.Show("Lambda expression: " + S);
        };
	
        d("Hi there!");
    }

The operator `=>` is called the **lambda operator** (and it has nothing to do with the `>=` relational operator). The lambda expression operator resembles an arrow, just to emphasize that whatever is at its left side "goes to" the right side as an input parameter to an anonymous method. Left side parameters, if any, are passed to the right side code block.

    ( parameters ) => { code block };

If the code block contains just a single expression then block braces are optional.

    // a lambda expression
    d += (S) => MessageBox.Show("Lambda expression: " + S);

##### Expression Lambda and Statement Lambda

A lambda expression, which, at the right side, has just a single expression, without braces, is called **Expression Lambda**.

Only Expression Lambdas are used in Expression Tree construction.

A lambda expression, which, at the right side, has more than a single expression enclosed in braces is called **Statement Lambda**.

##### Parentheses and parameters

Parentheses required when there are **no parameters at all or there are more than a single paremeter**.

A single parameter makes parentheses optional.

    // a lambda expression
    d += S =>
    {
        MessageBox.Show("Lambda expression: " + S);
    };

Parameter types may also, optionally, be specified.

    // a lambda expression
    d += (string S) =>
    {
        MessageBox.Show("Lambda expression: " + S);
    };

Sometimes it is not possible for the compiler to infer parameter types. In that case parameter types are required.

A lambda expression may use multiple parameters separated by commas.

A lambda expression may contain a `return` statement. That `return` statement does not cause the enclosing method to return.

    public delegate int MathDelegate(int a, int b, int c);
	
    private void button2\_Click(object sender, EventArgs e)
    {
        // multiple parameters
        MathDelegate d = (x, y, z) => { return x + y + z; };
	
        string S = d(1, 2, 3).ToString();
	
        MessageBox.Show(S);
    }

see also:

*   [http://en.wikipedia.org/wiki/Lambda\_expressions](http://en.wikipedia.org/wiki/Lambda_expressions)

#### Variable scope in lambda expressions

A lambda expression defined in a method body can use any accessible variable, which may be either a variable local to the enclosing method or member of the enclosing type.

A lambda expression defined as a member field in a class can use only static fields of the enclosing type.

Variables captured that way by a lambda expression are stored with the lambda expression and they are not garbage collected as usually.

    /\* a lambda expression defined outside of any method, it is actually a field
       such a lambda expression can use only static fields \*/
    int a = 1;
    static int b = 2;
    MathDelegate d = (x, y, z) => { return x + y + z + b; };
	
    private void button3\_Click(object sender, EventArgs e)
    {
        int c = 3;
	
        string S = d(a, b, c).ToString();
        MessageBox.Show(S);
	
        MathDelegate d2 = (x, y, z) => { return x + y + z + a + b + c; };
	
        S = d2(a, b, c).ToString();
        MessageBox.Show(S);
    }

`ref` and `out` parameters passed to an enclosing method are not directly accessible by a lambda expression.

### Generics

**Generics** are types (such as classes, structs, interfaces, delegates and arrays) and methods, which contain type placeholders, called **type parameters**, in their declaration, for one or more types, unknown at compile-time, thus giving to the type or method declaration, a generic form.

When a generic type is instantiated, those type placeholders are assigned concrete types, called **type arguments**, thus transforming the generic type or method into a strongly-typed one.

    public interface IGenericList<T>
    {
        int Add(T Item);
        void Insert(int Index, T Item);
        void Remove(T Item);
        void RemoveAt(int Index);

        int Count { get;}
        T this\[int Index\] { get; }    
    }

In a generic type, such as the above, type parameters are used when defining members of the type, such as fields, properties and methods and inside code. Inside that type, those type parameters may be used in typecasting too.

A generic type or method may be instantiated or called in many different circumstances, and possibly each time with different combinations of type arguments.

Here is a generic class which implements the above generic interface.

    public class GenericList<T> : IGenericList<T>
    {
        private ArrayList list = new ArrayList();

        public int Add(T Item)
        {
            Insert(list.Count, Item);
            return list.Count;
        }

        public virtual void Insert(int Index, T Item)
        {
            list.Insert(Index, Item);
        }

        public virtual void Remove(T Item)
        {
            list.Remove(Item);
        }

        public void RemoveAt(int Index)
        {
            Remove((T)list\[Index\]);         // type-casting using a type parameter
        }

        public int Count
        {
            get { return list.Count; }
        }

        public T this\[int Index\]            // generic property
        {
            get { return (T)list\[Index\]; }  // type-casting using a type parameter
        }
    
    }

And here is how to use the above generic class, using string as the type argument.

    GenericList<string> list = new GenericList<string>();

    list.Add("C#");
    list.Add("generics");

    string S = "";

    for (int i = 0; i < list.Count; i++)
        S += list\[i\] + " ";

    MessageBox.Show(S);
	

And here is that same generic class using integer as the type argument.

    GenericList<int> list = new GenericList<int>();

    list.Add(1);
    list.Add(2);
    list.Add(3);

    int total = 0;

    for (int i = 0; i < list.Count; i++)
        total += list\[i\];

    MessageBox.Show(total.ToString());

see also:

*   [http://en.wikipedia.org/wiki/Generic\_programming](http://en.wikipedia.org/wiki/Generic_programming)
*   [http://msdn.microsoft.com/en-us/library/aa479859.aspx](http://msdn.microsoft.com/en-us/library/aa479859.aspx)
*   [http://msdn.microsoft.com/en-us/library/aa479866.aspx](http://msdn.microsoft.com/en-us/library/aa479866.aspx)

#### Terminology

Following are terms used with generics.

##### Type Parameter

A **type paremeter** is used in a generic type or method declaration as a placeholder for an actual type which is going to be specified upon instantiation or calling.

    class SomeClass<A, B> {...}        // A and B are type parameters
    
    T SomeMethod(T x, T y) {...}       // T is a type parameter

##### Generic Type Argument

A generic **type argument** is the actual type a client code specifies to be used in place of a type parameter.

    class SomeClass<A, B> {...}
    
    ...
    
    SomeClass<int, double> g = new SomeClass<int, double>();    // int and double are type arguments

##### Constructed Type

A **constructed type** is a generic type variable, parameter or field, which contains at least **one generic argument**.

    class SomeClass<A, B> {...}

    ...

    SomeClass<A, B> a;
    SomeClass<int, B> b;
    SomeClass<A, string> c; 

Specifying type arguments for generic type parameteres of a generic type constructs the actual run-time strongly-typed type, thus allowing the compiler to perform compile-time type cheching.

##### Open Constructed Type

An **open constructed type** is a generic type variable, parameter or field, which contains at least **one generic type parameter**.

    class SomeClass<A, B> {...}

    ...

    SomeClass<A, B> a;
    SomeClass<int, B> b;
    SomeClass<A, string> c;

##### Closed Constructed Type

A **closed constructed type** is a generic type variable, parameter or field, which contains **no generic type parameter**.

    class SomeClass<A, B> {...}

    ...

    SomeClass<int, int> a;
    SomeClass<double, int> b;
    SomeClass<int, string> c;

##### Type Inference

**Type inference** is the compiler's ability to conclude the actual type of a type argument passed to a generic method.

    T Infer(T a)
    {
        return a;
    }
 
    ...

    int i = Infer(123);
    string S = Infer("C# generics");

##### Generics are not covariant

**Covariance** in a type system refers to **type compatibility**.

With strong types it is perfectly valid to write

    class Base { }
    class Derived : Base { }
    
    ...
	
    Base b = new Derived();

Generics are **invariant**.

There is **no compatibility between two generics with different type arguments**.

A generic with a derived type argument can not be assigned to a generic with a base type argument.

Here is an example

    class Generic<T> {}
    
    ...

    Generic<Base> b2 = new Generic<Derived>();  // does not compile

A Generic value can not be assigned to a Generic even though a Derived value is a Base value too.

see also:

*   [http://en.wikipedia.org/wiki/Covariance\_and\_contravariance\_(computer\_science)](http://en.wikipedia.org/wiki/Covariance_and_contravariance_(computer_science))

#### The generic List<T> class

BCL provides the generic `System.Collections.Generic.List<T>` class already, which is a generic list used in constructing strongly-typed lists of objects of various types.

The size of a `List<T>` list, that is the number of contained elements, is dynamic. It is increased and decreased as required, when adding or removing elements.

The `List<T>` provides an **indexer property** so elements of that list can be accessed by index. It also provides various methods for sorting, searching and in general manipulating the list.

    List<int> list = new List<int>();

    list.Add(1);
    list.Add(2);
    list.Add(3);

    int total = 0;

    for (int i = 0; i < list.Count; i++)
        total += list\[i\];

    MessageBox.Show(total.ToString());

The `System.Collections.ArrayList` class is still available though.

#### Arrays with a lower bound of zero and the generic IList<T> interface

A single dimensional array with a lower bound of zero it automatically implements the `IList<T>` generic interface.

    int\[\] a = { 0, 1, 2 };
    IList<int> list = a;

The resulting list is of a fixed size. Elements can not be added or removed.

#### Generic methods

A generic method may belong to a generic or non-generic type.

Methods belonging to a generic type could be generic or non-generic.

A generic method has **two parameter lists** : one that comes right after the name of the method, which contains type parameters and a usual list of formal parameters.

Type parameters declared in the type parameter list, can be used to define the return type or the types of the formal parameters.

    private void GenericMethod<T>(T x)
    {
        string S = x.GetType().Name + ": " + x.ToString();
        MessageBox.Show(S);
    }

    ...

    GenericMethod(123);
    GenericMethod(12.3);
    GenericMethod("123");

Generic methods may be oveloaded and may use more than one type parameter.

    private void GenericMethod<T, T2>(T x, T2 y)
    {
        string S = x.GetType().Name + ": " + x.ToString() + Environment.NewLine +
                   y.GetType().Name + ": " + y.ToString();
        MessageBox.Show(S);
    }

    ...

    int a = 123;
    string b = "generics";

    GenericMethod(a, b);

#### Generic inheritance

It is valid to inherit from a generic class.

    public class DerivedList<T> : GenericList<T>
    {
        private int insertions = 0;
        private int deletions = 0;

        public override void Insert(int Index, T Item)
        {
            base.Insert(Index, Item);
            insertions++;
        }

        public override void Remove(T Item)
        {
            base.Remove(Item);
            deletions++;
        }
    }

It is valid to supply typed parameters when inheriting, in order to create a strongly-typed derived class.

    public class IntegerList : GenericList<int>
    {
    }

It is also valid to expand the inherited list of type parameters.

    public class DoubleGenericList<T, T2> : GenericList<T>
    {
    } 

#### Constraints on generic type parameters

Constraints are restrictions placed, by the author of a class, on generic type parameters regarding their type.

Constraints are defined by using the keyword `where`.

A user of that class has to conform to constaint restrictions, otherwise a compile-time error occurs.

Constraints may limit a type parameter to a type which

*   inherits from a specified base class, e.g. `class Generic<T> where T: SomeClass {}`
*   implements a specified interface, e.g. `class Generic<T> where T: ISomeInterface {}`
*   has a default constructor, e.g. `class Generic<T> where T: new() {}`
*   is a Reference type, e.g. `class Generic<T> where T: class {}`
*   is a Value types, e.g. `class Generic<T> where T: struct {}`
*   inherits from another type parameter, e.g. `class Generic<T, U> where T: U {}`

It is possible to have multiple `where` clauses for multiple type parameters or a `where` clause for a single type parameter declaring more than one constraint. In this latter case, if a `new()` constraint is required then it should be the last one.

    public class SomeClass<A, B>
        where A : IList, new()
        where B : IEnumerable
    {
    }

The reference, in case 4 above, can be of any Reference type, such as class, interface or delegate.

The case 6 above is known as the **naked type constraint**.

Type parameters with no constraints are known as **unbounded type parameters**.

It is possible to use constraints with inherited generic classes.

    public class GenericValueList<T> : GenericList<T> where T : struct
    {
    }

Here is an example of a constraint applied to a generic `Sorter` class.

    public class Sorter<T> where T : IComparable
    {
        public T\[\] Sort(GenericList<T> SourceList)
        {
            T\[\] elements = new T\[SourceList.Count\];

            for (int i = 0; i < elements.Length; i++)
                elements\[i\] = SourceList\[i\];

            Array.Sort(elements);

            return elements;
        }
    }

    ...

    GenericList<int> list = new GenericList<int>();

    list.Add(3);
    list.Add(1);
    list.Add(2);

    Sorter<int> sorter = new Sorter<int>();

    int\[\] elements = sorter.Sort(list);

    string S = "";

    foreach (int i in elements)
        S += i.ToString() + Environment.NewLine;

    MessageBox.Show(S);

Constraints can be used with generic methods too.

    T GenericMethod<T>(T a) where T: IEnumerable
    {
       ...
    }

#### Generic delegates

It is possible to define generic delegates.

    public delegate void GenericDelegate<T>(T sender);

Here is a generic class which uses an event based on that generic delegate.

    public class Employee<T>
    {

        private T department = default(T);  // provides the default value for the actual type

        public Employee(T Department)
        {
            department = Department;
        }

        public override string ToString()
        {
            return "Employee department: " + department.ToString();
        }

        public T Department
        {
            get { return department; }
            set
            {
                if (!department.Equals(value))
                {
                    department = value;
                    if (DepartmentChanged != null)
                        DepartmentChanged(this);
                }
            }
        }

        public event GenericDelegate<Employee<T>> DepartmentChanged;
    }

And here is how to link methods to that generic event.

    void GenericHandler<T>(T sender)
    {
        MessageBox.Show(sender.ToString());     // only System.Object members are available to a generic parameter
    }

    void ConcreteHandler(Employee<int> sender)
    {
        MessageBox.Show(sender.ToString());
    }
    
    ...

    Employee<string> em = new Employee<string>("sales");            
    em.DepartmentChanged += new GenericDelegate<Employee<string>>(GenericHandler);  // this is really ugly

    em.Department = "IT";

    Employee<int> em2 = new Employee<int>(100); 
    em2.DepartmentChanged += ConcreteHandler;   // this is better

    em2.Department = 101;

#### Predefined generic delegates

BCL includes a number of generic delegates. The most commonly used is the

    public delegate void EventHandler<TEventArgs>(Object sender, TEventArgs e) where TEventArgs : EventArgs

The following delegates are designed to be used mostly with the static generic methods of the `Array` class and the `List<T>` class.

    public delegate void Action<T>(T obj)
    public delegate void Action<T1, T2>(T1 arg1, T2 arg2)
    public delegate void Action<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
    public delegate void Action<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    public delegate int Comparison<T>(T x, T y)
    public delegate TOutput Converter<TInput, TOutput>(TInput input)
    public delegate bool Predicate<T>(T obj)

#### Array and List<T> generic methods

The `Array` and the `List<T>` classes provide a great number of generic methods.

    public abstract class Array : ICloneable, IList, ICollection, IEnumerable
    {
       // some of the generic members 
       public static bool Exists<T>(T\[\] array, Predicate<T> match);
       public static T Find<T>(T\[\] array, Predicate<T> match);
       public static T\[\] FindAll<T>(T\[\] array, Predicate<T> match);
       public static int FindIndex<T>(T\[\] array, Predicate<T> match);
       public static T FindLast<T>(T\[\] array, Predicate<T> match);
       public static void ForEach<T>(T\[\] array, Action<T> action);
       public static int  IndexOf<T>(T\[\] array, T value);       
       public static int LastIndexOf<T>(T\[\] array, T value);   
       public static void Sort<T>(T\[\] array, Comparison<T> comparison); 
       
       // ... other members here
    }


    public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IList, ICollection, IEnumerable
    {
       // some of the generic members 
       public bool Exists(Predicate<T> match);
       public T Find(Predicate<T> match);
       public List<T> FindAll(Predicate<T> match);
       public int FindIndex(Predicate<T> match);
       public T FindLast(Predicate<T> match);
       public void ForEach(Action<T> action);
       public int IndexOf(T item);
       public int LastIndexOf(T item);
       public void Sort(Comparison<T> comparison);
       public T\[\] ToArray();

       // ... other members here
    }

All those methods rely on a passed in callback, a delegate in .Net parlance, in order to achieve their task.

Here is an example using the `List<T>` class and the `delegate void Action<T>(T obj)`.

    int globalTotal = 0;

    /\* to be used with delegates of type
       delegate void Action<T>(T obj)  \*/
    void TotalHandler(int obj)
    {
        globalTotal += obj;
    }

    ...
 
    List<int> list = new List<int>();

    list.Add(1);
    list.Add(2);
    list.Add(3);

    list.ForEach(TotalHandler);                              // using a generic delegate handler
    MessageBox.Show(globalTotal.ToString());

    int localTotal = 0;
    list.ForEach(delegate(int z)                             // using an anonymous method
    {
        localTotal += z;
    });


    Action<int> action = x => localTotal += x;              // define a lambda expression variable

    list.ForEach(action);                                   // using a lambda expression variable
    list.ForEach(x => localTotal += x);                     // using a lambda expression directly
    MessageBox.Show(localTotal.ToString());    

#### Predefined generic classes and interfaces

The `System.Collections.Generic` namespace contains most of the predefined generic types. Here is a partial list of some of the predefined generic classes and interfaces

    Generic Type                Non-generic equivalent
    --------------------------------------------------
    List<T>                     ArrayList 	
    Collection<T>               Collection 	
    Dictionary<K, T>            HashTable 	
    KeyValuePair<K, V> 	                    
    SortedDictionary<K, T>      SortedList 	
    SortedList<T>               SortedList  
    Queue<T>                    Queue 	    
    Stack<T>                    Stack 	    
    LinkedList<T> 	              	        
    LinkedListNode<T> 	          	        
    Comparer<T>                 Comparer 	
    BindingList<T> 	              	        


    IList<T>                    IList 	    
    ICollection<T>              ICollection 
    IDictionary<K, T>           IDictionary 
    IEnumerable<T>              IEnumerable 
    IEnumerator<T>              IEnumerator 
    IComparer<T>                IComparer  	

Here is an example of use of one of those helper generic interfaces, the `IComparer<T>`, along with the generic methods of the `Array` class.

    class StringComparer : IComparer<string>
    {

        /\* Comparison methods return table             
                A < B      -1
                A == B      0
                A > B       1                \*/
        public int Compare(string A, string B)
        {
            if ((A == null) && (B == null))
                return 0;                       // if both are null then return equal
            else if (A == null)
                return -1;
            else if (B == null)
                return 1;
            else                                // both not null
                return A.CompareTo(B);          // so, perform string comparison
        }

    }

    ...

    void Display(IList list)
    {
        string S = "";

        foreach (object o in list)
            S += o.ToString() + Environment.NewLine;

        MessageBox.Show(S);
    }

    ...

    string\[\] cities = { "Rome", "Berlin", "Athens", "Madrid", "London", "Paris", "Oslo"};

    Display(cities);    // a zero bounded array is an IList

    IComparer<string> comparer = new StringComparer();

    Array.Sort<string>(cities, comparer);

    Display(cities);

#### Generics and the keyword default

An initialization problem arises with generic values inside classes and methods because of their unknown type. The keyword `default` is used to safely provide the default value for the actual type.

    public class Employee<T>
    {
        private T department = default(T);  // provides the default value for the actual type
        ...
    } 

### Iterators

The `foreach` statement works in conjunction with a so called "**iterator** ". For an object to be used as an iterator it is required to implement the `IEnumerable` interface.

    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
    }

The `IEnumerable.GetEnumerator()` returns an `IEnumerator` object.

    public interface IEnumerator
    {
        object Current { get; }
	
        bool MoveNext();
        void Reset();
    }

In a `foreach` statement the expression after the keyword `in`, it must return an object that either implements the `IEnumerable` or it is already an `IEnumerator` object.

A `foreach` statement continues execution as long as its iterator has a next value to provide.

Arrays are iterators by default, as most of the list classes and so they can be used with foreach statements.

    int\[\] numbers = int\[\] {1, 2, 3, 4, 5};
    
    foreach (int n in numbers)
    {
        DoSomething(n);         // this will be executed 5 times
    }

#### The keyword yield

Instead of explicitly implementing the `IEnumerable/IEnumerator` pattern the keyword `yield` forces the compiler to provide the needed code automatically at runtime.

The keyword `yield` is used inside a method and it has the same effect as the explicit implementation of an `IEnumerator` object.

The `yield` return statement causes the iterator to return the current element in the sequence and advances its position.

The `yield break` statement breaks the iteration.

    public class WordList
    {
        public IEnumerator GetEnumerator()
        {
            yield return "C#";
            yield return "is";
            yield return "a";
            yield return "great";
            yield return "language";
        }
    }
    
    ...
    
    WordList list = new WordList();
    
    string S = "";
	
    foreach (string word in list)
        S += word + " ";    
    
	

The keyword `yield` provides a quick and easy way in creating enumerable classes since it forces the compiler to create a nested `IEnumerator` class which keeps track of the position of the iterator.

The presence of the `GetEnumerator()` method in conjunction with the `yield` keyword makes the class to be treated as an `IEnumerable` "implementor", even if it is not an actual `IEnumerable` implementor.

    public class NumberList //: IEnumerable
    {
        int\[\] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9 };
	
	
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                yield return numbers\[i\];
            }
        }
    }
	
    ...
    
    NumberList list = new NumberList();
	
    int sum = 0;
	
    foreach (int i in list)
        sum += i;

The keyword yield

*   can be used with a method (`ref` and `out` parameters are not allowed)
*   can be used with a `get` accessor
*   can be used with an operator
*   can not be used with anonymous methods
*   can not be used in a `catch` block
*   can not be used in a `try` block that has one or more `catch` clauses
*   can not be used with `unsafe` blocks

#### The return type of iterator methods

The return type of an iterator method must be

*   `IEnumerable`
*   `IEnumerator`
*   `IEnumerable<T>` or
*   `IEnumerable<T>`.

Here is an example which uses an `IEnumerator` and a generic `IEnumerator<T>`

    public class Person
    {
        public Person(): this("John Doe")
        {
        }

        public Person(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public string Name { get; set; }
    }
    
    
    public class PersonList 
    {
        ArrayList persons = new ArrayList { new Person("John Doe"), new Person("Jane Doe") };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                yield return persons\[i\];
            }
        }
    }


    public class GenericList
    {
        ArrayList persons = new ArrayList { new Person("John Doe"), new Person("Jane Doe") };

        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                yield return (Person)persons\[i\];
            }
        }
    }
    
    ...
    
    PersonList persons = new PersonList();

    string S = "";
    foreach (Person p in persons)
        S += p.ToString() + Environment.NewLine;

    MessageBox.Show(S);
    
    ...
    
    GenericList persons = new GenericList();

    string S = "";
    foreach (Person p in persons)
        S += p.ToString() + Environment.NewLine;

    MessageBox.Show(S); 

#### Multiple iterators

A class may implement multiple iterator methods which may or may not accept parameters. No `ref` or `out` parameters though.

    public class MultiList 
    {
        string\[\] words = {"C#", "is", "a", "great", "language"  };
        int\[\] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        ArrayList persons = new ArrayList { new Person("John Doe"), new Person("Jane Doe") };
	
        public IEnumerable GetWords()
        {
            for (int i = 0; i < words.Length; i++)
            {
                yield return words\[i\];
            }
        }
	
        public IEnumerable GetNumbers(int StartIndex, int EndIndex)
        {
            for (int i = StartIndex; i <= EndIndex; i++)
            {
                yield return numbers\[i\];
            }
        }
	
        public IEnumerable GetPersons()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                yield return persons\[i\];
            }
        }
    }

Here is how to call those methods.

    MultiList multiList = new MultiList();
	
    string S = "";
	
    foreach (string word in multiList.GetWords())
        S += word + " ";
	
    MessageBox.Show(S);
     
	
    int sum = 0;
	
    foreach (int i in multiList.GetNumbers(3, 6))
        sum += i;
	
    MessageBox.Show(sum.ToString());
	
	
    S = "";
    foreach (Person p in multiList.GetPersons())
        S += p.ToString() + Environment.NewLine;
	
    MessageBox.Show(S);