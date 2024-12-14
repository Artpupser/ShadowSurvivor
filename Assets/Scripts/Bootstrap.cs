using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace ShadowSurvivor {
	internal sealed class Bootstrap : MonoBehaviour {
		private void Awake() {
			Application.targetFrameRate = 60;
			QualitySettings.vSyncCount = 1;
		}
		private void Start() {
			Debug.Log("Application started!");
			SceneManager.LoadScene("MainMenu");
		}
	}
}
