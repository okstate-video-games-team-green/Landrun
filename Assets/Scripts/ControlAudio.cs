using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System;

public class ControlAudio : MonoBehaviour {

	public AudioMixer mixer;
	//http://stackoverflow.com/questions/6709072/c-getter-setter
	private float _effectsVolLevel = .5f;
	private float _musicVolLevel = .5f;

	//must be between 0 and 1 inclusive
	public float effectsVolumeLevel {
		get {
			return _effectsVolLevel;
		}
		set{
			if (value < 0.0 || value > 1.0) {
				throw new ArgumentOutOfRangeException("Volume must be between 0 and 1");
			}
			mixer.SetFloat ("effectsVolume", LinearToDecibel(value)); //variable has to be exposed in unity editor - https://unity3d.com/learn/tutorials/modules/beginner/5-pre-order-beta/exposed-audiomixer-parameters
			_effectsVolLevel = value;
		}
	}

	//must be between 0 and 1 inclusive
	public float musicVolumeLevel {
		get {
			return _musicVolLevel;
		}
		set{
			if (value < 0.0 || value > 1.0) {
				throw new ArgumentOutOfRangeException ("Volume must be between 0 and 1");
			}
			mixer.SetFloat ("musicVolume", LinearToDecibel(value));
			_musicVolLevel = value;
		}
	}

	// Use this for initialization
	void Start () {
		mixer.SetFloat ("effectsVolume", _effectsVolLevel); //variable has to be exposed in unity editor - https://unity3d.com/learn/tutorials/modules/beginner/5-pre-order-beta/exposed-audiomixer-parameters
		mixer.SetFloat("musicVolume", _musicVolLevel);
	}

	//answers.unity3d.com/q/283192
	private static float LinearToDecibel(float lin) {
		if (lin == 0) {
			return -144;
		} else {
			return 20.0f * Mathf.Log10 (lin);
		}
	}

	private static float DecibelToLinear(float dec) {
		return Mathf.Pow (10.0f, dec / 20.0f);
	}

}