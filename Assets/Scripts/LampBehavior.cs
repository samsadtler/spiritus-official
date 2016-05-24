using UnityEngine;
using System.Collections;

public class LampBehavior : MonoBehaviour {

	public GameObject light;
	void Awake(){
		light.SetActive(false);
	}

	public void ToggleLight(){
		light.SetActive(!light.activeSelf);
	}

}
