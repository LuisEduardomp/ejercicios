class StudentAndTeacherTest
    {
        static void Main(string[] args) // Example of program usage
        {
            Person person = new Person("Eduardo");
            person.Greet();


            Student student = new Student("Luis Eduardo");
            student.SetAge(21);
            student.Greet();
            student.ShowAge();


            Teacher teacher = new Teacher("Jose");
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();


            Console.ReadKey();
        }
    }


    class Person
    {
        protected string name;
        protected int age;


        public Person(string name)
        {
            this.name = name;
        }


        public virtual void Greet() // Method for greeting
        {
            Console.WriteLine("La persona " + name + " dise hola.");
        }




        public void SetAge(int n) // Method for setting age
        {
            this.age = n;
        }
    }
    
    class Student : Person
    {
        public Student(string name) : base(name)
        {


        }


        public void ShowAge()
        {
            Console.WriteLine("Mi edad es de " + age + " anos.");
        }


        public void GoToClasses()
        {
            Console.WriteLine("Voy a clases.");
        }


        public override void Greet() // Overridden method for greeting in class Student
        {
            Console.WriteLine("El estudiante " + name + " dice hola.");
        }
    }


    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {


        }


        public void Explain()
        {
            Console.WriteLine("Comienza la explicación.");
        }
        public override void Greet() // Overridden method for greeting in class Teacher
        {
            Console.WriteLine("El maestro " + name + " dice hola.");
        }
    }
