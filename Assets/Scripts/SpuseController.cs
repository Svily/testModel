using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SpuseController : MonoBehaviour {



    void DoPlay()
    {
        this.transform.DOPlayForward();
    }

    void DoBack()
    {
        this.transform.DOPlayBackwards();
    }


}
