using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{

    public GameObject[] positions;
    public bool canMoveX = true, canMoveY = false, canMovez = false;
    public float speed;

    private int targetPosition = 0;
    private Transform currentTarget;
    // Start is called before the first frame update
    void Start()
    {
        currentTarget = positions[targetPosition].transform;
        foreach(GameObject go in positions)
        {
            go.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, step);
        Debug.Log(Vector3.Distance(transform.position, currentTarget.position) < 0.1f);
        if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
        {
            if(positions.Length > targetPosition + 1)
            {
                targetPosition += 1;
                currentTarget = positions[targetPosition].transform;
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            } else
            {
                targetPosition = 0;
                currentTarget = positions[targetPosition].transform;
                transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            }
        }

    }
}
