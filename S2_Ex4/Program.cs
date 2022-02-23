using S2_Ex4;

var waitingRoom = new WaitingRoom();


Patient p1 = new Patient(waitingRoom);
Patient p2 = new Patient(waitingRoom);
Patient p3 = new Patient(waitingRoom);
Patient p4 = new Patient(waitingRoom);

/*waitingRoom.NumberChange += p1.ReactToNumber;
waitingRoom.NumberChange += p2.ReactToNumber;
waitingRoom.NumberChange += p3.ReactToNumber;
waitingRoom.NumberChange += p4.ReactToNumber;*/


    waitingRoom.RunWaitingRoom();