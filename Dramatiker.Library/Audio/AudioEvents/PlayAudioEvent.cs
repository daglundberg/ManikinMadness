﻿namespace Dramatiker.Library;

public class PlayAudioEvent : IAudioEvent, ISerializable
{
	public PlayAudioEvent(AudioItem audioItemToPlay, int fadeLength)
	{
		AudioItem = audioItemToPlay;
		FadeLength = fadeLength;
	}

	public PlayAudioEvent()
	{
	}

	public int FadeLength { get; set; }

	public AudioItem AudioItem { get; set; }

	public void ApplyAudio(AudioPlayer audioPlayer)
	{
		audioPlayer.PlayAudioItem(AudioItem, FadeLength);
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
		return $"Play Audio Event {AudioItem} over {decimal.Round(FadeLength / (decimal) 1000, 3)} seconds";
	}
}