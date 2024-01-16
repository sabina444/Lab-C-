namespace lab_7
{
    class Article
    {
        public Person Person { get; set; }

        public string Title { get; set; }
        public double Rating { get; set; }
        public Article(Person _person, string _title, double _rating)
        {
            Person = _person;
            Title = _title;
            Rating = _rating;
        }
        public Article()
        {
            Person = new Person("Василий", "Пупкин", new DateTime(1999, 9, 9));
            Title = "Название";
            Rating = 0;
        }
        public override string ToString()
        {
            return Person + " " + Title + " " + Rating;
        }
    }
}
