using System.Diagnostics;

namespace StudentWebsite.Helper
{
    public class HelperClass
    {
        
        public void WriteaFile(string name, int cls, int roll)
        {
            var path = @"C:\Users\Rinsh\source\repos\StudentWebsite\Note\A.txt";
             StreamWriter ob = new StreamWriter(path, true);

            ob.WriteLine("\nName      :" + name);
            ob.WriteLine("\nclass     :" + cls);
            ob.WriteLine("\nRollNo    :" + roll);
            
            ob.Close();
            Process.Start("notepad.exe", path);

        }
    }
}
