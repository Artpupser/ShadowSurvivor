using UnityEngine;

namespace ShadowSurvivor.Data {
	[System.Serializable]
	public sealed class AppConfigData {
		[Header("Audio")]
		[Range(0, 1f)]
		[SerializeField]
		private float _musicVolume = 0f;
		[Range(0, 1f)]
		[SerializeField]
		private float _soundVolume = 0f;
		[Range(0, 1f)]
		[SerializeField]
		private float _masterVolume = 0f;
		[Header("Graphics")]
		[Range(0, 3)]
		[SerializeField]
		private byte _resolution = 0;
		[Range(0, 3)]
		[SerializeField]
		private byte _quality = 0;

		public AppConfigData(AppConfigData content) {
			_masterVolume = content.MasterVolume;
			_soundVolume = content.SoundVolume;
			_musicVolume = content.MusicVolume;
			_resolution = (byte)content.Resolution;
			_quality = (byte)content.Quality;
		}
		public enum QualityType : byte {
			Low = 0,
			Middle = 1,
			High = 2,
			Ultra = 3,
		}
		public enum ResolutionType : byte {
			Hd = 0,
			FullHd = 1,
			_2k = 2,
			_4k = 3,
		}
		#region Properties
		public float MusicVolume => _musicVolume;
		public float SoundVolume => _soundVolume;
		public float MasterVolume => _masterVolume;
		public ResolutionType Resolution => (ResolutionType)_resolution;
		public QualityType Quality => (QualityType)_quality;
		#endregion
	}
}
