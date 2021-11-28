using morenote_sync_cli.ExtensionMethod;
using morenote_sync_cli.Interface;
using morenote_sync_cli.Models.Model.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morenote_sync_cli.Models.Model
{
    /// <summary>
    /// 本地笔记存储库
    /// </summary>
    public class LocalNoteRepository
    {
        public string dir;
        public IPrinter printer;

        public LocalNoteRepository(string dir, IPrinter printer)
        {
            this.dir = dir;
            this.printer = printer;
        }

        public string GetRepositoryStatusFile()
        {
            return $"{dir}/.msync/RepositoryStatus.json".PathConvert();
        }

        public void InitUserInfo(AuthOk authOk, CommandModel commandModel)
        {
            RepositoryStatus repositoryStatus = new RepositoryStatus();
            repositoryStatus.Address=commandModel.GetParameterValue("-remote");
            repositoryStatus.SetAuthOk(authOk);

            string json = repositoryStatus.toBeautifulJson();
            if (!File.Exists($"{dir}/.msync/RepositoryStatus.json".PathConvert()))
            {
                var stream = File.Create($"{dir}/.msync/RepositoryStatus.json".PathConvert());
                stream.Close();
            }
            File.WriteAllText(GetRepositoryStatusFile(), json);
        }
    }
}