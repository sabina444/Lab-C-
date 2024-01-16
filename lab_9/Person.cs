using System.Collections.Generic;

namespace lab_9
{
    class Person
    {
        private string _name;
        private string _firstName;
        private DateTime _date;
        public Person(string name, string firstName, DateTime date) 
        {
            Name = name;
            FirstName = firstName;
            Date = date;
        }
        public Person()
        {
            Name = "Name";
            FirstName = "FirstName";
            Date = new DateTime();
        }
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public string FirstName
        {
            get => _firstName;
             set => _firstName = value;
        }
        public DateTime Date
        {
            get => _date;
            private set => _date = value;
        }
        public int Year
        {
            get => Date.Year;
            private set =>
            Date = new DateTime(value, Date.Month, Date.Day);
        }
        public override string ToString()
        {
            return Name + " " + FirstName + " " + Date;
        }
        public virtual string ToShortString()
        {
            return Name + " " + FirstName;
        }
        public override bool Equals(object obj)
        {
            if (obj is Person other) 
            {
                return GetHashCode() == other.GetHashCode();
            }

            return false;
        }
        public static bool operator ==(Person left, Person right) => left.Equals(right);
        public static bool operator !=(Person left, Person right) => !left.Equals(right);
        public override int GetHashCode() 
        {
            return HashCode.Combine(Name, FirstName, Date); 
        }
        public object DeepCopy() 
        {
            Person person = new Person(Name, FirstName, Date);
            return person;
        }
    }
}

