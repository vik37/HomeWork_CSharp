using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddminFace.Logger
{
    public class AdminExceptionLogger
    {
        private string PathFile { get; set; } = @"C:\Users\vikto\source\repos\AddMinExceptHomeW\ExceptionAddLog.txt";
        public void LogException(Exception ex)
        {
            StreamWriter sw = new StreamWriter(PathFile);
            sw.WriteLine($"{ex.GetType().Name}  {ex.Message}  {ex.StackTrace}");
            sw.Close();
        }
    }
}
