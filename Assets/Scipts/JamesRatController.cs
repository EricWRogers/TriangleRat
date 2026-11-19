using UnityEngine;
using UnityEngine.AI;

public class JamesRatController : MonoBehaviour {

    public GameObject target;

    public NavMeshAgent agent;

    // Update is called once per frame
    void Update () 
    {
            agent.SetDestination(target.transform.position);



    }
}