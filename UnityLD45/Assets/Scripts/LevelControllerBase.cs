using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControllerBase : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnReset()
    {
        OnLocalReset();
    }

    public virtual void OnLocalReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
