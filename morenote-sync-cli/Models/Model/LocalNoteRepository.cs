using morenote_sync_cli.Interface;
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
        public  string dir;
        public IPrinter printer;
        public LocalNoteRepository(string dir,IPrinter printer)
        {
            this.dir = dir;
            this.printer = printer;
        }

        public void Init()
        {

        }
    }
}
