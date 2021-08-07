using UnityEngine;
using UnityEngine.AI;


public class BotMovement : MonoBehaviour
{
    private NavMeshAgent meshAgent;
    private void Awake()
    {
        meshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        meshAgent.SetDestination(new Vector3(-3, 1.5f, 0));
    }
}
