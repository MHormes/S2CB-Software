using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataCollectingApp
{
    public class VoteSaver
    {

        private int firstCount = 0;
        private int secondCount = 0;

        public Exception SaveVote(string userInput, string cityName)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream($"votesFrom{cityName}", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);

                sw.WriteLine(userInput);
                return null;
            }
            catch (IOException ex)
            {
                return ex;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }

            }
        }


        public Exception CompareVotes(string team1, string team2, string fileName)
        {
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                string s;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    if (s.Contains(team1))
                    {
                        firstCount++;
                    }
                    else if (s.Contains(team2))
                    {
                        secondCount++;
                    }
                }
                return null;
            }
            catch (IOException ex)
            {
                return ex;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        public int GetTeam1Votes()
        {
            return firstCount;
        }

        public int GetTeam2Votes()
        {
            return secondCount;
        }
    }
}
