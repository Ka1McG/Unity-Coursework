using SQLite4Unity3d;

public class PlayerDatabase  {

	[PrimaryKey]
	public string Email { get; set; }
	public string Password { get; set; }
    public string Username { get; set; }
	public float PlayTime { get; set; }
    public float AverageRank { get; set; }

	public override string ToString ()
	{
		return string.Format ("[PlayerDatabase: Username={0}, Password={1}, Email={2}, PlayTime={3}, AverageRank={3}]", Username, Password, Email, PlayTime, AverageRank);
	}
}
