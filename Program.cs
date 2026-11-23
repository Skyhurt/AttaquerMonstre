using System;

namespace Attaquer_monstre;

/*
    CONSIGNES
    Dans votre jeu vidéo, le héros peut attaquer différents monstres.
    Pour cela, vous devez créer une méthode Attaquer() qui reçoit le nom du monstre en paramètre.
    La méthode doit afficher un message sous la forme : "Le héros attaque le Dragon !"
    
    Dans Main(), appelez cette méthode trois fois pour attaquer :
    - Un Dragon
    - Un Gobelin
    - Un Zombie
 */
class Program
{
    static void Attaquer(string attack_Monster)
    {       
            Console.WriteLine("Le héros attaque le " + attack_Monster + " ! ");
    }
    static void Main(string[] args)
    {
        string attack_Monster;
        Console.WriteLine("Quel monstre veux tu attaquer en premier ?");
        attack_Monster = Console.ReadLine();
        if (attack_Monster == "Dragon")
        {
            Attaquer("Dragon");
        } else if (attack_Monster == "Gobelin")
            {
                Attaquer("Gobelin");
            } else if (attack_Monster == "Zombie")
        {
            Attaquer("Zombie");
        }
        Attaquer("Dragon" + " Gobelin" + " Zombie");
    }
}