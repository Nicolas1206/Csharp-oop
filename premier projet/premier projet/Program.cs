using System;

namespace premier_programme
{
    class Program
    {
        static int DemanderAge()
        {
            int ageNum = 0;

            while (ageNum <= 0)
            {
                Console.WriteLine("Quel est votre age?");
                string ageString = Console.ReadLine();

                try
                {
                    ageNum = int.Parse(ageString);

                    if (ageNum < 0 || ageNum == 0)
                    {
                        Console.WriteLine("Error");
                    }
                }
                catch
                {
                    Console.WriteLine("Vous devez rentrer un age valide!");
                }
            }
            return ageNum;

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string nom = "";
            while(nom == "") 
            { 
            Console.WriteLine("Quel est ton nom?");
            nom = Console.ReadLine();
                nom = nom.Trim();
                if (string.IsNullOrEmpty(nom))
                {
                    Console.WriteLine("La chaine de caractère est vide");
                }
            }
            int age = DemanderAge();
                Console.WriteLine("Bonjour vous vous appelez " + nom + " " + "et vous avez " + age + " " + "ans.");
                int ageProchain = age + 1;
                Console.WriteLine("Bientot vous aurez: " + ageProchain + ".");
            }
        }
    }
