from abc import ABC, abstractmethod

# Mediator: Defines an interface for communicating with Taxi objects.
class TaxiMediator(ABC):
    @abstractmethod
    def request_ride(self, passenger, strategy):
        pass