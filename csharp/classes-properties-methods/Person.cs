


public class Person
{
    
   public string Name{get; set;} 
   public int Age{ get; set;}

   public Person(string name, int age)
   {
     
     Name = name;
     Age = age;
     
   }

   public void Presentera()
    {
        
        Console.WriteLine("Ditt namn är " + Name + " och din ålder är " + Age);
    }




}