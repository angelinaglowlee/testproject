namespace ConsoleApp4;

public class Trash
{
    private IList<object> _object = new List<object>();
    
    public void AddObjectToTrash(object item)
    {
        _object.Add(item);
    }

    public void ClearTrash()
    {
        _object = new List<object>();
    }
}