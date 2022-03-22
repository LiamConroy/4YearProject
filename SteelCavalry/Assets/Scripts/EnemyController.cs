using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent agent;
    public float waitTime = 4f;
    public float timeToRotate = 2f;
    public float driveSpeed = 6f;
    public float viewRad = 15;
    public float FOV = 90;

    public LayerMask playerMask;
    public LayerMask obstacleMask;
    
    public float meshRes = 1f;
    public int edgeIterations = 4;
    public float edgeDistance = 0.5f;
    public Transform[] waypoints;
    int CurrentWaypointIndex;
    Vector3 playerLastPosition = Vector3.zero;
    Vector3 PlayerPosition;
    float WaitTime;
    float TimeToRotate; 
    bool PlayerInRange;
    bool PlayerNear;
    bool isPatrol;
    bool caughtPlayer;

    void Start()
    {
        PlayerPosition = Vector3.zero;
        isPatrol = true;
        caughtPlayer = false;
        PlayerInRange = false;
        WaitTime = waitTime;
        TimeToRotate = timeToRotate;

        CurrentWaypointIndex = 0;
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.isStopped = false;
        navMeshAgent.speed = speedWalk;
        navMeshAgent.SetDestination(waypoints[CurrentWaypointIndex].position);               
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void playerCaught(){
        caughtPlayer = true;
    }

    void Move(float speed){
        navMeshAgent.isStopped = false;
        navMeshAgent.speed = speed;
    }

    void Stop(){
        navMeshAgent.isStopped = true;
        navMeshAgent.speed = 0;
    }

    public void NextPoint(){
        CurrentWaypointIndex = (CurrentWaypointIndex+1) % waypoints.Length;
        navMeshAgent.SetDestination(waypoints[CurrentWaypointIndex].position);
    }

    void LookingPlayer(Vector3 player){
        navMeshAgent.SetDestination(player); 
        if(Vector3.Distance(transform.position, player) <= 0.3){
            if(WaitTime <= 0){
                PlayerNear = false;
                Move(speedWalk);
                navMeshAgent.SetDestination(waypoints[CurrentWaypointIndex].position);
                 WaitTime = waitTime;
                 TimeToRotate = timeToRotate;    
            } 

        else {
            Stop();
            WaitTime -= Time.deltaTime;
        }        
        } 
    }

}
