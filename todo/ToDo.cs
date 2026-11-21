using UTI;
namespace ToDoItems{
    
public class ToDo
{
    public string Item{get;set;}  = "none";
    public bool IsDone{get;private set;} = false;

    public ToDo(string item)
        {
            this.Item = item;
        }
    
    public void  ToggleDone()
        {
            IsDone = !IsDone;
        }
    public virtual string Describe()
        {
               string statMark = "";
                    if (IsDone)
                    {
                        statMark = "x";
                    }
            string Desc =($"[{statMark}] {Item}");
            return Desc;
        }
}}

namespace ToDoItems{
    public interface ITodoList
    {
        int Count { get; }
        void AddItem(string title, bool isUrgent);
        bool Remove(int number);       // 1-based, false если нет такого
        bool ToggleDone(int number);   // 1-based, false если нет такого
        ToDo GetAt(int index);         // 0-based, для вывода
    }

    public class TodoList : ITodoList
    {
        private List<ToDo> items = new();
          public int Count => items.Count; 
        
        public void AddItem(string title, bool isUrgent)
        {
             if(!isUrgent){
        items.Add(new ToDo(title));
        Console.WriteLine("Добавлено");
        }
            else
            {
                if(isUrgent)
                {
                    items.Add(new UrgentTodoItem(title));
                    Console.WriteLine("Добавлено");
                
                }

                else
                {
                    Console.WriteLine("Некоректный ввод!!!!");
                }
            }
        }
        
        
         public bool Remove(int number)
        {
            if(number <=(items.Count) && number>0){
                items.RemoveAt(number-1);
                return true;
                }
                
                else
                {
                    Console.WriteLine("Вы вышли за пределы списка");
                    return false;
                }
        }       // 1-based, false если нет такого
       public bool ToggleDone(int number)
         {
            if(number <=(items.Count) && number>0){
                items[number-1].ToggleDone();
                return true;}
                else
                {
                    return false;
                    
                }
            
        }    // 1-based, false если нет такого
       public ToDo GetAt(int index)
         {
                if (index >= 0 && index < items.Count)
            {
                return items[index];
            }
            return null; 
        }     
    }
}