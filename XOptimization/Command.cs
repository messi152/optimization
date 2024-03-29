﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XOptimization
{
    class Command
    {
        public static string RenameFile(String workingDir, String target)
        {
            String source = Path.GetFileName(workingDir);
            string ext = Path.GetExtension(source).ToUpper();
            int ran = 0;
            target = target.Trim();
            string replace = target;
            while (File.Exists(workingDir.Split(new[] { "\\" + source }, StringSplitOptions.None)[0] + "\\" + replace + ext))
            {
                ran ++;
                replace += ran;
            }
            if (ran>0)
                target = target +"_"+ ran;
            var result = Helper.RunCMD("Rename " + " \""+ workingDir + "\"" + " \"" + target+ ext+"\"");
            return workingDir.Split(new[] { "\\" + source }, StringSplitOptions.None)[0] + "\\" + target + ext;
        }
        public static string RenameFolder(String workingDir, String target)
        {
            String source = Path.GetFileName(workingDir);
            int ran = 0;
            target = target.Trim();
            string replace = target;
            while (Directory.Exists(workingDir.Split(new[] { "\\" + source }, StringSplitOptions.None)[0] + "\\" + replace))
            {
                ran++;
                replace += ran;
            }
            if (ran > 0)
                target = target + "_" + ran;
            var result = Helper.RunCMD("Rename " + "\"" + workingDir + "\"" + " " + "\"" + target + "\"");
            return workingDir.Split(new[] { "\\" + source }, StringSplitOptions.None)[0] + "\\" + target;
        }
        public static void MoveFolder(String source, String target)
        {
            if (Directory.Exists(source) && Directory.Exists(target))
            {
                Helper.RunCMD("Move " + "\""+source + "\""+ " " + "\""+target+ "\"");
            }
        }
        public static void CopyFolder(String source, String target)
        {
            if (Directory.Exists(source))
            {
                String folderName = new DirectoryInfo(source).Name;
                Helper.RunCMD("XCopy /E /I " + "\""+source+ "\"" + " " + "\""+target+ "\"");
                //Helper.RunCMD("XCopy /E /I " + "\"" + source + "\"" + " " + "\"" + target + "\"" + "\\" + folderName);
            }
        }
        public static void CopyFile(String source, String target)
        {
            if (File.Exists(source))
            {
                String fileName = Path.GetFileName(source);
                String targetFileName = target;
                if (target.IndexOf("\\")>0) targetFileName = Path.GetFileName(target);
                string ext = Path.GetExtension(source).ToUpper();
                if (targetFileName.Equals(fileName) || !target.ToUpper().Contains(ext))
                {
                    int ran = 0;
                    target = target.Trim();
                    string replace = fileName.ToUpper().Replace(ext,"");
                    string targetDir = target.Split(new[] { "\\" + targetFileName }, StringSplitOptions.None)[0];
                    if (!target.ToUpper().Contains(ext))
                    {
                        targetDir = target;
                    }
                    if (File.Exists(targetDir + "\\" + replace + ext))
                    {
                        do
                        {
                            ran++;
                        }
                        while (File.Exists(targetDir + "\\" + replace + " " + ran + ext));
                    }

                    if (ran > 0)
                        target = target+"\\"+fileName.ToUpper().Replace(ext, "") + " " + ran +ext;
                }
                Helper.RunCMD("Copy " + "\"" + source + "\"" + " " + "\"" + target + "\"");
            }
        }
        public static void DeleteFolder(String source)
        {
            if (Directory.Exists(source))
            {
                Helper.RunCMD("rmdir /s /q " + "\""+source+ "\"");
            }
        }
        public static void OpenFile(String path)
        {
            if (File.Exists(path))
            {
                String folderName = new DirectoryInfo(path).Name;
                Helper.RunCMD(path);
            }
        }
    }
}
