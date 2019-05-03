using System.Collections;
using UnityEngine;

public class GameStartTrigger : MonoBehaviour
{
    public string miniGame;

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("lol");
        UnityEngine.SceneManagement.SceneManager.LoadScene(miniGame);
    }
}
