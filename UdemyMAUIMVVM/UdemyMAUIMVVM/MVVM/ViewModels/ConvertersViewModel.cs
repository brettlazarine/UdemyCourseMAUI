using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyMAUIMVVM.MVVM.Models;

namespace UdemyMAUIMVVM.MVVM.ViewModels
{
    public class ConvertersViewModel
    {
        public Data Data { get; set; }

        public ConvertersViewModel()
        {
            Data = new Data
            {
                Married = "YES"
            };
        }
    }
}
