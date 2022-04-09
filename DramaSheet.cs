using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DramaLister
{
    [Serializable]
    public class DramaSheet : List<Drama>
    {
        public string dramaSheetName { get; set; }

        /// <summary>
        /// BELOW A GETTER AND "SETTER" FOR A LIST
        /// </summary>
        BindingList<Drama> Dramas = new BindingList<Drama>();
        public BindingList<Drama> dramas
        {
            // no setter
            get { return Dramas; }
        }
        /// <summary>
        /// ABOVE A GETTER AND "SETTER" FOR A LIST
        /// </summary>

        public DramaSheet()
        {

        }
        public DramaSheet(string DramaSheetName)
        {
            dramaSheetName = DramaSheetName;
        }
    }
}
