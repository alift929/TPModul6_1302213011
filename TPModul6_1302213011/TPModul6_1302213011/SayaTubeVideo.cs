using System;

public class SayaTubeVideo
{
	private int id;
	private string title;
	private int playCount;

	public SayaTubeVideo(string title)
	{
		this.title = title;
		var random = new Random();
		this.id = random.Next(10000,99999);
		this.playCount = 0;
	}

	public void IncreasePlayCount(int playCount)
	{
		this.playCount += playCount;
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine("Id: {0:d}\nTitle: {1:s}\nPlayCount: {2:d}",id,title,playCount);
	}
}
