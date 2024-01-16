namespace lab_9
{
    class Article : IRateAndCopy
    {
        public Person Person { get; set; }

        public string Title { get; set; }
        public double Rating { get; set; }
        public Article(Person person, string title, double rating)
        {
            Person = person;
            Title = title;
            Rating = rating;
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
        public object DeepCopy()
        {
            Article article = new Article((Person)Person.DeepCopy(), Title, Rating);
            return article;
        }

    }
}
