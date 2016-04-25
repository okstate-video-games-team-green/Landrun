using UnityEngine;
using System.Collections;
using System;

public class TrackState : MonoBehaviour {
	public bool _inProgress = false;
	private float lastRaceStart = 0;
	private float historicalTime = 0;//time accumulated b/f latest unpause

	public SplineInterpolator si;//trying to minimize amount we have to modify lib code

	public bool inProgress {
		get {
			return _inProgress;
		}
	}

	public float accumulatedTime {
		get {
			return Time.time - lastRaceStart + historicalTime;
		}
	}

	public void StartRace() {
		lastRaceStart = Time.time;
		_inProgress = true;
	}

	public void PauseRace() {
		if (!_inProgress) {
			return;
		}
		si.Pause ();
		_inProgress = false;
		historicalTime = accumulatedTime;
	}

	public void UnpauseRace() {
		if (lastRaceStart == 0) { //race is not going on so return
			return;
		}
		si.UnPause ();
		lastRaceStart = Time.time;
		_inProgress = true;
	}
}
