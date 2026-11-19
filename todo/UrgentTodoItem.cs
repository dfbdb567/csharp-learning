using ToDoItems;

namespace UTI{
public class UrgentTodoItem : ToDo
{
    public UrgentTodoItem(string item) : base(item)
    {
    }
    public override string Describe()
    {
        return "[!!!] "+base.Describe();
    }
}
}