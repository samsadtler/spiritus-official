using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class RaycastEventObject : MonoBehaviour {

	public Transform holdAnchor = null;
	public AudioClip onPickupSfx = null;
	[SerializeField]private AudioSource audioPlayer; //this is for playing audio on raycast
	public UnityEvent onPickUpEvents;


	//can also be used to unhold an object already held
	public void Hold(){
		bool wasHolding = (RaycastManager.Instance.heldItem != null);
		RaycastManager.Instance.Hold(gameObject,holdAnchor, onPickupSfx);	
		if(!wasHolding && (RaycastManager.Instance.heldItem.Equals(gameObject))) onPickUpEvents.Invoke();
	}

	public void PlayAudio(){
		if(audioPlayer == null) return;
		if(audioPlayer.clip == null) return;
		if(!audioPlayer.isPlaying) audioPlayer.Play();
	}


}
