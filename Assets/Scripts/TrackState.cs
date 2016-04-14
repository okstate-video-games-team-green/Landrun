using UnityEngine;
using System.Collections;
using System;

public class TrackState : MonoBehaviour {
	private bool _inProgress = false;
	private float _lastRaceStart = 0;

	public bool inProgress {
		get {
			return _inProgress;
		}
	}

	public float lastRaceStart{
		get{
			if (!inProgress) {
				throw new InvalidOperationException ("No race is in progress so start time does not make sense.");
			}
			return _lastRaceStart;
		}
	}

	public void StartRace() {
		_lastRaceStart = Time.time;
		_inProgress = true;
	}
}
