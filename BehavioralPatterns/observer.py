from abc import ABC, abstractmethod



# Observer: Defines an interface for observing ride requests.
class Observer(ABC):
    @abstractmethod
    def notify(self, passenger, strategy):
        pass
