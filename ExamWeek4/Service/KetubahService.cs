using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ExamWeek4.Configuration.KetubahConfig;

namespace ExamWeek4.Service
{
    internal static class KetubahService
    {
        public static void CreateXmlIfNotExists()
        {
            if (!File.Exists(_path))
            {
                XDocument document = new ();
                XElement queries = new("Queries");
                document.Add(queries);
                document.Save(_path);
            }
        }

        public static string AddDate(string day, string dayMonth, string month, string year)
        {
            string choosenDay = day switch
            {
                "ראשון" => "אחד",
                "שני" => "שני",
                "שלישי" => "שלישי",
                "רביעי" => "רביעי",
                "חמישי" => "חמישי",
                "ששי" => "ששי"
            };

            string choosenDayMonth = dayMonth switch
            {
                "1" => "יום אחד",
                "2" => "שני ימים",
                "3" => "שלשה ימים",
                "4" => "ארבעה ימים",
                "5" => "חמשה ימים",
                "6" => "ששה ימים",
                "7" => "שבעה ימים",
                "8" => "שמנה ימים",
                "9" => "תשעה ימים",
                "10" => "עשרה ימים",
                "11" => "אחד עשר יום",
                "12" => "שנים עשר יום",
                "13" => "שלשה עשר יום",
                "14" => "ארבעה עשר יום",
                "15" => "חמשה עשר יום",
                "16" => "ששה עשר יום",
                "17" => "שבעה עשר יום",
                "18" => "שמנה עשר יום",
                "19" => "תשעה עשר יום",
                "20" => "עשרים יום",
                "21" => "אחד ועשרים יום",
                "22" => "שנים ועשרים יום",
                "23" => "שלשה ועשרים יום",
                "24" => "ארבעה ועשרים יום",
                "25" => "חמשה ועשרים יום",
                "26" => "ששה ועשרים יום",
                "27" => "שבעה ועשרים יום",
                "28" => "שמנה ועשרים יום",
                "29" => "תשעה ועשרים יום",
                "30" => "יום שלושים"
            };

            string choosenYear = year switch
            {
                @"תשפ""ד" => "חמשת אלפים ושבע מאות ושמנים וארבע",
                @"תשפ""ה" => "חמשת אלפים ושבע מאות ושמנים וחמש",
                @"תשפ""ו" => "חמשת אלפים ושבע מאות ושמנים ושש",
                @"תשפ""ז" => "חמשת אלפים ושבע מאות ושמנים ושבע",
                @"תשפ""ח" => "חמשת אלפים ושבע מאות ושמנים ושמנה",
                @"תשפ""ט" => "חמשת אלפים ושבע מאות ושמנים ותשע",
                @"תש""צ" => "חמשת אלפים ושבע מאות ותשעים",
                @"תשצ""א" => "חמשת אלפים ושבע מאות ותשעים ואחת",
                @"תשצ""ב" => "חמשת אלפים ושבע מאות ותשעים ושתים",
                @"תשצ""ג" => "חמשת אלפים ושבע מאות ותשעים ושלש",
                @"תשצ""ד" => "חמשת אלפים ושבע מאות ותשעים וארבע",
            };

            
        
            XDocument document = XDocument.Load(_path);
            XElement? Queries = document.Descendants("Queries").FirstOrDefault();
            XElement? Query = new("Query", new XElement("Day", day), new XElement("DayMonth", dayMonth), new XElement("Month", month), new XElement("Year", year));
            string result = $"ב{choosenDay} בשבת ב{choosenDayMonth} לירח {month} שנת {choosenYear} לבריאת העולם";
            XElement? resultElement = new("Result", result);
            Query.Add(resultElement);
            Queries?.Add(Query);
            document.Save(_path);
            return result;
        }
    }
}
