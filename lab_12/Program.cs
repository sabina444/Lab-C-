using lab_12;
using System;
using System.Linq;

class Program 
{
    private static object n;

    private static void Main(string[] args)
    {
        string line_ = "----------------------------------------";
        using (var sr = new StreamReader("C:\\Users\\Sabina\\Desktop\\личности.txt"))
        {
            var lines = sr.ReadToEnd().Split('\n');
            var persons = new List<Person>();

            foreach (var line in lines)
            {
                var data = line.Split(' ');
                var person = new Person();
                person.Name = data[0];
                person.LastName = data[1];
                person.Age = Convert.ToInt32(data[2]);
                persons.Add(person);
            }

            Console.WriteLine("Изначальный список:");

            foreach (var person in persons) 
            {
                Console.WriteLine(person.ToString());
            }

            // Фильтрация

            var vowels = new List<char> { 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я'};

            var selectedPeople = from p in persons
                                 where vowels.Contains((p.LastName[0]))
                                 && p.Age >= 18
                                 select p;

            Console.WriteLine(line_);
            Console.WriteLine("Совершеннолетние личности с фамилией начинающейся с гласной буквы:");

            foreach (var person in selectedPeople) 
            {
                Console.WriteLine($"{person.Name} {person.LastName}, Возраст: {person.Age}"); 
            }

            // Проекция

            var projection = persons.Select(p =>
            new PersonProjection
            {
                Name = p.Name,
                LastName = p.LastName,
                IsAdult = p.Age >= 18
            });

            Console.WriteLine(line_);
            Console.WriteLine("Проекция.Новый тип со свойствами: имя, фамилия, совершеннолетний/ несовершеннолетний:");

            foreach (var person in projection)
            {
                Console.WriteLine($"{person.Name} {person.LastName}, Совершеннолетний: {person.IsAdult}");
            }

            // Сортировка

            var orderedPeople = persons.OrderBy(p => p.LastName).ThenBy(p => p.Age); // сортировка по возрастанию

            Console.WriteLine(line_);
            Console.WriteLine("Сортировка по фамилии и возрасту:");

            foreach (var person in orderedPeople)
            {
                Console.WriteLine($"{person.Name} {person.LastName} - {person.Age}");
            }

            // Группировка

            var groupedPeople = persons.GroupBy(p => p.LastName); 

            Console.WriteLine(line_);
            Console.WriteLine("Группировка по фамилии:");

            foreach (var group in groupedPeople)
            {
                Console.WriteLine($"Фамилия: {group.Key}");
                foreach (var person in group)
                {
                    Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
                }
                Console.WriteLine();
            }

            var groupedPeople2 = persons.GroupBy(p => p.LastName)
                                  .Select(group => new { LastName = group.Key, Count = group.Count() });

            Console.WriteLine(line_);
            Console.WriteLine("Группировка по фамилии с количеством людей:");
           
            foreach (var group in groupedPeople2)
            {
                Console.WriteLine($"Фамилия: {group.LastName}, Количество: {group.Count}");
            }

            // Агрегатные функции

            var countPeople = persons.Count(p => p.Age >= 18);

            Console.WriteLine(line_);
            Console.WriteLine($"Количество совершеннолетних: {countPeople}");

            // Извлечение Skip, Take, SkipWhile, TakeWhile

            var skipPeople = persons.Take(persons.Count()/2); 

            Console.WriteLine(line_);
            Console.WriteLine("Извлечение из списка половины элементов:");

            foreach (var person in skipPeople)
            {
                Console.WriteLine($"{person.Name} {person.LastName} {person.Age}");
            }

            // Проверка All и Any

            var checkPeople = persons.Any(p => p.Age < 18);

            Console.WriteLine(line_);
            Console.WriteLine($"Наличие несовершеннолетних: {checkPeople}");

            //Объединение двух последовательностей 

            var person1 = new Person("Владимир","Подсолнух", 12);
            var person2 = new Person("Александр", "Голубятников", 24);
            var person3 = new Person("Александра", "Голубятникова", 6);
            var person4 = new Person("Анастасия", "Зайцева", 69);

            var personList = new List<Person>
            {
                person1,
                person2,
                person3,
                person4
            };

            var result = persons.Union(personList);

            Console.WriteLine(line_);
            Console.WriteLine("Объединения двух последовательностей:");

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} {person.LastName} {person.Age}");
            }
        }
    }
}
