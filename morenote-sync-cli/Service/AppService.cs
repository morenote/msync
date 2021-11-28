using morenote_sync_cli.ExtensionMethod;
using morenote_sync_cli.Models.Model;
using morenote_sync_cli.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morenote_sync_cli.Service
{
    public class AppService
    {
        private CommandModel cmd;

        public AppService(CommandModel cmd)
        {
            this.cmd = cmd;
        }

        public void Init()
        {
            Console.WriteLine("正在初始化文件夹");
            var curDir = PathUtil.GetCurDir();

            if (Directory.Exists($"{curDir}/.Config".PathConvert()))
            {
                Console.WriteLine(".Config已经存在");
            }
            else
            {
                Directory.CreateDirectory($"{curDir}/.Config".PathConvert());
            }
            if (File.Exists($"{curDir}/.Config/Status.json".PathConvert()))
            {
                Console.WriteLine("已经初始化status.json，无需初始化");
            }
            else
            {
                File.Copy($"{PathUtil.GetExeDir()}/.Config/Status.json".PathConvert(), $"{curDir}/.Config/Status.json".PathConvert());
                Console.WriteLine("已经初始化status.json");
            }
            ConsoleUtil.WriteLine("Success!!!", ConsoleColor.Green);
        }
        /// <summary>
        /// 克隆笔记到当前文件夹
        /// </summary>
        public void Clone()
        {
            

        }
    }
}