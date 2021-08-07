using UnityEngine;
using UnityEngine.AI;


public class Bot : MonoBehaviour
{
    private enum state 
    {
        Idle,
        Movement
    }
    private NavMeshAgent meshAgent;
    [SerializeField]
    private Transform target;
    private state botState = state.Movement;
    private void Awake()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        switch (botState) 
        {
            case state.Idle:
                
            break;

            case state.Movement:
                meshAgent.SetDestination(target.position);
                if (transform.position.magnitude < 1f) 
                {
                    meshAgent.SetDestination(transform.position);
                    botState = state.Idle;
                }
            break;
        }
    }
}
