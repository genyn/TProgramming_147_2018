using System;

namespace checke
{

  public class Person
    {
        private string name;
        private int age;
        public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(int age )
            : this( age, "Noname")
        {
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }

        public string GetInfo()
        {
            return $"Имя: {name}  Возраст: {age}";
        }
    }
}