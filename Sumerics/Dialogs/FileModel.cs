﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Sumerics
{
    /// <summary>
    /// The file model.
    /// </summary>
    class FileModel
    {
        #region ctor

        /// <summary>
        /// Creates a new file model.
        /// </summary>
        /// <param name="file">The basic file information.</param>
        public FileModel(FileInfo file)
        {
            Info = file;
        }

        /// <summary>
        /// Creates a new file model.
        /// </summary>
        /// <param name="startFile">The path to the file.</param>
        public FileModel(string startFile) : this(new FileInfo(startFile))
        {
        }

        /// <summary>
        /// Creates a new file model.
        /// </summary>
        /// <param name="directory">The basic directory information.</param>
        public FileModel(DirectoryInfo directory) : this(new FileInfo(directory.FullName))
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the name of the file or directory
        /// </summary>
        public string Name { get { return Info.Name; } }

        /// <summary>
        /// Gets the path of the file or directory.
        /// </summary>
        public string FullName { get { return Info.FullName; } }

        /// <summary>
        /// Gets the information about the file or directory.
        /// </summary>
        public FileInfo Info { get; protected set; }

        /// <summary>
        /// Gets the associated icon of the file or directory.
        /// </summary>
        public object Icon { get { 
            return IsDirectory ? Icons.FolderIcon : Icons.FileIcon; }
        }

        /// <summary>
        /// Gets the status - is the file a directory?
        /// </summary>
        public bool IsDirectory { get { 
            return (Info.Attributes & FileAttributes.Directory) == FileAttributes.Directory && Directory.Exists(Info.FullName); } 
        }

        /// <summary>
        /// Gets the status - is the file valid, i.e. does it exist?
        /// </summary>
        public bool IsValid { get { return Info.Exists; } }

        /// <summary>
        /// Gets the associated folder of the file.
        /// </summary>
        public FolderModel Folder { get { return new FolderModel(Info.Directory); } }

        #endregion

        #region Equality
        
        public override bool Equals(object obj)
        {
            if (obj is FileModel)
            {
                var target = (FileModel)obj;
                return target.FullName.Equals(FullName, StringComparison.CurrentCultureIgnoreCase);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return FullName.GetHashCode();
        }

        #endregion
    }
}
