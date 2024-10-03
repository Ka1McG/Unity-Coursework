using SQLite4Unity3d;
public class Ranks
{
	public string Email { get; set; }
	public string Level1 { get; set; }
    public string Level2 { get; set; }
	public float Level3 { get; set; }

	public override string ToString ()
	{
		return string.Format ("[PlayerDatabase: Email={0}, Level1={1}, Level2={2}, Level3={3}]", Email, Level1, Level2, Level3);
	}
}
