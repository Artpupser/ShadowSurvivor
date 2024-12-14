using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

namespace ShadowSurvivor.Camera {
	public class CameraManager : MonoBehaviour {
		[Header("Dependences")]
		[SerializeField]
		private CinemachineVirtualCamera _virtualCamera;
		[HideInInspector]
		private CinemachineBasicMultiChannelPerlin _noise;
		private float _initialIntensity = 0f;
		private void Awake() {
			_virtualCamera = GetComponent<CinemachineVirtualCamera>();
			_noise = _virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
			_initialIntensity = _noise.m_AmplitudeGain;
		}
		public void ShakeCamera(float intensity, float duration) {
			StartCoroutine(ShakeCameraAsync(intensity, duration));
		}
		private IEnumerator ShakeCameraAsync(float intensity, float duration) {
			_noise.m_AmplitudeGain = intensity;
			yield return new WaitForSeconds(duration);
			_noise.m_AmplitudeGain = _initialIntensity;
		}
	}
}
