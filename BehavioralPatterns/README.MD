# Behavioral Design Patterns implementation

### Course: Design Principles and Design Patterns
### Author: Andreea MANOLE

----



## Objectives:

* Study and understand the BehavioralDesign Patterns.
* Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms.
* Use some Behavioral design patterns for object instantiation in a sample project.


## Implementation description

* Mediator Design Pattern

TaxiMediator (Abstract Base Class): Defines an interface for communicating with Taxi objects. It contains an abstract method request_ride that is used to request a ride. TaxiService (Concrete Mediator): Implements cooperative behavior by coordinating Taxi objects. It manages registered taxis and the passenger observer. It also has a request_ride method that forwards ride requests to the appropriate strategy and notifies the observer.Colleague (Abstract Base Class): Defines an interface for different types of taxis. It ensures that all types of taxis adhere to the same interface.UberTaxi and LyftTaxi (Concrete Colleagues): Implement the Colleague interface. These represent different types of taxis and can take rides.

* Strategy Design Pattern

RideRequestStrategy (Abstract Base Class): Defines an interface for requesting rides. It contains an abstract method execute that is implemented by concrete strategies.UberRideRequestStrategy and LyftRideRequestStrategy (Concrete Strategies): Implement the RideRequestStrategy interface. Each strategy represents a different ride request method (Uber and Lyft). These strategies are used to request rides from specific types of taxis.

* Prototype Pattern

The ``Employee`` class is the prototype, and it implements the ``IEmployeePrototype`` interface. The Clone method performs a shallow copy, creating a new Employee instance and copying the values from the original. 

* Singleton Pattern

The ``Logger`` class has a private constructor, preventing direct instantiation of the class from outside. Instead, clients access the logger instance through the public method ``GetInstance``, which creates the instance on the first call and returns the existing instance on subsequent calls.The ``GetInstance`` method ensures that only one Logger instance exists throughout the application. The Log method is used to log messages to a log file. In this case, we're appending log entries to a file named "log.txt."




## Conclusions 

Creational design patterns are important because they provide a structured and flexible way to create objects in software. They encapsulate object creation, promoting code reusability and reducing coupling between classes. Creational patterns improve code maintainability by abstracting complex initialization procedures and enable consistent and reliable object creation. They also facilitate testing and can optimize object creation for better performance.