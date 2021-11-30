using System;

namespace Pet
{
    class Program
    {



        class Pet
        {
            string name;
            int age;
            double weight;


            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congratulations! you have adopted {name}");
            }
            public double Weight
            {
                get { return weight; }
            }

            public void ShowPetInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Weight: {weight}");
            }


            public void Eat()
            {
                weight += 0.2;
                Console.WriteLine("NomNomNom");
                
            }

            public void run()
            {
                weight -= 0.2;
                Console.WriteLine("Pam-Pam-Pam");
            }

            //~Pet()
            //{
            //    Console.WriteLine($"R.I.P {Name}");
            //}




        }


        static void Main(string[] args)
        {
            Pet myPet = new Pet("Bear");
            myPet.ShowPetInfo();

            for(int i = 0; i < 10; i++)
            {
                myPet.Eat();
                Console.WriteLine($" Current Weight: {myPet.Weight}");
                if(myPet.Weight >= 0.7)
                {
                    while (myPet.Weight > 0.7)
                    {
                        myPet.run();
                        Console.WriteLine($" Weight after workout: {myPet.Weight}");
                    }
                }
            }


            
            //GC.Collect();
        }
    }
}
