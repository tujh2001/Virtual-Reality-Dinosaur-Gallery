using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavigation2 : MonoBehaviour {

    private Animation enemyAnim1;
    private NavMeshAgent navAgent1;

    private float patrol_Timer = 10f;
    private float timer_Count;

    public GameObject pos;

    void Awake() {
        enemyAnim1 = GetComponent<Animation>();
        navAgent1 = GetComponent<NavMeshAgent>();
    }

    // Start is called before the first frame update
    void Start()
    {
        timer_Count = patrol_Timer;
        navAgent1.updatePosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
