using System.Collections;
using UnityEngine;

public class GameStartTrigger : MonoBehaviour
{
    public string miniGame;
    public int timeout = 0;

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("lol");
        System.Threading.Thread.Sleep(timeout);
        UnityEngine.SceneManagement.SceneManager.LoadScene(miniGame);
    }
}
