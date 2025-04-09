using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed;
    private PlayerController player;
    private bool stopfollow;


    // Start is called before the first frame update
    void Start()
    {
        PlayerController[] PlayerControllers =
            FindObjectsOfType<PlayerController>();
        int index = Random.Range(0, PlayerControllers.Length);
        player = PlayerControllers[index];

    }

    // Update is called once per frame
    void Update()
    {
        if (!stopfollow)
        {
            if (player != null)
                transform.LookAt(player.transform);
            else
                stopfollow = true;
        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
