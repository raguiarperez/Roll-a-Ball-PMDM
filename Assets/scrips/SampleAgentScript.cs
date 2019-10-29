
using UnityEngine;
using UnityEngine.AI;

public class SampleAgentScript : MonoBehaviour {

public Transform target;
private NavMeshAgent agent;

public Animator animator;

public float proximidad;



	void Start () {
		agent = GetComponent<NavMeshAgent>();
		agent.autoBraking = false;
		animator = target.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(target.position);

		if (!agent.pathPending && agent.remainingDistance < proximidad){
            Debug.Log("Peligro");
            // cambiamos a true la variable del animator
            animator.SetBool("EstarEnPeligro", true);
		}
        else{
            Debug.Log("Tranqui");
            // cambiamos a false la variable del animator
            animator.SetBool("EstarEnPeligro", false);
        }
	}
}
