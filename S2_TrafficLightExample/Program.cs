using System.Data.Common;
using S2_TrafficLightExample;

TrafficLight tl = new TrafficLight();

Car c1 = new Car {Id = 1};
Car c2 = new Car {Id = 2};
Car c3 = new Car {Id = 3};

tl.LightChange += c1.ReactoLight;
tl.LightChange += c2.ReactoLight;
tl.LightChange += c3.ReactoLight;

tl.RunTrafficLight();