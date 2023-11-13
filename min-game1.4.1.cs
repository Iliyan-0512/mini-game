using System.Linq;
Console.WriteLine("Hello");
double myAttack = 8;
double myHeroHealt = 100;
//double myArmor = 0;
double enemyHealt = 100;
double enemyAttack = 10;
double money = 10;
int cooldown = 1;
//int count = 1;
// to do of random to choose command // for enemy
while (myHeroHealt > 0 && enemyHealt > 0)
{
    Console.WriteLine("select an option");
    Console.WriteLine("1-Attack");
    Console.WriteLine("2-heal");
    Console.WriteLine("3-block");// when press block the enemise attack but has limit one time of 2
    Console.WriteLine("4-shop");
    string command = Console.ReadLine();
    if (command == "1")
    {
        enemyHealt -= myAttack;
        myHeroHealt -= enemyAttack;
        money += 2;
        if (enemyHealt == 0)
        {
            myHeroHealt += 20;
        }
        Console.WriteLine($"Enemy: {enemyHealt}");
        Console.WriteLine($"Hero: {myHeroHealt}");
        Console.WriteLine($"Money: {money}");
    }
    else if (command == "2")
    {
        myHeroHealt += 15;
        myHeroHealt -= enemyAttack;
        Console.WriteLine($"Enemy: {enemyHealt}");
        Console.WriteLine($"Hero: {myHeroHealt}");
        Console.WriteLine($"Money: {money}");
    }
    else if (command == "3")
    {
        cooldown++;
        if (cooldown >= 3)
        {
            cooldown = 1;
            continue;
        }
        else
        {
            myHeroHealt -= 0;
            myHeroHealt += 10;
            Console.WriteLine($"Enemy: {enemyHealt}");
            Console.WriteLine($"Hero: {myHeroHealt}");
            Console.WriteLine($"Money: {money}");
            
        }
    }
    else if (command == "4")
    {
        Console.WriteLine("Choose:");
        Console.WriteLine("1-Sword:13 money");
        Console.WriteLine("2-Armor:10 money");
        Console.WriteLine($"You have {money}");
        command =Console.ReadLine();
        if (command=="1" && money>=13)
        {
            myAttack = myAttack +(myAttack* 20 / 100);
            money -= 13;
            Console.WriteLine($"Your attack is:{myAttack}");
            Console.WriteLine($"Money: {money}");
        }
        else if(command=="2" && money>=10)
        {
            myHeroHealt += 50;
            money -= 10;
            Console.WriteLine($"Health {myHeroHealt}");
            Console.WriteLine($"Money: {money}");
        }     
    }
}
if (myHeroHealt <= 0)
{
    Console.WriteLine("You lost");
}
else if (enemyHealt <= 0)
{
    Console.WriteLine("You won");
}