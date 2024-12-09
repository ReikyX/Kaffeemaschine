using System.Security.Cryptography;

namespace Kaffeemaschine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Begruessung();
            Kaffeemaschine status = new Kaffeemaschine(Kaffeemaschine.MaxWassermenge,Kaffeemaschine.MaxBohnenmenge);

            Console.WriteLine($"Die maximale Bohnenmenge beträgt:\t{Kaffeemaschine.MaxBohnenmenge}g.");
            Console.WriteLine($"Die maximale Wassermenge beträgt:\t{Kaffeemaschine.MaxWassermenge}ml.");
            
            status.Wiederholen();

        }

        static void Begruessung()
        {
            Console.WriteLine(@"
      ,a8a,                                     ,ggg,        gg                                                                                                                                          
     ,8"" ""8, ,dPYb,                            dP""""Y8b       dP              ,dPYb,  ,dPYb,                                                                       ,dPYb,                                 
     d8   8b IP'`Yb                            Yb, `88      d8'              IP'`Yb  IP'`Yb                                                                       IP'`Yb                                 
     88   88 I8  8I                             `""  88    ,dP'               I8  8I  I8  8I                                                                       I8  8I      gg                         
     88   88 I8  8'                                 88aaad8""                 I8  8'  I8  8'                                                                       I8  8'      """"                         
     Y8   8P I8 dPgg,    ,gggggg,   ,ggg,           88""""""""Yb,      ,gggg,gg  I8 dP   I8 dP    ,ggg,    ,ggg,    ,ggg,,ggg,,ggg,     ,gggg,gg    ,g,       ,gggg,  I8 dPgg,    gg    ,ggg,,ggg,    ,ggg,  
     `8, ,8' I8dP"" ""8I   dP""""""""8I  i8"" ""8i          88     ""8b    dP""  ""Y8I  I8dP    I8dP    i8"" ""8i  i8"" ""8i  ,8"" ""8P"" ""8P"" ""8,   dP""  ""Y8I   ,8'8,     dP""  ""Yb I8dP"" ""8I   88   ,8"" ""8P"" ""8,  i8"" ""8i 
8888  ""8,8""  I8P    I8  ,8'    8I  I8, ,8I          88      `8i  i8'    ,8I  I8P     I8P     I8, ,8I  I8, ,8I  I8   8I   8I   8I  i8'    ,8I  ,8'  Yb   i8'       I8P    I8   88   I8   8I   8I  I8, ,8I 
`8b,  ,d8b, ,d8     I8,,dP     Y8, `YbadP'          88       Yb,,d8,   ,d8b,,d8b,_  ,d8b,_   `YbadP'  `YbadP' ,dP   8I   8I   Yb,,d8,   ,d8b,,8'_   8) ,d8,_    _,d8     I8,_,88,_,dP   8I   Yb, `YbadP' 
  ""Y88P"" ""Y888P     `Y88P      `Y8888P""Y888         88        Y8P""Y8888P""`Y8PI8""8888PI8""8888888P""Y888888P""Y8888P'   8I   8I   `Y8P""Y8888P""`Y8P' ""YY8P8PP""""Y8888PP88P     `Y88P""""Y88P'   8I   `Y8888P""Y888
                                                                             I8 `8,  I8 `8,                                                                                                              
                                                                             I8  `8, I8  `8,                                                                                                             
                                                                             I8   8I I8   8I                                                                                                             
                                                                             I8   8I I8   8I                                                                                                             
                                                                             I8, ,8' I8, ,8'                                                                                                             
                                                                              ""Y8P'   ""Y8P'                                                                                                              
");
        }
        //Aufgabe1:
        //Erstellen Sie die Klasse Kaffeemaschine.
        //Diese soll über die Felder "wasserstand" und "bohnenMenge" verfügen.
        //Es soll auch zwei static Felder (googeln Sie bitte was static bedeutet und 
        //wie es eingesetzt wird) geben namens "maxWasserstand" und "maxBohnenmenge".
        //Die Klasse soll im Sinne der Datensicherheit gekapselt sein.
        //Erstellen Sie zwei Methoden, welche jeweils zurückmelden wieviel Wasser und wieviele Bohnen aufgefüllt werden müssen.
        //Hinweis: Sie werden dann selbst ein Objekt der Klasse Kaffeemaschine erstellen müssen, dem Sie beliebig entsprechende Werte
        //zuweisen und mit dem Sie dann die Methoden ausführen können.
        //
        //Aufgabe 2:
        //Erstellen Sie eine Methode um einen Kaffee zu machen. Dafür soll eine bestimmte Menge Wasser und eine bestimmte Menge Bohnen
        //verbraucht werden.
        //Geben Sie den Kaffee stellvertretend über einen Console.WriteLine aus.
        //
        //Aufgabe 3:
        //Erstellen Sie Methoden um zu prüfen, ob noch ausreichend Wasser und Bohnen für einen Kaffe vorhanden sind.
        //Diese beiden Methoden sollen dann in der für Aufgabe 2 erstellten Methode sinnvoll aufgerufen werden. 
        //
        //Aufgabe 4a: Schreiben Sie Code der es uns ermöglicht wieder und wieder einen Kaffe aus der Maschine zu bekommen.
        //Aufgabe 4b: Machen Sie diesen Code zu einer Methode der Klasse.
        //Aufgabe 4c: Verlagern Sie alle bisherigen Methodenaufrufe aus der Programm.cs in die Methode aus 4b.
        //Diese Methode soll es dann ermöglichen nach Nutzereingabe entweder einen Kaffe zu bekommen oder eine der Auffüllmethoden auszuführen.
    }
}
