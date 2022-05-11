﻿namespace Dramatiker.Library;

public class StopAudioEvent : IAudioEvent
{
	public StopAudioEvent(AudioItem audioItemToStop, int fadeLength)
	{
		AudioItem = audioItemToStop;
		FadeLength = fadeLength;
	}

	public StopAudioEvent()
	{
	}

	public int FadeLength { get; set; }

	public AudioItem AudioItem { get; set; }

	public void ApplyAudio(AudioPlayer audioPlayer)
	{
		audioPlayer.StopAudioItem(AudioItem, FadeLength);
	}

	public void Deserialize(string[] data, Set set)
	{
		AudioItem = set.AudioItems.Find(x => x.FileName == data[1]);
		FadeLength = int.Parse(data[2]);
	}

	public string Serialize()
	{
		return Serializer.Serialize(this,
			AudioItem.FileName,
			FadeLength);
	}

	public override string ToString()
	{
		return $"Stop Audio Event {AudioItem} over {decimal.Round(FadeLength / (decimal) 1000, 3)} seconds";
	}
}