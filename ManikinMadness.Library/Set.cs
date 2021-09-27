﻿using System;
using System.Collections.Generic;

namespace ManikinMadness.Library
{
	public class Set
	{
		public string Name { get; set; }
		public List<IEvent> Events { get; set; }
		private int _currentIndex;

		public Set()
		{
			_currentIndex = 0;
			Events = new List<IEvent>();

		}

		public void LoadFromFile(string pathToSetFile)
		{
			_currentIndex = 0;

			Events = new List<IEvent>();

			List<AudioItem> audioItems = new List<AudioItem>();
			audioItems.Add(new AudioItem(1, @"C:\Users\Dag\Desktop\vanilla.mp3", true));
			audioItems.Add(new AudioItem(2, @"C:\Users\Dag\Desktop\hmm.mp3", true));
			audioItems.Add(new AudioItem(3, @"C:\Users\Dag\Desktop\Havet 3.mp3", true));
			audioItems.Add(new AudioItem(4, @"C:\Users\Dag\Desktop\Havet 4.mp3", true));
			audioItems.Add(new AudioItem(5, @"C:\Users\Dag\Desktop\Havet 5.mp3", true));
			audioItems.Add(new AudioItem(6, @"C:\Users\Dag\Desktop\Havet 6.mp3", true));

			foreach (AudioItem item in audioItems)
			{
				Events.Add(new FadeInEvent(item, 4500));
				Events.Add(new FadeOutEvent(item, 25000));
			}
		}

		public void TriggerNext(AudioPlayer audioPlayer)
		{
			Console.WriteLine($"{_currentIndex + 1} / {Events.Count}: {Events[_currentIndex]}");

			Events[_currentIndex].ApplyEvent(audioPlayer);
			_currentIndex++;
		}

		public void GoBack()
		{
			_currentIndex--;
		}

		public void GoForward()
		{
			_currentIndex++;
		}

		public bool IsCompleted
		{
			get
			{
				return _currentIndex >= Events.Count;
			}
		}
	}
}
