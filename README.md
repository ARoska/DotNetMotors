# DotNet Motors
#### Lab05/06 - OOP Principles
##### *Author: Andrew Roska*

------------------------------

## Description
A simple C# app that builds out a heirarchical list of vehicles sold at an auto dealer.  This app uses and proves the 4 Object-Oriented Principles (OOP) of C#: Inheritance, Abstraction, Polymorphism, and Encapsulation.

------------------------------

## OOP Specifics
**Inheritance**: The act of passing down `Parameters` and `Methods` from a base `Class` to any `Classes` derived from it.

**Abstraction**: A property that can be defined on a `Class`, a `Parameter` or a `Method` that denotes more information is required to implement.  `Abstract Classes` cannot be initialized and can only have thier qualities Inherited.  `Concrete Classes` are not Abstract.  `Abstract Parameters` and `Abstract Methods` are required to be Overriden before they are implemented in a `Concrete Class`.

**Polymorphism**: The ability to change items aquired through Inheritance at the time of aquisition.  Overriding a `Parameter` is an example of Polymorphism.

**Encapsulation**: The act of containing the logic inside a given class.  This allows restrictions such as making the code to be internal or private.

**Interfaces**: A small "plug-in" of sorts for our `Abstract Classes` and `Concrete Classes`, these smaller `Classes` allow us to define mandatory `Parameters` and `Methods` that we do not necessarily want all `Classes` to Inherit. Interfaces are denoted by a capital 'I' before the name.

#### Examples
**Inheritance**: All of my `Classes` inherit from the base `Class` of `Vehicle`.  Each `Concrete Class` further inherits from at least one other `Abstract Class` along the way.

**Abstraction**: `Car` and `Bike` are both `Abstract Classes` and as such require futher input before an Inheriting `Concrete Class` can be initialized.  My `NumberOfWheels` and `NumberOfDoors` `Parameters` are both Abstract as well and require a value.

**Polymorphism**: The `NumberOfWheels` and `NumberOfDoors` `Parameters` are both Overriden with values before they reach a `Concrete Class`.

**Encapsulation**: Each of my `Abstract Classes` are examples of Encapsulation, as each one's data cannot be directly accessed without being Inherited by a `Concrete Class`.

**Interfaces**: My `INeedKey` and `INeedGas` are both Interfaces.  Not all of my `Concrete Classes` need the qualities of either of these Interfaces and so they are only applied where necessary and their properties are not applied at a `Base Class` level.

------------------------------

## Visuals

##### Class Heirarchy and Interface Diagram Map
![Interface Diagram Map](https://github.com/Roketsu86/DotNetMotors/blob/master/Assets/Copy%20of%20Copy%20of%20DotNetMotors%20Diagram.png)

------------------------------

## Change Log
1.2: *Implement Unit Tests* - 29 March 2019

1.1: *Created Class and Interface Heirarchies* - 27 March 2019

1.0: *Initial Build* - 27 March 2019

------------------------------
