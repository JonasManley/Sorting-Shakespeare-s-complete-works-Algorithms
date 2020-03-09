using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SortingShakespeare.Helpers
{
    class ReadTxtFile
    {
        private string shakespearText;
        private string shakespearTextLowercase;
        private string shakespearTextLowercaseOnlyText;
        private string[] shakespearTextArray;

        public ReadTxtFile(string filelocation)
        {
            shakespearText = System.IO.File.ReadAllText(filelocation);
            shakespearTextLowercase = shakespearText.ToLower();
            ModifiData();
        }

        public string ShakespearText
        {
            get { return shakespearText; }
            set { shakespearText = value; }
        }

        public string[] ShakespearTextArray
        {
            get { return shakespearTextArray; }
            set { shakespearTextArray = value; }
        }


        // Removes everything else letters.
        public void ModifiData()
        {
            Regex regex = new Regex("[^a-zA-Z]");
            shakespearTextLowercaseOnlyText = regex.Replace(shakespearTextLowercase, " ");
            shakespearTextArray = shakespearTextLowercaseOnlyText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
