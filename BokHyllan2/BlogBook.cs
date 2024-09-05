using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BokHyllan2
{
    internal class BlogBook : Book  // arv från book klass
    {
        public BlogBook(string _titel, string _writer, int _releaseDate) : base(_titel, _writer, _releaseDate)
        {
            Type = "BlogBook"; // spara detta värde varej gång när ett öbjekt instansiera av detta klass
        }
        public override string ToString() //Metod som visar bok information 
        {
            return "\"" + Titel + "\" skriven av " + Aurthor + "\"" + "   utgivningsår  " + +releaseDate + ". " + Type + "Finns i BloggHyllan";
        }
    }
}
