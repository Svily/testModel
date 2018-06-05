using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class StageController : MonoBehaviour {

    public AudioClip S2AudioClip;

    void Start ()
	{

	    Tweener tweener = this.transform.DOMove(new Vector3(-3036.6f, 46f, -2873.9f), 8f);

	    tweener.SetAutoKill(false);
	    tweener.Pause();
	}


    void DoPlay()
    {

        AudioSource.PlayClipAtPoint(S2AudioClip, GameObject.Find("Player").transform.position, 1.0f);

        this.transform.DOPlayForward();
    }


    void DoBack()
    {

        this.transform.DOPlayBackwards();

    }
}
