from rideRequestStrategy import RideRequestStrategy
from uberTaxi import UberTaxi

# ConcreteStrategy implementations for different ride request methods.
class UberRideRequestStrategy(RideRequestStrategy):
    def execute(self, passenger, taxis):
        print("Requesting an Uber ride...")
        for taxi in taxis:
            if isinstance(taxi, UberTaxi):
                taxi.take_ride(passenger)
