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
        int number_Attack = 1;
        Console.WriteLine("Un dragon, un gobelin et un zombie t'attaque !");
        do
        {
            if (number_Attack == 1)
            {
                Console.WriteLine("Quel monstre veux tu attaquer en premier ?");
            
            } else if (number_Attack == 2)
                {
                    Console.WriteLine("Quel monstre veux tu attaquer maintenant ?");
            
                } else
                    {
                        Console.WriteLine("Tape le nom du dernier monstre pour l'abbatre !");
                    }
            
            attack_Monster = Console.ReadLine();

            if (attack_Monster == "Dragon")
                {
                    Attaquer("Dragon");
                    number_Attack++;
                } else if (attack_Monster == "Gobelin")
                    {
                        Attaquer("Gobelin"); 
                        number_Attack++;
                    } else if (attack_Monster == "Zombie")
                        {
                            Attaquer("Zombie");
                            number_Attack++;
                        } else
                            {
                                Console.WriteLine("Le monstre " + attack_Monster + " ne fait pas parti des choix !");
                            }

            //Console.WriteLine(number_Attack);

            /*Attaquer("Dragon" + " Gobelin" + " Zombie");

            Attaquer("Dragon");
            Attaquer("Gobelin");
            Attaquer("Zombie");*/
        } while (/*attack_Monster != "Dragon" && attack_Monster != "Gobelin" && attack_Monster != "Zombie" ||*/ number_Attack != 4);
    }
}