using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lastTriggerController : MonoBehaviour {



    void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player")
        {
            GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().distanceH = 30f;

            GameObject.Find("Main Camera").transform.GetComponent<FollowPlayer>().distanceV = 15f;

            collider.transform.parent = GameObject.Find("Stage2").transform;

            GameObject.Find("Stage2").transform.SendMessage("DoBack");

            Destroy(GameObject.Find("Spuse"));

            Invoke("GameOver", 15f);
        }
    }


    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

}
