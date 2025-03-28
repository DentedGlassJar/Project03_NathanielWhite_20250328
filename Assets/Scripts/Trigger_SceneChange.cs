using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_SceneChange : MonoBehaviour
{
    public string sceneName;
    public string spawnPoint;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player has entered Trigger_SceneChange!");
        }    
    }
}
