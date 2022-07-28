Console.WriteLine("Zadej jméno:");
string jmeno = Console.ReadLine();
Console.WriteLine("Zadej příjmení:");
string primeni = Console.ReadLine();
Console.WriteLine("Zadej svůj věk:");
string vek =  (Console.ReadLine());

int vekCislo = int.Parse(vek);
int celkovyVek = vekCislo + 1;
string konfig = jmeno + " " + primeni;
konfig = konfig.ToUpper();
Console.WriteLine(konfig);
Console.WriteLine("Za rok ti bude: " + celkovyVek);
Console.ReadKey();