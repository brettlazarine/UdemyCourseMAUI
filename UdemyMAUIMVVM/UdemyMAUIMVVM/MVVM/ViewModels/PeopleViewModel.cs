using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyMAUIMVVM.MVVM.Models;

namespace UdemyMAUIMVVM.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public List<Person> People { get; set; } = new();

        public PeopleViewModel()
        {
            People.Add(new Person { Name = "A", Age = 1, Married = true, Weight = 100, BirthDate = new DateTime(1990, 1, 1), Lunchtime = new TimeSpan(12, 0, 0) });
            People.Add(new Person { Name = "B", Age = 2, Married = false, Weight = 200, BirthDate = new DateTime(1990, 2, 1), Lunchtime = new TimeSpan(13, 0, 0) });
            People.Add(new Person { Name = "C", Age = 3, Married = true, Weight = 300, BirthDate = new DateTime(1990, 3, 1), Lunchtime = new TimeSpan(14, 0, 0) });
            People.Add(new Person { Name = "D", Age = 4, Married = false, Weight = 400, BirthDate = new DateTime(1990, 4, 1), Lunchtime = new TimeSpan(15, 0, 0) });
            People.Add(new Person { Name = "E", Age = 5, Married = true, Weight = 500, BirthDate = new DateTime(1990, 5, 1), Lunchtime = new TimeSpan(16, 0, 0) });
        }
    }
}
