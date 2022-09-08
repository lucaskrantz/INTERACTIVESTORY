

Console.WriteLine("Det är ett stort berg framför dig. Bestiger du berget? Svara Ja eller Nej");

string val = Console.ReadLine();



if (val == "Nej")
{
    Console.WriteLine("Bra val. Tryck på enter för att avsluta.");


}

else if (val == "Ja")
{

    Console.WriteLine("Pfft, eru dum i hubvet. Skit i. Du klättrar upp men stannar vid en ravin. Vågar du klättra över?");
    val = Console.ReadLine();


    if (val == "Nej")
    {

        Console.WriteLine("Försent. Marken under dig kollapsar och du dör.");
        Console.WriteLine("GAME OVER");
        Console.WriteLine("Tryck på ENTER för att avsluta");


    }



    else if (val == "Ja")
    {


        Console.WriteLine("Whatever. Du klarade dig knappt över bara för att du har tur.");
        Console.WriteLine("");
    }


}




Console.ReadLine();