namespace ToDoItems
{
    public interface ITodoList
    {
        int Count { get; }
        void AddItem(string title, bool isUrgent);
        bool Remove(int number);
        bool ToggleDone(int number);
        ToDo GetAt(int index);
    }
}
