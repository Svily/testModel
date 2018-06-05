using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TotemsController : MonoBehaviour {

	
	void Start () {

        //初始化动画
	    Tweener tweener = this.transform.DOMove(new Vector3(11, 18, -14), 4f);
	    tweener.SetAutoKill(false);
	    tweener.Pause();
    }


    //图腾升起
    void TotemsUp()
    {
        transform.DOPlayForward();
    }

    //图腾下降
    void TotemsDown()
    {
        transform.DOPlayBackwards();
    }
}
