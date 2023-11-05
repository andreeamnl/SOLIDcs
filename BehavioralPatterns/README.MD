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

* Observer Design Pattern

Observer (Abstract Base Class): Defines an interface for observing ride requests. It contains an abstract method notify that should be implemented by concrete observers. PassengerObserver (Concrete Observer): Monitors and responds to ride requests. It implements the Observer interface and prints information about ride requests.




## Conclusions 

In summary, the Mediator pattern is used to centralize and control the communication between various objects, the Strategy pattern encapsulates different ride request strategies, and the Observer pattern is used to monitor and respond to ride requests. These design patterns help in organizing and decoupling the components of the taxi system, making the code more maintainable and extensible.