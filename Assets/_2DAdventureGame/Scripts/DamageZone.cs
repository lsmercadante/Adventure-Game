using UnityEngine;

public class DamageZone : MonoBehaviour
{
    // OnTriggerEnter2D only runs when a collision happens

    void OnTriggerStay2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();
        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }
}
