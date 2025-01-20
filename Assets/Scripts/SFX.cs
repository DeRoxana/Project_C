using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioClip soundCollect;
    private AudioSource audioPlayer;

    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            audioPlayer.PlayOneShot(soundCollect, 1.0f);
        }

      
    }
}

