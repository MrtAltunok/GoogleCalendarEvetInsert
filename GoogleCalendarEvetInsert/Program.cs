using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleCalendarEvetInsert
{
    class Program
    {
        private const string DatesFormat = "yyyyMMdd";
        private const string TimeFormat = "HHmmss";


        static void Main(string[] args)
        {
            EventCreate(DateTime.Now, DateTime.Now, DateTime.Now,"Başlık Yer Alıyor Burada","İçerik yer alacak tam burada\ndevamına burada olacak");
        }
        public static void EventCreate(DateTime dates, DateTime _starttime, DateTime _stopTime, string title, string details)
        {
            
            string tarih = DateTime.Parse(dates.AddDays(2).ToLongDateString()).ToString(DatesFormat);
            string starttime = DateTime.Parse(dates.ToLongTimeString()).ToString(TimeFormat);
            string stoptime = DateTime.Parse(dates.AddHours(1).ToLongTimeString()).ToString(TimeFormat);

            string _title = title.Replace(" ","+");
            string _details = details.Replace(" ","+").Replace("\n","<br/>");//Boşlukları + ile değiştiriyoruz ayrıca eğer yeni bir satır var ise onuda aşağı alıyoruz
           

            string link = $"https://calendar.google.com/calendar/u/0/r/eventedit?dates={tarih}T{starttime}/{tarih}T{stoptime}&text={_title}&details={_details}";
            Console.WriteLine(link);
            Console.ReadKey();
        }
    }
}
