using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{

    public GameObject[] Targets;
    public float speed = 1;

    private int targetPositionIndex = 0;
    private Vector3 currentTarget;
    private Vector3[] TargetPositions;
    // Start is called before the first frame update

     public LevelControllerBase levelControler;
    void Start()
    {
        TargetPositions = new Vector3[Targets.Length];
        for(int i = 0; i < Targets.Length; i++)
        {
            Targets[i].GetComponent<SpriteRenderer>().enabled = false;
            TargetPositions[i] = new Vector3(Targets[i].transform.position.x, Targets[i].transform.position.y, Targets[i].transform.position.z); //ewww
        }
        currentTarget = TargetPositions[targetPositionIndex];
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, step);
        if (Vector3.Distance(transform.position, currentTarget) < 0.1f)
        {
            if(TargetPositions.Length > targetPositionIndex + 1)
            {
                targetPositionIndex += 1;
                currentTarget = TargetPositions[targetPositionIndex];
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            } else
            {
                targetPositionIndex = 0;
                currentTarget = TargetPositions[targetPositionIndex];
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            }
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.otherCollider);
        levelControler.OnReset();
    }
}
