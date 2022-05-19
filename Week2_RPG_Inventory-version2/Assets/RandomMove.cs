using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public GameObject enemy;
    public float enemySpeed;
    private float xdirection = 1;
    private float ydirection = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.transform.Translate(new Vector3(xdirection,ydirection)*enemySpeed * Time.deltaTime);
        if(enemy.transform.position.x>35){
            xdirection = -1;
        }
        if(enemy.transform.position.x<-35){
            xdirection = 1;
        }
        if(enemy.transform.position.y>20){
            ydirection = -1;
        }
        if(enemy.transform.position.y<-20){
            ydirection = 1;
        }
    }
}
