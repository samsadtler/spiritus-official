using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	private static AudioManager mInstance;
	public static AudioManager Instance
	{
		get
		{
			if (mInstance != null) return mInstance;
			else
			{
				GameObject target = GameObject.Find("AudioManager");
				if (target)
				{
					mInstance = target.GetComponent<AudioManager>();
					return mInstance;
				}
				else return null;
			}
		}
	}

	[SerializeField] private AudioSource mainCamSfxPlayer;

	void Awake(){
		mInstance = this;
	}

	public void PlayNearSfx(AudioClip clip){
		mainCamSfxPlayer.PlayOneShot(clip);
	}
}
