using UnityEngine;
using UnityEngine.UI;

public class Generator : MonoBehaviour
{
    public GameObject[] Beer;
    public GameObject[] Chips;
    public GameObject[] MagicPotion;
    public Text text;
    public Vector2 posMin;
    public Vector2 posMax;
    public float interval = 1f;
    public int score = 0;
    [Range(0f, 1f)]
    public float chanceBeer = 0.5f;
    [Range(0f, 1f)]
    public float chanceChips = 0.25f;

    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer > interval)
        {
            timer = 0;
            SpawnObject();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(posMin,posMax);
    }

    private void SpawnObject()
    {
        if(Beer == null || Chips == null || MagicPotion == null)
        {
            return;
        }
        bool isBeer = Random.value > 1 - chanceBeer;
        bool isChips = Random.value > 1 - chanceChips;
        GameObject toSpawn = null;
        if(isBeer)
        {
            toSpawn = Beer[Random.Range(0, Beer.Length)];
        }
        else if(isChips)

        {
            toSpawn = Chips[Random.Range(0, Chips.Length)];
        }
        else
        {
            toSpawn = MagicPotion[Random.Range(0, MagicPotion.Length)];
        }

        Vector3 position = new Vector3(Random.Range(posMin.x, posMax.x), Random.Range(posMin.y, posMax.y), 0);
        var newObj = Instantiate(toSpawn, position, Quaternion.identity);
        score++;
        text.text = score.ToString();
    }
}
