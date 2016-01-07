using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Total_Eclipse_Auto_Index_Wizard
{
    public class EclipseObject
    {


        public string FILE_NAME;
        public string FILE_TYPE;
        public string FILE_PATH;
        public string FILE_USER_FOLDER;
        public string FILE_SIZE;
        //If the object is an INI it will have these characteristics
        //These are full path references for the object
        public string INI_MAIN_PATH;
        public string INI_JOB_PATH;
        public bool DIF_BLOCK_PATH = false;
        public string INI_BLOCK_PATH;
        public string INI_MAIN_DICTIONARY_PATH;
        public List<string> INI_OTHER_DICTIONARY_FILE_NAME_LIST = new List<string>();
        

        /// These are the folder names, just "Blocks" or "TylerJobs"
        public string INI_JOB_FOLDER;
        public string INI_BLOCK_FOLDER;
        public string INI_MAIN_DICTIONARY_NAME;
        public string INI_DIXMAIN;
        public int PGH_COUNT;


        public string INI_SPELL_DIX; //This will only be something like "TylerF.esp", so need to combine w/ INI_JOB_PATH for reference
        public string[] INI_INFO_ARRAY;

        public EclipseObject(string name, string type, string path, string mainDir5)
        {
            this.FILE_NAME = name; //this is going to be a string ref. to the file, may be the same as path ultimately since that would force it to be unique
            this.FILE_TYPE = type; //is going to be ".INI", ".ECL", ".NOT", ".DIX", ".ESP", ".ESD" this is passed in as a literal string
            this.FILE_PATH = path; //should be the objects path i.e.: C:\Users\Docs\Eclipse\Tyler\job1.ecl
            this.FILE_USER_FOLDER = Path.GetDirectoryName(FILE_PATH);//trims off the actual file name to reveal the folder
            this.INI_BLOCK_PATH = null;
            if (type == ".ini")//if the file is an INI when we create we give it all these characteristics:
            {

                this.INI_INFO_ARRAY = File.ReadAllLines(this.FILE_PATH);

                foreach (String iniLine in INI_INFO_ARRAY)
                {
                    try
                    {

                        if (iniLine.StartsWith("Path") && iniLine.Contains("=MAIN="))
                        {
                            var parts = iniLine.Split('=');
                            if (parts[1].Contains("{DOC}"))
                            {
                                this.INI_MAIN_PATH = parts[1].Replace("{DOC}", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\");
                            }
                            else if (parts[1].Contains("{MAIN}"))
                            {
                                this.INI_MAIN_PATH = parts[1].Replace("{MAIN}", mainDir5 + "\\");
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }

                    try
                    {

                        if (iniLine.StartsWith("Path") && iniLine.Contains("=JOB="))
                        {
                            string[] JOB_PATH_ARRAY = iniLine.Split('=');
                            if (JOB_PATH_ARRAY.Last().Contains("{DOC}"))
                            {
                                this.INI_JOB_PATH = JOB_PATH_ARRAY.Last().Replace("{DOC}", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\");

                            }
                            else if (JOB_PATH_ARRAY.Last().Contains("{MAIN}"))
                            {
                                this.INI_JOB_PATH = JOB_PATH_ARRAY.Last().Replace("{MAIN}", mainDir5 + "\\");

                            }

                            else
                            {
                                this.INI_JOB_PATH = JOB_PATH_ARRAY.Last();
                            }
                            //this.INI_JOB_PATH = this.INI_JOB_PATH.Replace("{MAIN}", this.INI_MAIN_PATH + "\\");
                            this.INI_BLOCK_PATH = this.INI_JOB_PATH;

                            try
                            {

                                JOB_PATH_ARRAY = this.INI_JOB_PATH.Split('\\');
                                this.INI_JOB_FOLDER = JOB_PATH_ARRAY.Last();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }

                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                

                    if (this.INI_MAIN_DICTIONARY_NAME != null)
                    {
                        this.INI_MAIN_DICTIONARY_PATH = Path.Combine(this.INI_JOB_PATH + "\\" + this.INI_MAIN_DICTIONARY_NAME);
                    }                   


                    if (iniLine.StartsWith("Path") && iniLine.Contains("=DIXMAIN="))
                    {
                        try
                        {
                            var parts = iniLine.Split('=');
                            if (parts.Last().Contains("{DOC}"))
                            {
                                this.INI_DIXMAIN = parts.Last().Replace("{DOC}", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\") + "\\" + this.INI_MAIN_DICTIONARY_NAME;
                            }
                            else if (parts.Last().Contains("{MAIN}"))
                            {
                                this.INI_DIXMAIN = parts.Last().Replace("{MAIN}", mainDir5 + "\\") + "\\" + this.INI_MAIN_DICTIONARY_NAME;
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                    }

                    if (iniLine.StartsWith("Path") && iniLine.Contains("=BLOCK="))
                    {
                        var parts = iniLine.Split('=');
                        
                        if (parts.Last().Contains("{MAIN}"))
                        {
                            this.INI_BLOCK_PATH = parts.Last().Replace("{MAIN}", mainDir5 + "\\");
                        }
                        else if (parts.Last().Contains("{JOB}"))
                        {
                            this.INI_BLOCK_PATH = parts.Last().Replace("{JOB}", this.INI_JOB_PATH + "\\");
                        }
                        if (INI_BLOCK_PATH != null)
                        {

                            FileInfo blockFolderInfo = new FileInfo(this.INI_BLOCK_PATH);
                            this.INI_BLOCK_FOLDER = blockFolderInfo.Name;
                        }
                        //string[] INI_BLOCK_ARRAY = this.INI_BLOCK_PATH.Split('\\');
                        //this.INI_BLOCK_FOLDER = INI_BLOCK_ARRAY.Last();
                        
                    }

                    if (iniLine.StartsWith("MainDictionary="))
                    {
                        var parts = iniLine.Split('=');
                        this.INI_MAIN_DICTIONARY_NAME = parts[1];
                    }

                    if (iniLine.Contains("User") && iniLine.Contains("Dictionary=") && iniLine.Length > "UserXDictionary=".Length)
                    {
                        var parts = iniLine.Split('=');
                        INI_OTHER_DICTIONARY_FILE_NAME_LIST.Add(parts.Last() + ".dix");
                    }

                    if (iniLine.StartsWith("SpellUser="))
                    {
                        var parts = iniLine.Split('=');
                        this.INI_SPELL_DIX = parts[1];
                    }

                    if (iniLine.StartsWith("PghFormat"))
                    {
                        PGH_COUNT += 1;
                        var parts = iniLine.Split('=');
                        
                    }
                    

                }

                if (this.INI_BLOCK_PATH != null && !this.INI_BLOCK_PATH.Equals(this.INI_JOB_PATH))
                {
                    this.DIF_BLOCK_PATH = true;
                }
            }
        }


    }
}
