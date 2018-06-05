using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class IceTrigger : MonoBehaviour {

	
	void Start ()
	{

	    Tweener tweener = this.transform.DOLocalMove(new Vector3(4.25f, 0.634f, 5.728f), 3f);
	    tweener.Pause();

	}

    void IceTriggerDown()
    {
        this.transform.DOPlayForward();
    }


}
