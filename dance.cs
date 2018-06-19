using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class dance : MonoBehaviour {

	DefaultTrackableEventHandler dte;	
	public GameObject MIKU;
	GameObject miku;
	// Use this for initialization
	void Awake(){
		dte = GetComponent<DefaultTrackableEventHandler> ();
		dte.OnTrackingFoundEvent += Dte_OnTrackingFoundEvent;
		dte.OnTrackingLostEvent += Dte_OnTrackingLostEvent;
	}

	void Dte_OnTrackingLostEvent ()
	{
		List<Transform> lst = new List<Transform>();
		foreach(Transform child in this.transform){
			lst.Add (child);
		}
		for (int i = 0; i < lst.Count; i++) {
			Destroy (lst [i].gameObject);
		}
	}

	void Dte_OnTrackingFoundEvent ()
	{
		miku = Instantiate (MIKU, this.transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
