using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;       //Public variable to store a reference to the player game object
    private float width;
    private float height;

    private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;

        height = 2 * Camera.main.orthographicSize;
        width = height * Camera.main.aspect;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        var tmp = player.transform.position + offset;
        double x;
        if (tmp.x > 13.33 - width / 2)
        {
            x = 13.33 - (width / 2);
        } else if(tmp.x < -41.74 + width / 2)
        {
            x = -41.74 + (width / 2);
        } else
        {
            x = tmp.x;
        }
        double y;
        if (tmp.y > 17.12 - height / 2)
        {
            y = 17.12 - (height / 2);
        }
        else if (tmp.y < -29.78 + height / 2)
        {
            y = -29.78 + (height / 2);
        }
        else
        {
            y = tmp.y;
        }
        Vector3 vector = new Vector3((float)x, (float)y, -23);
        transform.position = vector;
    }
}
