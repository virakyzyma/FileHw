using System.Text;
namespace FileHw
{
    internal class Program
    {
        static void Main()
        {
            string fileName = "File.txt";
            using (FileStream fs = File.Create(fileName))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(fileName);
                fs.Write(info, 0, info.Length);
            }
            using (StreamReader st = File.OpenText(fileName))
            {
                string str = "";
                while ((str = st.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
