using System;
class Tester
{
    static void Main(string[] args)
    {
        Man Man1 = new Man();   
        Man Man2 = new Man();   
        Man Man3 = new Man();   
       

      
        Man1.setHeight(6.0);
        Man1.setWeight(66.0);
        

      
        Man2.setHeight(5.11);
        Man2.setWeight(75.0);
        
        Console.WriteLine("Height of Man1 : " + Man1.getHeight());
        Console.WriteLine("Weight of Man1 : " + Man1.getWeight());
        Console.WriteLine();
        
        Console.WriteLine("Height of Man2 : " + Man2.getHeight());
        Console.WriteLine("Weight of Man2 : " + Man2.getWeight());
        Console.WriteLine();
        
        Man3 = Man1 + Man2; //here addition of two man object takes place.
      
        Console.WriteLine("Height of Man3 : "+ Man3.getHeight());
        Console.WriteLine("Weight of Man3 : " + Man3.getWeight());
        
        Console.ReadKey();
    }
}