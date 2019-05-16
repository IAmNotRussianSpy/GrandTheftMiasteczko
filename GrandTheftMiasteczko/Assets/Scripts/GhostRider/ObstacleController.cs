using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < -10)
        {
            Destroy(gameObject);
        }
        gameObject.transform.position = gameObject.transform.position - new Vector3(speed, 0, 0);
    }

}
