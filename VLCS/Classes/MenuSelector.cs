namespace VLCS.Classes
{
    internal class MenuSelector
    {
        string title;
        public MenuSelector(string titleName, List<string> options) 
        {
            string pathToFile = $@"../../../titles/{titleName}.txt";
            title = File.ReadAllText(pathToFile);
        }
    }

}