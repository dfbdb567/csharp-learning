using UTI;

namespace ToDoItems
{
    public class TodoList : ITodoList
    {
        private readonly List<ToDo> items = new();

        public int Count => items.Count;

        public void AddItem(string title, bool isUrgent)
        {
            if (isUrgent)
            {
                items.Add(new UrgentTodoItem(title));
            }
            else
            {
                items.Add(new ToDo(title));
            }
        }

        public bool Remove(int number)
        {
            if (number < 1 || number > items.Count)
            {
                return false;
            }

            items.RemoveAt(number - 1);
            return true;
        }

        public bool ToggleDone(int number)
        {
            if (number < 1 || number > items.Count)
            {
                return false;
            }

            items[number - 1].ToggleDone();
            return true;
        }

        public ToDo GetAt(int index)
        {
            return items[index];
        }
    }
}
