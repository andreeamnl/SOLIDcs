# SOLID implementation

### Course: Design Principles and Design Patterns
### Author: Andreea MANOLE

----



## Objectives:

* Choose an OO programming language and a suitable IDE or Editor (No frameworks/libs/engines allowed).
* Select a domain area for the sample project.
* Define the main involved classes and think about what instantiation mechanisms are needed.
* Respect SOLID Principles in your project.


## Implementation description

* Single Responsibility principle

Each class has only one responsibility and no other reason to change. Extra-functionality required is handled by extra modules. The financial perspective of each employee type is handled by a special class ``EmployeeFinances`` instead of adding technical aspects to business logic classes.Methods within a class only have a single responsibility, and their names reflects that responsibility.


* Open Closed Principle

Instead of using nested if-else conditions to violate OCP, we use inheritance and polymorphism. In the ``EmployeeFinances`` class we add subclasses to handle and override the ``CalculatePay`` method instead of checking each type in an IF-ELSE condition. This way, whenever we add a new type of employee, we extend the functionality of the class rather than modifying it (we add new sub-classes).


* Liskov Susbstitution Principle

``Ceo`` class directly inheriting from ``Employee`` would break LSP (as only he has ``generatePerformanceReview`` method and only he has no ``manager``attribute).
``Manager`` really does implement the ``Employee`` class, but we bring in an interface ``IManager`` to provide extra-functionality, instead of breaking LSP by directly providing it to ``Employee``.
``CEO`` inherits from ``BaseEmployee`` instead of ``Employee`` , as it is the one class that has the most things in common to everything, and also ``IManager`` (as ``CEO`` has some manager functionality).

* Interface Segregation Principle

I created small, focused interfaces(such as ``IManager``, ``IManaged``): Designed interfaces that have a single responsibility or represent a specific behavior. 
I also used multiple interfaces: It's often better to have multiple small interfaces rather than one large interface. This allows classes to implement only the interfaces that are relevant to their functionality.

* Dependency inversion Principle

Instead of depending on concrete classes or modules, high-level modules should depend on abstractions (e.g., interfaces or abstract classes).
The high-level module focuses on business logic, while the low-level module deals with the technical aspects or calculations, such as ``EmployeeFinances``.
High-level modules such as ``Employee`` class or ``CEO`` class are interface/abstract class dependent, making the system more flexible.
Following/respecting OCP helps. To align with DIP, when you need to introduce new functionality or variations, you create new abstractions and implementations instead of modifying existing code. This avoids breaking existing dependencies.



## Conclusions 

Respectiong SOLID has fist of all helped me write manageable and less-breakable code, improved it's quality, reduced duplication. Therefore, I believe  adhering to SOLID principles is not just a matter of adhering to best practices, it can have a direct positive impact on your software projects.
