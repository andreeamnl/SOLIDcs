from rideRequestStrategy import RideRequestStrategy
from lyftTaxi import LyftTaxi

class LyftRideRequestStrategy(RideRequestStrategy):
    def execute(self, passenger, taxis):
        print("Requesting a Lyft ride...")
        for taxi in taxis:
            if isinstance(taxi, LyftTaxi):
                taxi.take_ride(passenger)
