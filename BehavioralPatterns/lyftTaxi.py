
from taxi import Taxi

class LyftTaxi(Taxi):
    def take_ride(self, passenger):
        print(f"Lyft driver picks up {passenger}")
