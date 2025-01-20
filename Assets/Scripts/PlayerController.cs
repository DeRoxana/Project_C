using UnityEngine;

public class PlayerController : MonoBehaviour
{  

    private Vector3 mousePosition;
    private float speed = 10f;
    private Rigidbody2D playerRb;
    private Vector2 direction;
    private float speedMovement = 90f;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        

    }
    private void FixedUpdate()
    {

        if (Input.GetMouseButton(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            playerRb.linearVelocity = new Vector2(direction.x * speedMovement, 0);

        }
        else
        {
            playerRb.linearVelocity = Vector2.zero;
        }

    }

    



    }






