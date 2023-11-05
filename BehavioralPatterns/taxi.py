from abc import ABC , abstractmethod

# Colleague: Defines an interface for different types of taxis.
class Taxi(ABC):
    def __init__(self, mediator):
        self.mediator = mediator

    @abstractmethod
    def take_ride(self, passenger):
        pass
