using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class S2FirstTrigger : MonoBehaviour {

	
	void Start ()
	{
	    Tweener tweener = this.transform.DOMove(new Vector3(-3074.1f, 52.66f, -2849.5f), 2f);

	    tweener.Pause();
	}
	
	
	void DoAnimation ()
	{

	    this.transform.DOPlayForward();

	}
}
