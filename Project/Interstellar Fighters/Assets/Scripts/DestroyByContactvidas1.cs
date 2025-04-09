using UnityEngine;

public class DestroyByContactvidas1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if (player != null)
        {
            player.Hit();
        }
    }
}
