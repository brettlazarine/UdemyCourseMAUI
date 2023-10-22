using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemySQLiteMAUI.Abstractions;

namespace UdemySQLiteMAUI.MVVM.Models
{
    public class Passport : TableData
    {
        public DateTime ExpirationDate { get; set; }
    }
}
