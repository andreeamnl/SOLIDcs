from abc import ABC, abstractmethod

# Strategy: Defines an interface for requesting rides.
class RideRequestStrategy(ABC):
    @abstractmethod
    def execute(self, passenger, taxis):
        pass
