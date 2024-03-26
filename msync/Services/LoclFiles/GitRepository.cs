using LibGit2Sharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msync.Services.LoclFiles
{
	public class GitRepository
	{
		public void Init(string path)
		{
			string rootedPath = Repository.Init(path);
		}

	}
}
