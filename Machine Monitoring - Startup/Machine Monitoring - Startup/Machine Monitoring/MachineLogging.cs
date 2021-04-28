using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Machine_Monitoring
{
    public class MachineLogging
    {
        private List<string> log;

        public MachineLogging()
        {
            log = new List<string>();
        }

        public void AddWarningToLog(string warning)
        {
            log.Add(warning);
        }

        public Exception SaveToFile()
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream("WarningLog", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);

                foreach(string s in log)
                {
                    sw.WriteLine(s);
                }
                return null;
            }
            catch(IOException ex)
            {
                return ex;
            }
            finally
            {
                if (sw != null){ sw.Close(); }
            }
        }

        public Exception LoadFromFile()
        {
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream("WarningLog", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    log.Add(sr.ReadLine());
                }
                return null;
            }
            catch (IOException ex)
            {
                return ex;
            }
            finally
            {
                if (sr != null) { sr.Close(); }
            }
        }
    }
}
