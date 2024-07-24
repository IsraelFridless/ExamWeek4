using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWeek4.Configuration
{
    internal static class KetubahConfig
    {
        public static readonly string _path = Path.
            Combine(Directory.GetCurrentDirectory(), "Ketubah.xml");
    }
}
