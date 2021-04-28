using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Machine_Monitoring
{
    public class MachineManager
    {
        public MachineLogging ML;

        private List<Machine> machines;
        private List<string> warnings;
        
        public bool Loggin
        {
            get; set;
        }
        public MachineManager()
        {
            ML = new MachineLogging();
            machines = new List<Machine>();
            warnings = new List<string>();
        }

        public List<string> GetWarnings()
        {
            return this.warnings;
        }

        public List<Machine> GetAllMachines()
        {
            return this.machines;
        }

        public Machine GetMachine(string name)
        {
            foreach(Machine m in machines)
            {
                if(m.Name == name)
                {
                    return m;
                }
            }
            return null;
        }
        public Exception AddMachine(string name, string temp, string press)
        {
            try
            {
                if (!Regex.IsMatch(temp, @"^[0-9]*$"))
                {
                    throw new IncorrectInputException(temp);
                }

                if (!Regex.IsMatch(press, @"^[0-9]*$"))
                {
                    throw new IncorrectInputException(press);
                }

                foreach (Machine m in machines)
                {
                    if (m.Name == name)
                    {
                        throw new ExistingNameException(name);
                    }
                }

                Machine newMachine = new Machine(name, Convert.ToInt32(temp), Convert.ToInt32(press));
                machines.Add(newMachine);


                return null;
            }
            catch(IncorrectInputException inputEx)
            {
                return inputEx;
            }
            catch(ExistingNameException nameEx)
            {
                return nameEx;
            }
        }

        public Exception ChangeTemp(string name, string temp)
        {
            try
            {
                if (!Regex.IsMatch(temp, @"^[0-9]*$"))
                {
                    throw new IncorrectInputException(temp);
                }

                foreach (Machine m in machines)
                {
                    if (m.Name == name)
                    {
                        m.Temperature = Convert.ToInt32(temp);
                        var warningTemp = m.WarningTemp();
                        if (warningTemp != null)
                        {
                            warnings.Add(warningTemp);
                            if(Loggin == true)
                            {
                                ML.AddWarningToLog(warningTemp);
                            }
                        }
                        return null;
                    }
                }
                throw new NameNotFoundException(name);
                
            }
            catch(NameNotFoundException nameEx)
            {
                return nameEx;
            }
            catch(IncorrectInputException inputEx)
            {
                return inputEx;
            } 
        }

        public Exception ChangePress(string name, string press)
        {
            try
            {
                if (!Regex.IsMatch(press, @"^[0-9]*$"))
                {
                    throw new IncorrectInputException(press);
                }

                foreach (Machine m in machines)
                {
                    if (m.Name == name)
                    {
                        m.Pressure = Convert.ToInt32(press);
                        var warningPress = m.WarningPress();
                        if (warningPress != null)
                        {
                            warnings.Add(warningPress);
                            if (Loggin == true)
                            {
                                ML.AddWarningToLog(warningPress);
                            }
                        }
                        return null;
                    }
                }
                throw new NameNotFoundException(name);

            }
            catch (NameNotFoundException nameEx)
            {
                return nameEx;
            }
            catch (IncorrectInputException inputEx)
            {
                return inputEx;
            }
        }
    }
}
