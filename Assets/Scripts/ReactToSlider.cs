using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReactToSlider : MonoBehaviour {

	public Slider musicSlider;
	public Slider effectsSlider;
	public ControlAudio controlAudio;


	public void Start() {
		musicSlider.onValueChanged.AddListener(musicValueChanged);
		effectsSlider.onValueChanged.AddListener (effectsValueChanged);
		musicSlider.normalizedValue = controlAudio.musicVolumeLevel;
		effectsSlider.normalizedValue = controlAudio.effectsVolumeLevel;
	}

	public void Update () {
		//print (musicSlider.normalizedValue);
	}

	public void musicValueChanged(float val) {
		controlAudio.musicVolumeLevel = musicSlider.normalizedValue;
	}

	public void effectsValueChanged(float v) {
		controlAudio.effectsVolumeLevel = effectsSlider.normalizedValue;
	}
}
