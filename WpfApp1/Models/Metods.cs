using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    public class Metods
    {
        public static string AddBook(string name)
        {

            string result = "Уже существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.Migrate();
                bool check = db.AdressBooks.Any(el => el.Name == name);
                if (!check)
                {
                    AdressBook newadressbook = new AdressBook
                    {

                        Name = name

                    };
                    db.AdressBooks.Add(newadressbook);
                    db.SaveChanges();
                    result = "Сделано";
                }
                return result;
            }
        }
    }
}
