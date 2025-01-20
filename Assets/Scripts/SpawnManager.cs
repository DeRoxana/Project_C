using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnedObject;

    

    private float spawnRangeX = 6f;
   
    
    private float startDelay = 1f;
    private float timeInterval = 2f;
    


    private void Start()
    {
       
        InvokeRepeating("SpawnSnowballs", startDelay, timeInterval);
    }


     void SpawnSnowballs()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), transform.position.y);
        Instantiate(spawnedObject, spawnPos, Quaternion.identity);

        spawnedObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down, ForceMode2D.Force);

        
        
    }


}
