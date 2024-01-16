namespace lab_7
{
    class Person
    {
        private string Name;
        private string FirstName;
        private DateTime Date;
        public Person(string _name, string _firstName, DateTime _date)
        {
            name = _name;
            FirstName = _firstName;
            Date = _date;
        }
        public Person()
        {
            Name = "Name";
            FirstName = "FirstName";
            Date = new DateTime();
        }
        public string name
        {
            get => Name;
            private set => Name = value;
        }
        public string firstName
        {
            get => FirstName;
            private set => FirstName = value;
        }
        public DateTime date
        {
            get => Date;
            private set => Date = value;
        }
        public int year
        {
            get => Date.Year;
            private set =>
            Date = new DateTime(value, Date.Month, Date.Day);
        }
        public override string ToString()
        {
            return Name + " " + FirstName + " " + Date.ToString();
        }
        public virtual string ToShortString()
        {
            return Name + " " + FirstName;
        }
    }

}
