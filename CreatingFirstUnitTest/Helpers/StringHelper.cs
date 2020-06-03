using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelper
    {
        //Requirement
        //1-girilen ifadenin başındaki ve sonundaki boşluklar silinmelidir
        //2-girilen ifadenin içindeki fazla boşluklar silinmelidir.
        public static string DeleteUnNecessarySpace(string text)
        {
            text = text.Trim();
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' && text[i + 1] == ' ')
                {
                    continue;
                }
                newText += text[i];
            }
            return newText;
        }
    }
}
