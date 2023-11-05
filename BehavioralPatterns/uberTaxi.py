from taxi import Taxi

# ConcreteColleague implementations for different types of taxis.
class UberTaxi(Taxi):
    def take_ride(self, passenger):
        print(f"Uber driver picks up {passenger}")
