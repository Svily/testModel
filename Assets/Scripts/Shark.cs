using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

/// <summary>
/// 屏幕抖动
/// </summary>
public class Shark : MonoBehaviour {

	
	void Start ()
	{

	    Tweener tweener = this.transform.DOShakePosition(4,new Vector3(1,1,0));
	    tweener.SetAutoKill(false);
	    tweener.Pause();
	}


    void DoShark()
    {
        
        this.transform.DOPlayForward();

    }



}
