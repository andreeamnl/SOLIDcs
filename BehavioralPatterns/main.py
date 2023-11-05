

from taxiService import TaxiService
from uberTaxi import UberTaxi
from lyftTaxi import LyftTaxi
from passengerObserver import PassengerObserver
from uberRideRequestStrategy import UberRideRequestStrategy







# Client code
if __name__ == "__main__":
    mediator = TaxiService()

    uber_taxi = UberTaxi(mediator)
    lyft_taxi = LyftTaxi(mediator)

    mediator.register_taxi(uber_taxi)
    mediator.register_taxi(lyft_taxi)

    passenger_observer = PassengerObserver()
    mediator.register_passenger_observer(passenger_observer)

    passenger = "John"

    # Choose a strategy for ride request ( Uber or Lyft)
    strategy = UberRideRequestStrategy()
    mediator.request_ride(passenger, strategy)
