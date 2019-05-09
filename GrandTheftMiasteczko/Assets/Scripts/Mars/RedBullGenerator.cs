using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullGenerator : MonoBehaviour
{

    public GameObject redBullPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=-130; i<60; i=i+5)
        {
            Instantiate(redBullPrefab, new Vector3(Random.Range(-10.0f, 10.0f), i, 0), Quaternion.identity);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
