using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Randomlymove : MonoBehaviour {


    public float timer;

    public int NewTarget;

    public float Speed;

    public NavMeshAgent Nav;

    public Vector3 Target;
    void Start()
    {
        Nav = GameObject.GetComponent<NavMeshAgent>();
    }

    void Update(GameObject gameObject)
    {

        timer = +Time.deltaTime;

        if (timer < NewTarget)
        {
            return;
        }
        NewTarget(gameObject);
        timer = 0;
    }

    private void NewTarget(GameObject gameObject)
    {
        throw new System.NotImplementedException();
    }

    private void NewTarget()
    {
        float myX = GameObject.Transform.position.x;
        float myZ = GameObject.Transform.position.z;

        float xPos = myX + Random.Range(myX - 100, myX + 100);
        float zPos = myZ + Random.Range(myZ - 100, myZ + 100);

        Target = new Vector3(xPos, y: GameObject.Transform.position.y, zPos);

        Nav.SetDestination(Target);
    }

}