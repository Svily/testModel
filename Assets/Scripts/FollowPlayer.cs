using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    //获取人物人物transform组件
    public Transform player;

    //摄像机水平距离
    public float distanceH;

    //摄像机垂直距离
    public float distanceV;

    //摄像机旋转速度
    public float smoothSpeed;

	
	void Start ()
	{

       InitCamera();

    }
	

    void LateUpdate()
    {
        CameraFollow();
    }

    /// <summary>
    /// 初始化摄像机
    /// </summary>
    void InitCamera()
    {

        //初始化参数
        distanceH = 10f;
        distanceV = 5f;
        smoothSpeed = 0.8f;

        //获取player transform组件
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    /// <summary>
    /// 摄像机跟随
    /// </summary>
    void CameraFollow()
    {
        //设置摄像机位置
        Vector3 nextPostion = player.forward * -1 * distanceH + player.up * distanceV + player.position;

        //移动摄像机
        this.transform.position = Vector3.Lerp(this.transform.position, nextPostion, smoothSpeed * Time.deltaTime);

        //摄像机朝向人物
        this.transform.LookAt(player);
    }
}
