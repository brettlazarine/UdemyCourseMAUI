using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyMAUIMVVM.MVVM.Models;

namespace UdemyMAUIMVVM.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }
        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Brett",
                Age = 32,
                Married = true,
                BirthDate = new DateTime(1991, 08, 27),
                Weight = 190,
                Lunchtime = new TimeSpan(11, 30, 0)
            };
        }
    }
}