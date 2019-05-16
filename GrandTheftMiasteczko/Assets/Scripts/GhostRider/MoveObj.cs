using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObj : MonoBehaviour
{

    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < -25.5f)
        {
            gameObject.transform.position = new Vector3(0, gameObject.transform.position.y, 0);
            gameObject.transform.position = gameObject.transform.position + new Vector3(21.29f, 0, 0);
        }
        gameObject.transform.position = gameObject.transform.position - new Vector3(speed, 0, 0);
    }
}
