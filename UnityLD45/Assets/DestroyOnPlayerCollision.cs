using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnPlayerCollision : MonoBehaviour
{
    public GameObject player;
    public GameObject thisEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.otherCollider);
        Destroy(thisEnemy);
    }
}


  