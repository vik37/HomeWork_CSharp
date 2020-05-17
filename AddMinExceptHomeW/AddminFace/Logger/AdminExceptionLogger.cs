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
            try
            {
                if (File.Exists(PathFile)) 
                {
                    StreamWriter sw = new StreamWriter(PathFile);
                    sw.WriteLine($"{ex.GetType().Name}  {ex.Message}  {ex.StackTrace}");
                    sw.Close();
                }
                else
                {
                    throw new FileNotFoundException($"{PathFile} is not present",ex);
                }
            }
            catch(Exception except)
            {
                Console.WriteLine($"Inner Exception: {except.InnerException.GetType().Name} {except.InnerException.Message}");
            }
            
        }
    }
}
