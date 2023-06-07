Random rnd = new Random();

int myRandomNum;

int randomSum = 0;
for(int i = 0; i < 30; i++)
{
    myRandomNum = rnd.Next(0, 11); // 0-10 sest 0 l'heb ka arvesse ja loendab 0-10
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total; {randomSum}");