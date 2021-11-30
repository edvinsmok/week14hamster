using System;

namespace ConsoleApp2
{
    class Program
    {
        class Pet
        {
            string name;
            int age;
            double weight;


            public Pet(string _name){
                name = _name;
                age = 0;
                weight = 0.1;
                Console.WriteLine($"Congratulations, You ve adopted {name}.");

            }
            
            public double Weight{
                get { return weight; }
            }
            
            
            
            
            public void ShowPetInfo()
            {
                Console.WriteLine($"name: {name}");
                Console.WriteLine($"age. {age}");
                Console.WriteLine($"weight: {weight}");
            }
            
            public void Eat()
            {
                weight += 0.2;
                Console.WriteLine("omnomnomn");
            }

            public void Run()
            {
                weight -= 0.1;
                Console.WriteLine("run run run");
            }

            //~Pet()
            //{
            //    Console.WriteLine($"RIP {name}");

            //}


        
        }

        static void Main(string[] args)
        {
            Pet myPet = new Pet("Hamster");
            myPet.ShowPetInfo();

            for (int i= 0; i < 10; i++)
            {
                myPet.Eat();
                Console.WriteLine($"current weight: {myPet.Weight}"); 
                if(myPet.Weight >= 0.7)
                {
                    while (myPet.Weight > 0.7) 
                    {
                        myPet.Run();
                        Console.WriteLine($"current after workout: {myPet.Weight}");
                    }

                    
                }
            }
            
            
            
            
            //G/*C.Collect();*/
        }
    }
}
