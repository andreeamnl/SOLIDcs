# Creational Design Patterns implementation

### Course: Design Principles and Design Patterns
### Author: Andreea MANOLE

----



## Objectives:

* Study and understand the Creational Design Patterns.
* Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.
* Use some creational design patterns for object instantiation in a sample project.


## Implementation description

* Factory Pattern

Using the Factory Design Pattern for an EmployeeFinances implementation that includes subclasses like ``BaseEmployeeFinances``, ``EmployeeFinancesCEO``, and ``EmployeeFinancesManager`` involves creating a factory class responsible for creating instances of these subclasses. This pattern provides a way to encapsulate the object creation process and abstract the client code from the specific classes being instantiated.


* Builder Pattern 

``TrainingModule`` is the product class that represents a training module.``ITrainingModuleBuilder`` is the builder interface with methods for building different parts of the ``TrainingModule ``. ``CreateTrainingModule`` is a concrete builder class that implements the ``ITrainingModuleBuilder`` interface. It constructs a ``TrainingModule`` step by step.


* Prototype Pattern

The ``Employee`` class is the prototype, and it implements the ``IEmployeePrototype`` interface. The Clone method performs a shallow copy, creating a new Employee instance and copying the values from the original. 

* Singleton Pattern

The ``Logger`` class has a private constructor, preventing direct instantiation of the class from outside. Instead, clients access the logger instance through the public method ``GetInstance``, which creates the instance on the first call and returns the existing instance on subsequent calls.The ``GetInstance`` method ensures that only one Logger instance exists throughout the application. The Log method is used to log messages to a log file. In this case, we're appending log entries to a file named "log.txt."




## Conclusions 

Creational design patterns are important because they provide a structured and flexible way to create objects in software. They encapsulate object creation, promoting code reusability and reducing coupling between classes. Creational patterns improve code maintainability by abstracting complex initialization procedures and enable consistent and reliable object creation. They also facilitate testing and can optimize object creation for better performance.