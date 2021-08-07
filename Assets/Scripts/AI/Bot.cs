using UnityEngine;
using UnityEngine.AI;


public class BotMovement : MonoBehaviour
{
    private NavMeshAgent meshAgent;
    [SerializeField]
    private Transform target;
    private void Awake()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        meshAgent.SetDestination(target.position);
    }
}
