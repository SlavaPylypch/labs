﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    public class FileLogger : ILogger
    {
        private readonly FileWriter _fileWriter;

        public FileLogger(FileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void Log(string message)
        {
            _fileWriter.WriteLine("LOG: " + message);
        }

        public void Error(string message)
        {
            _fileWriter.WriteLine("ERROR: " + message);
        }

        public void Warn(string message)
        {
            _fileWriter.WriteLine("WARN: " + message);
        }
    }

}
