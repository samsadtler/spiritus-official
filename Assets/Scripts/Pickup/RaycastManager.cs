using UnityEngine;
using System.Collections;

public class RaycastManager : MonoBehaviour {

	private static RaycastManager mInstance;
	public static RaycastManager Instance
	{
		get
		{
			if (mInstance != null) return mInstance;
			else
			{
				GameObject target = GameObject.Find("RaycastManager");
				if (target)
				{
					mInstance = target.GetComponent<RaycastManager>();
					return mInstance;
				}
				else return null;
			}
		}
	}

	private Vector3 heldItemPrevPos;
	private Quaternion heldItemPrevRot;
	[HideInInspector] public GameObject heldItem = null;

	void Awake(){
		mInstance = this;
	}

	//can also be used to unhold an object already held, returns if hold succeeds or not
	public void Hold(GameObject target, Transform holdAnchor, AudioClip onPickupSfx=null){
		if(heldItem != null){
			Debug.Log ("something is in hand");
			//if user clicks on held item
			if(target.Equals(heldItem)){
				heldItem.transform.SetParent(null);
				heldItem.transform.position = heldItemPrevPos;
				heldItem.transform.rotation = heldItemPrevRot;
				heldItem = null;
			}
		}
		else{
			Debug.Log("Holding " + holdAnchor.name);
			heldItem = target;
			heldItemPrevPos = heldItem.transform.position;
			heldItemPrevRot = heldItem.transform.rotation;
			heldItem.transform.SetParent(holdAnchor);
			heldItem.transform.localPosition = Vector3.zero;
			heldItem.transform.localRotation = Quaternion.identity;
			if(onPickupSfx != null) AudioManager.Instance.PlayNearSfx(onPickupSfx);
		}
	}

	public bool isHolding(GameObject target){
		return (heldItem != null) && target.Equals(heldItem);
	}

	public void PlaySound(AudioClip clip){
		Debug.Log("Playing clip");
	}




}
