static void World()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine(@"               ,,ggddY'''Ybbgg,,
          ,agd888b,_ 'Y8, ___`''Ybga,
       ,gdP''88888888baa,.''8b    '888g,
     ,dP'     ]888888888P'  'Y     `888Yb,
   ,dP'      ,88888888P'  db,       '8P''Yb,
  ,8'       ,888888888b, d8888a           '8,
 ,8'        d88888888888,88P'' a,          `8,
,8'         88888888888888PP'  ''           `8,
d'          I88888888888P'                   `b
8           `8'88P''Y8P'                      8
8            Y 8[  _ '                        8
8              'Y8d8b  'Y a                   8
8                 `''8d,   __                 8
Y,                    `'8bd888b,             ,P
`8,                     ,d8888888baaa       ,8'
 `8,                    888888888888'      ,8'
  `8a                   '8888888888I      a8'
   `Yba                  `Y8888888P'    adP'
     'Yba                 `888888P'   adY'
       `'Yba,             d8888P' ,adP''
          `'Y8baa,      ,d888P,ad8P''
               ``''YYba8888P'''''");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
}
static void Win()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine(@"-----------------------------------------------------
   _                             .-.
  / )  .-.    ___          __   (   )
 ( (  (   ) .'___)        (__'-._) (
  \ '._) (,'.'               '.     '-.
   '.      /  '\               '    -. '.
     )    /   \ \   .-.   ,'.   )  (  ',_)    _
   .'    (     \ \ (   \ . .' .'    )    .-. ( \
  (  .''. '.    \ \|  .' .' ,',--, /    (   ) ) )
   \ \   ', :    \    .-'  ( (  ( (     _) (,' /
    \ \   : :    )  / _     ' .  \ \  ,'      /
  ,' ,'   : ;   /  /,' '.   /.'  / / ( (\    (
  '.'      '   (    .-'. \       ''   \_)\    \
                \  |    \ \__             )    )
              ___\ |     \___;           /  , /
             /  ___)                    (  ( (
             '.'                         ) ;) ;
                                        (_/(_/
----------------------------------------------------");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
}

static int AskQuestion(string qText, string rightAnswer)
{
    Console.WriteLine(qText);

    string answer = Console.ReadLine().ToLower();
    while (answer != "a" && answer != "b" && answer != "c" && answer != "d")
        {
            Console.WriteLine("Du måste välja antingen A, B, C eller D");
            answer = Console.ReadLine().ToLower();
        }
    if (answer == rightAnswer)
    {
        Console.WriteLine("Korrekt! Tryck enter för att fortsätta");
        Console.ReadLine();
        return 1;
    }
    else{
        Console.WriteLine("Tyvärr inte! Tryck enter för att fortsätta");
        Console.ReadLine();
        return 0;
    }
}


int active = 1;
Console.WriteLine("Välkommen till min frågesport om geografi!");
Console.WriteLine("Frågesporten består av 4 frågor med ökande svårighetsgrad.");
World();
Console.WriteLine("Är du redo att börja?");
string begin = Console.ReadLine().ToLower();
while (begin != "ja" && begin != "nej")
{
    Console.WriteLine("Du måste välja antingen ja eller nej.");
    Console.WriteLine("Är du redo att börja?");
    begin = Console.ReadLine().ToLower();
}

if (begin == "nej")
{
    Console.Clear();
    Console.WriteLine("Skumt att starta ett program som man inte är redo att köra men okej");
    Console.WriteLine("Tryck enter för att stänga programmet");
    Console.ReadLine();
    System.Environment.Exit(1);
}
else if (begin == "ja")
{
    while (active == 1)
    {
        int score = 0;
        Console.Clear();
        Console.WriteLine("Vad heter du som spelar?");
        string name = Console.ReadLine().ToLower();
        while (name.Length == 0)
        {
            Console.WriteLine("Du måste skriva ett namn");
            Console.WriteLine("Vad heter du som spelar?");
            name = Console.ReadLine().ToLower();
        }
        //Gör så att man måste skriva in något

        Console.Clear();
        Console.WriteLine("Okej " + char.ToUpper(name[0]) + name.Substring(1) + ", första frågan!");
        //Skriver ut med stor första bokstav i namnet

        score += AskQuestion("Vilket av följande länder ligger INTE i Afrika?\n" + @"(A) Nigeria   (B) Mozambique   (C) Bhutan   (D) Algeriet", "c");
        Console.Clear();
        Console.WriteLine("Okej " + char.ToUpper(name[0]) + name.Substring(1) + ", andra frågan!");
        score += AskQuestion("I vilken världsdel ligger Guatemala?\n" + @"(A) Nordamerika   (B) Sydamerika   (C) Asien   (D) Inget av alternativen", "a");
        Console.Clear();
        Console.WriteLine("Okej " + char.ToUpper(name[0]) + name.Substring(1) + ", tredje frågan!");
        score += AskQuestion("Vad heter huvudstaden i Georgien?\n" + @"(A) Teheran   (B) Jerevan   (C) Tbilisi   (D) Guvernementet Baku", "c");
        Console.Clear();
        Console.WriteLine("Okej " + char.ToUpper(name[0]) + name.Substring(1) + ", sista frågan!");
        Console.WriteLine("Denna fråga är inte multiple-choice, utan kräver att du skriver rätt svar!");
        Console.WriteLine("Var nogrann med stavning!");
        Console.WriteLine("Vad heter Burkina Fasos huvudstad?");
        string answer = Console.ReadLine().ToLower();
        while (answer.Length == 0)
        {
            Console.WriteLine("Du måste skriva ett svar");
            Console.WriteLine("Vad heter Burkina Fasos huvudstad?");
            answer = Console.ReadLine();
        }
        //Förhindrar att användaren råkar trycka på enter

        if (answer == "ouagadougou")
        {
            score += 1;
            Console.WriteLine("Korrekt! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Tyvärr inte! Tryck enter för att fortsätta");
            Console.ReadLine();
        }
        Console.Clear();
        Console.WriteLine("Bra jobbat " + char.ToUpper(name[0]) + name.Substring(1) + "! Du fick " + score + " poäng!");
        if (score == 4)
        {
            Console.WriteLine("Alla rätt!");
            Win();
        }
        Console.WriteLine("Vill du försöka igen?");
        string retry = Console.ReadLine().ToLower();
        while (retry != "ja" && retry != "nej")
        {
            Console.WriteLine("Du måste välja antingen ja eller nej");
            Console.WriteLine("Vill du försöka igen?");
            retry = Console.ReadLine();
        }
        if (retry == "ja")
        {
            continue;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Vill du se facit?");
            string facit = Console.ReadLine().ToLower();
            while (facit != "ja" && facit != "nej")
            {
                Console.WriteLine("Du måste välja antingen ja eller nej");
                Console.WriteLine("Vill du se facit?");
                facit = Console.ReadLine().ToLower();
            }
            if (facit == "ja")
            {
                Console.Clear();
                Console.WriteLine("Fråga 1: C");
                Console.WriteLine("Fråga 2: A");
                Console.WriteLine("Fråga 3: C");
                Console.WriteLine("Fråga 4: Ouagadougou");
                Console.WriteLine("Tryck enter för att fortsätta");
                Console.ReadLine();
            }
            active = 0;
        }
    }
}
Console.Clear();
Console.WriteLine("Tack för att du spelade!");
Console.WriteLine("Tryck enter för att stänga programmet");
Console.ReadLine();