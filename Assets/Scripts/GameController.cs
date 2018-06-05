using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    private bool isShow = false;

    void Start()
    {
        Tweener tweener = GameObject.Find("Tip").transform.DOLocalMove(new Vector3(0,0,0), 1f);
        tweener.SetAutoKill(false);
        tweener.Pause();
    }


    public void StartGame()
    {
        SceneManager.LoadScene("game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ShowTips()
    {

        if (!isShow)
        {
            GameObject.Find("Tip").transform.DOPlayForward();
            isShow = true;
        }
        else
        {
            GameObject.Find("Tip").transform.DOPlayBackwards();
            isShow = false;
        }

    }
}
