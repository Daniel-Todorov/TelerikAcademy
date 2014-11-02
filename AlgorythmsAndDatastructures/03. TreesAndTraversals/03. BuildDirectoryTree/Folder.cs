namespace _03.BuildDirectoryTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Folder
    {
        public Folder(string name, File[] files, Folder[] childFolders)
            : this(name, files)
        {
            this.ChildFolders = childFolders;
        }

        public Folder(string name, File[] files)
            : this(name)
        {
            this.Files = files;
        }

        public Folder(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public File[] Files { get; set; }

        public Folder[] ChildFolders { get; set; }
    }
}
