class SLQCommand
{
    public string CommandText { get; set; }
    public void ExecuteNonQuery() { }

    public static implicit operator SLQCommand(string commandText)
    {
        return new SLQCommand { CommandText = commandText };
    }

    public static implicit operator string(SLQCommand command)
    {
        return command.CommandText;
    }

    public static implicit operator SLQCommand(int commandText)
    {
        return new SLQCommand { CommandText = commandText.ToString() };
    }

    public static implicit operator int(SLQCommand command)
    {
        return int.Parse(command.CommandText);
    }

    public static implicit operator SLQCommand(double commandText)
    {
        return new SLQCommand { CommandText = commandText.ToString() };
    }

    public static implicit operator double(SLQCommand command)
    {
        return double.Parse(command.CommandText);
    }

    static void Main() {
        SLQCommand command = "SELECT * FROM Table";
        command.ExecuteNonQuery();
    }

}