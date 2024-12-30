namespace OOP_01
{
    // 1. Struct
    // 2. Class
    // 3. Interface
    // 4. Enum
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            // Struct : Value Types : Stack

            //Point P01;
            // Declare for object from type "Point"
            // P01 : Object
            // allocate uninitialized 8 bytes in the memory x=4 bytes, y=4 bytes

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01.X = 10;
            //P01.Y = 20;
            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //Point P02 = new Point(2,3); // call the constructor
            //Console.WriteLine(P02.X);
            //Console.WriteLine(P02.Y);

            //P01.Print(); 
            #endregion


            #region OOP
            // OOP: Object Oriented Programming
            // Programming Paradigm
            // OOP : the paradigm use for build any software

            // Class : Blueprint of the object
            // Object : Instance of the class

            // 4 Pillars of OOP
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Polymorphism
            // 4. Abstraction 
            #endregion

            // 1. Encapsulation
            // seprate the data(Atributes) definition from its use

            // 1. End user access data itself
            // 2. No data validation
            // 3. No read only filed

            // Apply Encapsulation
            // 1. Make all dat(Attributes) private
            // 2. Access Data through
                // 2.1. Setter and Getter method
                // 2.2. Properties

            Employee E01 = new Employee();
            //E01.id = 1;
            //E01.name = "Ahmed";
            //E01.salary = 1000;

            //Console.WriteLine(E01.id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            //E01.SetId(1);
            //E01.setName("Ahmed");
            //E01.setSalary(-1000);

            //Console.WriteLine(E01.getSalary());
            //Console.WriteLine(E01.GetId());
            //Console.WriteLine(E01.getName());

            //E01.Id = 1;
            //E01.Name = "Ahmdded";
            //E01.Salary = 1000;
            //E01.Address = "Cairo";

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.Name);
            //Console.WriteLine(E01.Salary);
            //Console.WriteLine(E01.Address);

            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed", 123456, 0);
            //phoneBook.AddPerson("Ali", 654321, 1);
            //phoneBook.AddPerson("Mohamed", 987654, 2);

            //Console.WriteLine(phoneBook.GetNumber("Ahmed"));


            // Class : Reference Types : Heap
            Car C01;
            // Declare for Reference (Pointer) from type "Car"
            // C01 : can refer to object from type "Car" or any calss inherited from "Car"
            // C01 : refer to null
            
            C01 = new Car();
            // New
            // Allocate the required bytes in the heap for the object
            // initialize the allocated bytes with the default values
            // call user defined constructor if exsist
            // assign the object to reference

            Console.WriteLine(C01);
        }
    }
}
