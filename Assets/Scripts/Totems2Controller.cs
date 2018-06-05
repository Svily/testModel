using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Totems2Controller : MonoBehaviour {

	
	void Start ()
	{

	    Tweener tweener = this.transform.DOMove(new Vector3(0, 9, -1), 10f);
	    tweener.Pause();

	}

    void Totems2Down()
    {
        this.transform.DOPlayForward();
    }
}
