using System.Runtime.CompilerServices;

Person p1 = new Person("Петр", 22);
Console.WriteLine(p1.GetInfo());


for (int i=0; i<=20; i++)
{
    if(i%2==0){
    Console.Write($"{i} ");
    }
}
class Person
{
    int age = 0;
    string name  = "None";

    public Person(string Name, int Age){
        this.name = Name;
        this.age  = Age;
    }

    public string GetInfo(){
        
        return(name+", "+age);
    }  
}
