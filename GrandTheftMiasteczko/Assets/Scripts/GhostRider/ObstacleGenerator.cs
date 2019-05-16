using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject krataPrefab;
    public float interval;
    public int probability = 50;
    public int score = 0;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", 2.0f, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {
        if(probability < Random.Range(0, 100))
        {
            Instantiate(krataPrefab, new Vector3(10.17f, -4.19f, 0), Quaternion.identity);
            score++;
            text.text = score.ToString();
            if (PlayerStats.babilon < score)
            {
                PlayerStats.babilon = score;
            }
        }
        
    }
}
