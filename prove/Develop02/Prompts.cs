using System;
public class PromptGenerator{
    public string _filename = "prompoptions.txt";
   public List<string> _prompoptions = new List<string>();

   public PromptGenerator()
{

}
public void OptionPrompts()
{
   string[] lines = System.IO.File.ReadAllLines(_filename);

   foreach (string line in lines)
   {
         _prompoptions.Add(line);
   }
}
public string RandomPrompt()
{
   Random rnd = new Random();
   int prompt = rnd.Next(_prompoptions.Count);

   return _prompoptions[prompt];
}
}