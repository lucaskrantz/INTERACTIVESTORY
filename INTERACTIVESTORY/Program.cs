

Console.WriteLine("Det är ett stort berg framför dig. Bestiger du berget? Svara ja eller nej");

string val = Console.ReadLine();



if (val == "nej")
{
    Console.WriteLine("Bra val. Tryck på enter för att avsluta.");


}

else if (val == "ja")
{

    Console.WriteLine("Pfft, eru dum i hubvet. Skit i. Du klättrar upp men stannar vid en ravin. Vågar du klättra över?");
    val = Console.ReadLine();


    if (val == "nej")
    {

        Console.WriteLine("Försent. Marken under dig kollapsar och du dör.");
        Console.WriteLine("GAME OVER");
        Console.WriteLine("Tryck på ENTER för att avsluta");


    }



    else if (val == "ja")
    {


        Console.WriteLine("Whatever. Du klarade dig knappt över bara för att du har tur.");
        Console.WriteLine("Det sover en drake i berget. Han äter upp dig. Snyggt jobbat :/");
        Console.WriteLine("I hans mage har du valet att försöka rädda dig själv. Orkar du ens?");
        val = Console.ReadLine();

        if (val == "ja")
        {
            Console.WriteLine("Vem tror du du är, dumt försök. Du dog.");
            Console.WriteLine("Tryck på enter för att avsluta");
        }

        else if (val == "nej")
        {
            Console.WriteLine("Du dör en tragisk död, typ");
            Console.WriteLine("Tryck på ENTER för att avsluta");



        }




    }


}




Console.ReadLine();