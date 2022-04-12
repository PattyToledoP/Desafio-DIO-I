using static System.Console;
using System.Collections.Generic;
using projeto.SRC;

public class Program
{
static void Main (String[] args)
  {
    Knight Heros = new Knight("Aros", 25, "Knight");
    Hero ninja = new Hero("Jack", 99, "Ninja");
    Wizard wizard = new Wizard ("Jennica", 25, "White Wizard");
    Opponent opponent = new Opponent ("Malefius", 25, "Devil");
    WriteLine(Heros);
    WriteLine(ninja);
    WriteLine(opponent);
    WriteLine(wizard.Attack(1));
    WriteLine(wizard.Attack(7));
  }
}
