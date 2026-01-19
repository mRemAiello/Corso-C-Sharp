using System.Text;

namespace PatternEDatabase.Memento;

public static class MementoPatternDemo
{
    public static void Run()
    {
        var editor = new TextEditor("Nota iniziale");
        var history = new EditorHistory();

        history.Save(editor);
        editor.Append(" + dettagli operativi");
        history.Save(editor);
        editor.Replace("Versione finale condivisa");

        Console.WriteLine("--- Memento ---");
        Console.WriteLine(editor.Describe());

        history.Undo(editor);
        Console.WriteLine("Dopo undo:");
        Console.WriteLine(editor.Describe());

        history.Undo(editor);
        Console.WriteLine("Dopo altro undo:");
        Console.WriteLine(editor.Describe());
    }
}

public sealed class TextEditor
{
    public TextEditor(string content)
    {
        Content = content;
    }

    public string Content { get; private set; }

    public void Append(string text)
    {
        Content += text;
    }

    public void Replace(string text)
    {
        Content = text;
    }

    public EditorMemento CreateMemento()
    {
        return new EditorMemento(Content, DateTime.Now);
    }

    public void Restore(EditorMemento memento)
    {
        Content = memento.Content;
    }

    public string Describe()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"Contenuto: {Content}");
        return builder.ToString();
    }
}

public sealed class EditorMemento
{
    public EditorMemento(string content, DateTime savedAt)
    {
        Content = content;
        SavedAt = savedAt;
    }

    public string Content { get; }

    public DateTime SavedAt { get; }
}

public sealed class EditorHistory
{
    private readonly Stack<EditorMemento> _history = new();

    public void Save(TextEditor editor)
    {
        _history.Push(editor.CreateMemento());
    }

    public void Undo(TextEditor editor)
    {
        if (_history.Count == 0)
        {
            return;
        }

        var memento = _history.Pop();
        editor.Restore(memento);
    }
}
