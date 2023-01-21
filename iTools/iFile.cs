using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTools
{
    public class iFile
    {
        protected string path;

        public iFile(string path)
        {
            this.path = path;
        }

        public bool iCopy()
        {
            bool rs = false;
            try
            {
                FileInfo fi = new FileInfo(path);
            }
            catch (Exception ex)
            {
                iMessage.errorMsg("Erreur", ex.Message);
                rs = false;
            }
            return rs;
        }
    }
}