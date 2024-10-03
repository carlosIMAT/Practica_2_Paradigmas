using System;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City("Madrid");

            PoliceStation policeStation = city.CreatePoliceStation(1);

            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");

            city.RegisterTaxi(taxi1);
            city.RegisterTaxi(taxi2);

            SpeedRadar speedRadar = new SpeedRadar();

            PoliceCar policeCarRadar = new PoliceCar("0001 CNP", policeStation, speedRadar);
            PoliceCar policeCarNoRadar = new PoliceCar("0002 CNP", policeStation);

            policeStation.RegisterPoliceCar(policeCarRadar);
            policeStation.RegisterPoliceCar(policeCarNoRadar);

            Vehicle scooter = new Vehicle("Scooter");

            policeCarRadar.StartPatrolling();
            policeCarNoRadar.StartPatrolling();

            policeCarNoRadar.UseRadar(taxi1);
            policeCarRadar.UseRadar(taxi1);


            taxi1.StartRide();

            policeCarRadar.UseRadar(taxi1);
            policeCarRadar.StartAlarm(taxi1);

            taxi1.StopRide();
            policeCarRadar.StopAlarm();

            city.EliminateTaxi(taxi1);

            policeCarRadar.UseRadar(scooter);

            policeCarRadar.PrintRadarHistory();
        }
    }
}