using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class Backup_Restore_BLL
    {
        Backup_Restore_DAL bc_rt_dal = new Backup_Restore_DAL();

        public bool BackupFull(string defaultFolderPath)
        {
            return bc_rt_dal.BackupDatabase(defaultFolderPath);
        }
        public bool RestoreFull(string defaultFolderPath, string databaseName)
        {
            return bc_rt_dal.RestoreDatabase(defaultFolderPath, databaseName);
        }
    }
}
