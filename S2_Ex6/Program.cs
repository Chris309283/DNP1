using S2_Ex6;

var bird1 = new Bird("White");
var bird2 = new Bird("Black");

var birdwatcher1 = new BirdWatcher();

bird1.BirdThings += birdwatcher1.ReactToBirdy;
bird2.BirdThings += birdwatcher1.ReactToBirdy;

Thread t1 = new Thread(bird1.Run);
Thread t2 = new Thread(bird2.Run);

t1.Start();
t2.Start();
