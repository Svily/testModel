using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    //定义人物控制器
    public CharacterController cc;

    //定义人物是否可以移动
    public bool CanMove = true;

    //定义当前人物运动状态
    public PlayerState currentPlayerState = PlayerState.IDLE;

    //鼠标点击坐标
    private Vector3 mouserPoint;

    //鼠标点击时间
    private float time;

    //定义动画状态控制器
    private Animator animator;

    //设置重力系数
    public float gravity = 80f;

    //设置人物行走速度
    public float walkSpeed =0.1f;

    //设置人物奔跑速度
    public float runSpeed =0.2f;

    //原点向量
    private Vector3 moveDriction = Vector3.zero;

    private NavMeshAgent nav;
   
    //定义游戏人物状态
    public enum PlayerState
    {
        IDLE = 0,
        WALK = 1,
        RUN =2

    }

    /// <summary>
    /// 改变游戏人物动画状态
    /// </summary>
    /// <param name="state"></param>
    private void setPlayerState(PlayerState state)
    {
        //切换当前运动状态
        this.currentPlayerState = state;

        //切换相应动画
        switch (state)
        {
            case PlayerState.IDLE:
                mouserPoint = transform.position;
                animator.SetInteger("PlayerState",0);
                break;
            case PlayerState.WALK:
                animator.SetInteger("PlayerState", 1);
                break;
            case PlayerState.RUN:
                animator.SetInteger("PlayerState", 2);
                break;
        }

    }

    /// <summary>
    /// 设置人物可以移动
    /// </summary>
    void PlayerCanMove()
    {
        this.CanMove = true;
    }

    /// <summary>
    /// 设置人物不可移动
    /// </summary>
    void PlayerStopMove()
    {
        this.CanMove = false;
    }


    void Start () {

        //获取所需组件
        getComponts();

	}



    /// <summary>
    /// 获取组件
    /// </summary>
    public void getComponts()
    {
        cc = this.GetComponent<CharacterController>();

        animator = this.GetComponent<Animator>();

        nav = this.GetComponent<NavMeshAgent>();
    }


    void LateUpdate ()
    {

        PlayerIsDead();

        //检测人物是否可以进行移动
        if (CanMove)
        {
            CheckPlayerRun();

            ChangeCurrentState(currentPlayerState);
        }
        else
        {
            setPlayerState(PlayerState.IDLE);
        }


    }

    /// <summary>
    /// 实时监测人物状态变化
    /// </summary>
    /// <param name="currentPlayerState"></param>
    public void ChangeCurrentState(PlayerState currentPlayerState)
    {
        //切换运动状态
        switch (currentPlayerState)
        {
            case PlayerState.IDLE:
                break;
            case PlayerState.WALK:
                PlayerMove(walkSpeed);
                break;
            case PlayerState.RUN:
                PlayerMove(runSpeed);
                break;
        }
    }

    /// <summary>
    /// 检测鼠标点击事件，使人物运动到鼠标点击坐标
    /// </summary>
    public void CheckPlayerRun()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Player"|| hit.transform.tag == "Totems" )
                {
                    return;
                }
                else
                {
                    mouserPoint = hit.point;

                    transform.LookAt(new Vector3(mouserPoint.x, transform.position.y, mouserPoint.z));

                    //双击切换运动状态为奔跑
                    if (Time.realtimeSinceStartup - time <= 0.2f)
                    {
                        setPlayerState(PlayerState.RUN);
                    }
                    else
                    {
                        setPlayerState(PlayerState.WALK);
                    }

                    time = Time.realtimeSinceStartup;
                }
            }
        }
    }

    /// <summary>
    /// 移动人物
    /// </summary>
    /// <param name="stepLength"></param>
    public void PlayerMove(float speed)
    {

        //为人物添加重力
        moveDriction.y -= gravity * Time.deltaTime;
        cc.Move(moveDriction * Time.deltaTime);

        //判定是否到达目标点
        if (Mathf.Abs(Vector3.Distance(mouserPoint, transform.position)) >= 0.5f)
        {
            Vector3 v = Vector3.ClampMagnitude(mouserPoint - transform.position, speed);

            //nav.SetDestination(mouserPoint);
            cc.Move(v);
        }
        else
        {
            setPlayerState(PlayerState.IDLE);
        }

    }



    /// <summary>
    /// 监测触发事件
    /// </summary>
    /// <param name="hit"></param>
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {



    }


    public void PlayerIsDead()
    {

        if (this.transform.position.y <= -2)
        {

            SceneManager.LoadScene("EndGame");

        }

    }
}
