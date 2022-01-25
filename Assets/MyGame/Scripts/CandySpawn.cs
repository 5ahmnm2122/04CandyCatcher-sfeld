using System.Collections;
using UnityEngine;

public class CandySpawn : MonoBehaviour
{
    [SerializeField]
    GameObject[] candies;


    [SerializeField]  float minX = -1.8f;
    [SerializeField]  float maxX = 1.8f;

    [SerializeField] float minTime = 1;
    [SerializeField] float maxTime = 3;

    private void Start()
    {
        StartCoroutine(SpawnCandies(minTime, maxTime)); 
    }

    IEnumerator SpawnCandies(float minTime_, float maxTime_)
    {
        while (true)
        {
            GameObject currentCandy = candies[Random.Range(0, candies.Length )];
            Vector3 candyPos = new Vector3(Random.Range(minX, maxX), gameObject.transform.position.y, gameObject.transform.position.z);
            GameObject.Instantiate(currentCandy, candyPos, Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(minTime_, maxTime_));
        }
    }

}
