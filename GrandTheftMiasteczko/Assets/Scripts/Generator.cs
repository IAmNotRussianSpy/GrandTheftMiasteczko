using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] Beer;
    public GameObject[] Chips;
    public GameObject[] MagicPotion
    public Vector2 posMin;
    public Vector2 posMax;
    public float interval = 2f;
    [Range(0f, 1f)]
    public float chanceGoodDrop = 0.5f;

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
        if(Beer == null || Chips == null || MagicPotion() == null)
        {
            return;
        }
        bool isGood = Random.value > 1 - chanceGoodDrop;
        GameObject toSpawn = null;
        if(isGood)
        {
            toSpawn = goodThings[Random.Range(0, goodThings.Length)];
        }
        else
        {
            toSpawn = badThings[Random.Range(0, badThings.Length)];
        }

        Vector3 position = new Vector3(Random.Range(posMin.x, posMax.x), Random.Range(posMin.y, posMax.y), 0);
        var newObj = Instantiate(toSpawn, position, Quaternion.identity);
    }
}
