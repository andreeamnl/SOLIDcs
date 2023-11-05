from observer import Observer



# ConcreteObserver: Monitors and responds to ride requests.
class PassengerObserver(Observer):
    def notify(self, passenger, strategy):
        print(f"Observer: Ride request for {passenger} using {strategy.__class__.__name__}")
