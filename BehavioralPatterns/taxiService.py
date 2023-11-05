from taxiMediator import TaxiMediator

# ConcreteMediator: Implements cooperative behavior by coordinating Taxi objects.
class TaxiService(TaxiMediator):
    def __init__(self):
        self.taxis = []
        self.passenger_observer = None

    def register_taxi(self, taxi):
        self.taxis.append(taxi)

    def register_passenger_observer(self, observer):
        self.passenger_observer = observer

    def request_ride(self, passenger, strategy):
        strategy.execute(passenger, self.taxis)
        self.passenger_observer.notify(passenger, strategy)
        