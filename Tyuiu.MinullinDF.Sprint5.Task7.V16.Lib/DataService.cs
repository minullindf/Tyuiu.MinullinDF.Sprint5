using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.MinullinDF.Sprint5.Task7.V16.Lib
{
    public class DataService : ISprint5Task7V16
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V16.txt");
            //string pathSaveFile = $@"C:\DataSprint5\OutPutDataFileTask7V16.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);

            if (fileInfo.Exists) { File.Delete(pathSaveFile); }

            string w = "";
            string[] words = [];
            string[] newLines = [];
            string[] newWords = [];
            string[] lines = File.ReadAllText(path).Split("\n");
            foreach (string line in lines)
            {
                words = line.Split(" ");
                foreach (string word in words)
                {
                    w = word;
                    if (word.Length == 2) { w = "XY"; }
                    newWords.Append(word);
                }
                newLines.Append(String.Join(" ", newWords));
                newWords = [];
            }
            string allText = String.Join("\n", newLines);
            File.WriteAllText(pathSaveFile, allText);
            return pathSaveFile;
         }
    }
}
