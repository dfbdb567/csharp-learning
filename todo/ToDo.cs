
using System.Security.Cryptography.X509Certificates;

namespace ToDoItems{
public class ToDo
{
    public string Item{get;set;}  = "none";
    public bool IsDone{get;private set;} = false;

    public ToDo(string item)
        {
            this.Item = item;
        }

    public void Markdown()
        {
            IsDone = !IsDone;
        }
    public string Describe()
        {
               string statMark = "";
                    if (IsDone)
                    {
                        statMark = "x";
                    }
            string Desc =($"[{statMark}] {Item}");
            return Desc;
        }
}
}