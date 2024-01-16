using System.Xml.Linq;

namespace lab_9
{
    class Edition
    {
        protected string _name; //название издания
        protected DateTime _date; // дата выхода издания
        protected int _circulation; // тираж издания
        public Edition(string name_edition, DateTime date_edition, int circulation_edition) 
        {
            Name = name_edition;
            Date = date_edition;
            Circulation = circulation_edition;
        }
        public Edition() 
        {
            Name = "Название издания";
            Date = new DateTime();
            Circulation = 1;
        }
        public string Name
        {
            get { return _name;}
            set { _name = value;}
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public int Circulation
        {
            get { return _circulation; }
            set 
            { 
                _circulation = value; 
                if (value < 0) 
                {
                    throw new ArgumentException(" Тираж не может быть отрицательным. Пожалуйста, введите положительное значение.");
                }
            }
        }
        public virtual object DeepCopy()
        {
            Edition edition = new Edition(Name, Date, Circulation);
            return edition;
        }
        public override bool Equals(object obj)
        {
            if (obj is Edition other)
            {
                return GetHashCode() == other.GetHashCode();
            }

            return false;
        }
        public static bool operator ==(Edition left, Edition right) => left.Equals(right);
        public static bool operator !=(Edition left, Edition right) => !left.Equals(right);
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Date, Circulation);
        }
        public override string ToString()
        {
            return Name + " " + Date + " " + Circulation;
        }

    }
}
