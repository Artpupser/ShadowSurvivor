using UnityEngine;

namespace ShadowSurvivor.Data {
	[CreateAssetMenu(fileName = "AppConfigDataAsset", menuName = "Gameplay/Data/AppConfigDataAsset")]
	public sealed class AppConfigDataAsset : ScriptableObject {
		[SerializeField]
		private AppConfigData _target = null!;
		public AppConfigData Target => _target;
		public AppConfigData Clone() => new(_target);
	}
}
