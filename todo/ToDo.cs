namespace ToDoItems
{
    public class ToDo
    {
        public string Item { get; set; } = "none";
        public bool IsDone { get; private set; } = false;

        public ToDo(string item)
        {
            Item = item;
        }

        public void ToggleDone()
        {
            IsDone = !IsDone;
        }

        public virtual string Describe()
        {
            string statMark = IsDone ? "x" : "";
            return $"[{statMark}] {Item}";
        }
    }
}
