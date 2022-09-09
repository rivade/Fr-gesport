int active = 1;
Console.WriteLine("Välkommen till min frågesport om geografi!");
Console.WriteLine("Frågesporten består av 4 frågor med ökande svårighetsgrad.");
Console.WriteLine("Är du redo att börja?");
string begin = Console.ReadLine().ToLower();
while (begin != "ja" && begin != "nej"){
    Console.WriteLine("Du måste välja antingen ja eller nej.");
    Console.WriteLine("Är du redo att börja?");
    begin = Console.ReadLine().ToLower();
}

if (begin == "nej"){
    Console.Clear();
    Console.WriteLine("Skumt att starta ett program som man inte är redo att köra men okej");
}
else if (begin == "ja"){
    while (active == 1){
        int score = 0;
        Console.Clear();
        Console.WriteLine("Vad heter du som spelar?");
        string name = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Okej {name}, första frågan!");
        Console.WriteLine("Vilket av följande länder ligger INTE i Afrika?");
        Console.WriteLine(@"(A) Nigeria   (B) Mozambique   (C) Bhutan   (D) Algeriet");
        string answer = Console.ReadLine().ToLower();
        while (answer != "a" && answer != "b" && answer != "c" && answer != "d"){
            Console.WriteLine("Du måste välja antingen A, B, C eller D");
            answer = Console.ReadLine().ToLower();
        }
        if (answer == "c"){
            score = score + 1;
            Console.WriteLine("Korrekt! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        else{
            Console.WriteLine("Tyvärr inte! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine($"Okej {name}, andra frågan!");
        Console.WriteLine("I vilken världsdel ligger Guatemala?");
        Console.WriteLine(@"(A) Nordamerika   (B) Sydamerika   (C) Asien   (D) Inget av alternativen");
        answer = Console.ReadLine().ToLower();
        while (answer != "a" && answer != "b" && answer != "c" && answer != "d"){
            Console.WriteLine("Du måste välja antingen A, B, C eller D");
            answer = Console.ReadLine().ToLower();
        }
        if (answer == "a"){
            score = score + 1;
            Console.WriteLine("Korrekt! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        else{
            Console.WriteLine("Tyvärr inte! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine($"Okej {name}, tredje frågan!");
        Console.WriteLine("Vad heter huvudstaden i Georgien?");
        Console.WriteLine(@"(A) Teheran   (B) Jerevan   (C) Tbilisi   (D) Guvernementet Baku");
        answer = Console.ReadLine().ToLower();
        while (answer != "a" && answer != "b" && answer != "c" && answer != "d"){
            Console.WriteLine("Du måste välja antingen A, B, C eller D");
            answer = Console.ReadLine().ToLower();
        }
        if (answer == "c"){
            score = score + 1;
            Console.WriteLine("Korrekt! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        else{
            Console.WriteLine("Tyvärr inte! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine($"Okej {name}, sista frågan!");
        Console.WriteLine("Denna fråga är inte multiple-choice, utan kräver att du skriver rätt svar!");
        Console.WriteLine("Var nogrann med stavning!");
        Console.WriteLine("Vad heter Burkina Fasos huvudstad?");
        answer = Console.ReadLine().ToLower();
        if (answer == "ouagadougou"){
            score = score + 1;
            Console.WriteLine("Korrekt! Tryck enter för att fortsätta");
        }
        else{
            Console.WriteLine("Tyvärr inte! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine($"Bra jobbat {name}! Du fick " + score + " poäng!");
        Console.WriteLine("Vill du försöka igen?");
        string retry = Console.ReadLine().ToLower();
        while (retry != "ja" && retry != "nej"){
            Console.WriteLine("Du måste välja antingen ja eller nej");
            Console.WriteLine("Vill du försöka igen?");
            retry = Console.ReadLine();
        }
        if (retry == "ja"){
            continue;
        }
        else{
            Console.Clear();
            Console.WriteLine("Tack för att du spelade!");
            active = 0;
        }
    }
}
Console.WriteLine("Tryck enter för att stänga programmet");
Console.ReadLine();