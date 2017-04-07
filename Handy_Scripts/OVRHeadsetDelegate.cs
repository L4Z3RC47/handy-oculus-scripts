using UnityEngine;

// Uncomment if you want to switch scenes based on the headset status.
// using UnityEngine.SceneManagement;

public class OVRHeadsetDelegate : MonoBehaviour {


	void OnEnable () {

		OVRManager.HMDMounted += HandleHMDMounted;
		OVRManager.HMDUnmounted += HandleHMDUnmounted;

	}

	void OnDisable () {

		OVRManager.HMDMounted -= HandleHMDMounted;
		OVRManager.HMDUnmounted -= HandleHMDUnmounted;

	}

	void HandleHMDMounted() {

		Debug.Log("HMD Mounted");

    // Trigger something here

	}

	void HandleHMDUnmounted() {

		Debug.Log("HMD UnMounted");

    // Trigger something here

	}
}
