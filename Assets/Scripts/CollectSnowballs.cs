using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollectSnowballs : MonoBehaviour
{

    private float limit = 5f;
    public float currentGravity;
   
   

    private void Start()
    {
        currentGravity = GetComponent<Rigidbody2D>().gravityScale;
    } 
        
    private void Update()
    {
        if (transform.position.y < -limit)
        {
            Destroy(gameObject);
        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bucket"))
        {   
            Destroy(gameObject);
            ScoreManager.scoreValue++;
           

        }



    }
}
