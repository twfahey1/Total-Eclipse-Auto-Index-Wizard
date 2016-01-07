using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Total_Eclipse_Auto_Index_Wizard
{
    public class TEInfoModule
    {
        public string CURRENT_SYSTEM_MAIN_DRIVE = Path.GetPathRoot(Environment.SystemDirectory);
        public string USER_DOCUMENTS_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        public string CURRENT_DESKTOP_PATH = Environment.GetFolderPath(
                         System.Environment.SpecialFolder.DesktopDirectory);

        public string CURRENT_USERFILE5;
        public string CURRENT_MAINDIRECTORY5;
        public string USERFILE5_LINE;

        public string USER_ECLIPSE_FOLDER;

        /*public string SELECTED_USER_INI;
        public string SELECTED_USER_JOB_FOLDER;
        public string SELECTED_USER_MAIN_DICTIONARY;*/

        public List<string> RECENT_FILE_PATH_LIST = new List<string>();
        public List<string> CURRENT_LOADED_INI = new List<string>();
        public List<EclipseObject> CURRENT_LOADED_INI_ECL_OBJS = new List<EclipseObject>();
        public List<string> JOB_INFO_LIST = new List<string>();
        public Dictionary<string, FileInfo> JOB_OBJECT_REFERENCE = new Dictionary<string, FileInfo>();

        //Collections for User Recover 
        public Dictionary<string, EclipseObject> RECOV_USERS_LOADED = new Dictionary<string, EclipseObject>();


        //Collections for Dix Recover 
        public Dictionary<string, EclipseObject> RECOV_DIX_LOADED = new Dictionary<string, EclipseObject>();

      

        /// Assist in transfer process
        public string TransferPath;
        //public string iniTransferPath;

        public bool BackupProcedureHappening;
        public bool RestoreProcedureHappening;
        public bool RecoverUserProcedureHappening;
        public bool RecoverDixProcedureHappening;
        public bool BackupChooseUsers;
        public bool BackupChooseFiles;
        public bool BackupPickDestination;

        public bool emailSendingHappening;

        public Dictionary<string, string> IniTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> FileTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> AllFilesTabTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> EssentialTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> JobsTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> WAVTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> ECLTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> DIXTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> NOTTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> PHBTransferList = new Dictionary<string, string>();
        public Dictionary<string, string> OtherTransferList = new Dictionary<string, string>();

        public bool progRunning = false;

        //If this evals to True, you will have variable CURRENT_MAINDIRECTORY5 and CURRENT_LOADED_INI_ECL_OBJS
        public bool ReadMainEclipseINI()
        {

           
            string currentWindowsFolderEclipseIniLocation = CURRENT_SYSTEM_MAIN_DRIVE + "\\Windows\\eclipse.ini";
            string[] result = { "" };
            try
            {
                result = File.ReadAllLines(currentWindowsFolderEclipseIniLocation);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            foreach (String iniLine in result)
            {
                ///This grabs the MainDir5 line, then splits to array delimited
                ///by =, then we get the second chunk of resulting array which is path,
                ///we replace {DOC} with current users personal folder
                if (iniLine.StartsWith("MainDirectory5"))
                {
                    var parts = iniLine.Split('=');
                    CURRENT_MAINDIRECTORY5 = parts[1].Replace("{DOC}", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\");
                }
                ///This should populate recent files list, each line starts
                ///with "File3=C:\Whatever"
                if (iniLine.StartsWith("File"))
                {
                    var parts = iniLine.Split('=');
                    RECENT_FILE_PATH_LIST.Add(parts[1]);
                }

            }
            if (CURRENT_MAINDIRECTORY5 != null)
            {
                BUILD_INI_LIST_FROM_PATH(CURRENT_MAINDIRECTORY5);
                return true;
            }
            return false;
        }

        public bool ValidateBackupsFolder(List<EclipseObject> userList)
        {
            RECOV_USERS_LOADED = new Dictionary<string, EclipseObject>();
            string EclipseBackups = CURRENT_SYSTEM_MAIN_DRIVE + "Eclipse Backups";
            string EclipseNTBackups = CURRENT_SYSTEM_MAIN_DRIVE + "EclipseNT Backups";
            if (Directory.Exists(EclipseBackups))
            {
                foreach (string file in Directory.GetFiles(EclipseBackups, "*.ub*",
                SearchOption.TopDirectoryOnly))
                {
                    if (Path.GetFileName(file) != null)
                    {
                        foreach (EclipseObject ini in userList)
                        {
                            if (Path.GetFileNameWithoutExtension(ini.FILE_NAME) == Path.GetFileNameWithoutExtension(file))
                            {
                                RECOV_USERS_LOADED.Add(Path.GetFullPath(file), ini);
                            }
                        }

                    }

                }
            }

            if (Directory.Exists(EclipseNTBackups))
            {
                foreach (string file in Directory.GetFiles(EclipseNTBackups, "*.ub*",
                SearchOption.TopDirectoryOnly))
                {
                    if (Path.GetFileName(file) != null)
                    {
                        foreach (EclipseObject ini in CURRENT_LOADED_INI_ECL_OBJS)
                        {
                            if (Path.GetFileNameWithoutExtension(ini.FILE_NAME) == Path.GetFileNameWithoutExtension(file))
                            {
                                RECOV_USERS_LOADED.Add(Path.GetFullPath(file), ini);
                            }
                        }

                    }

                }
            }
            if (RECOV_USERS_LOADED != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateDIXBackupsFolder(List<EclipseObject> userList)
        {
            RECOV_DIX_LOADED = new Dictionary<string, EclipseObject>();
            string EclipseBackups = CURRENT_SYSTEM_MAIN_DRIVE + "\\Eclipse Backups";
            string EclipseNTBackups = CURRENT_SYSTEM_MAIN_DRIVE + "\\EclipseNT Backups";
            
            if (Directory.Exists(EclipseBackups))
            {
                try
                {
                    foreach (string file in Directory.GetFiles(EclipseBackups, "*.db*",
                    SearchOption.TopDirectoryOnly))
                    {
                        if (Path.GetFileName(file) != null)
                        {
                            foreach (EclipseObject ini in userList)
                            {
                                if (Path.GetFileNameWithoutExtension(ini.INI_MAIN_DICTIONARY_PATH) == Path.GetFileNameWithoutExtension(file))
                                {
                                    RECOV_DIX_LOADED.Add(Path.GetFullPath(file), ini);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }

            if (Directory.Exists(EclipseNTBackups))
            {
                try
                {
                    foreach (string file in Directory.GetFiles(EclipseNTBackups, "*.db*",
                         SearchOption.TopDirectoryOnly))
                    {
                        if (Path.GetFileName(file) != null)
                        {
                            foreach (EclipseObject ini in userList)
                            {
                                if (Path.GetFileNameWithoutExtension(ini.INI_DIXMAIN) == Path.GetFileNameWithoutExtension(file))
                                {
                                    RECOV_DIX_LOADED.Add(Path.GetFullPath(file), ini);
                                }
                            }

                        }

                    }
                }
                catch
                {

                }
            }
            

            if (RECOV_DIX_LOADED != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void BUILD_INI_LIST_FROM_PATH(string path)
        {
            CURRENT_LOADED_INI = new List<string>();
            CURRENT_LOADED_INI_ECL_OBJS = new List<EclipseObject>();
            foreach (string ini in Directory.GetFiles(path, "*.ini*",
            SearchOption.TopDirectoryOnly)){
                if (Path.GetFileName(ini) != null)
                {
                    EclipseObject checkedObj = new EclipseObject(Path.GetFileName(ini), ".ini", ini, CURRENT_MAINDIRECTORY5);
                    if (checkedObj.INI_JOB_PATH != null)
                    {
                        CURRENT_LOADED_INI.Add(ini);
                        CURRENT_LOADED_INI_ECL_OBJS.Add(checkedObj);
                    }
                }
                
            }
        }

        public void BUILD_JOB_INFO_LIST(string userJobFolder)
        {
            JOB_INFO_LIST = new List<string>();
            try
            {

                foreach (string job in Directory.GetFiles(userJobFolder, "*.ecl",
                SearchOption.AllDirectories))
                {
                    JOB_INFO_LIST.Add(job);
                    FileInfo jobInfo = new FileInfo(job);
                    JOB_OBJECT_REFERENCE.Add(jobInfo.FullName, jobInfo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }


        public List<EclipseObject> SELECTED_INIS;

        public void INIS_SELECTED(List<EclipseObject> list)
        {
            SELECTED_INIS = list;
        }

        public List<EclipseObject> INIS_TO_BACKUP(List<EclipseObject> list)
        {
            List<EclipseObject> inis_to_bkup = new List<EclipseObject>();
            foreach (EclipseObject objGiven in list){
                inis_to_bkup.Add(objGiven);
            }
            return inis_to_bkup;
        }

        public Dictionary<EclipseObject, List<FileInfo>> iniObjDict = new Dictionary<EclipseObject, List<FileInfo>>();

        public void addIniObjForBackup(EclipseObject obj, List<FileInfo> assocFiles)
        {
            iniObjDict.Add(obj, assocFiles);
            
        }

        

        

    }

    

}
