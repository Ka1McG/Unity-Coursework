using SQLite4Unity3d;

public class PlayerDatabase  {

	[PrimaryKey]
	public int PlayerID { get; set; }
	public string Email { get; set; }
	public string Password { get; set; }
    public string Username { get; set; }
	public float PlayTime { get; set; }

	public override string ToString ()
	{
		return string.Format ("[PlayerDatabase: PlayerID={0}, Email={1}, Password={2}, Username={2}, PlayTime={3}", PlayerID, Email, Password, Username, PlayTime);
	}
}
