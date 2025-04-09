using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    public GameObject[] hearts;
    public int player;
    public int health;

    [Header ("Movement")]
    public float speed;
            // Maximo y minimo de la psoicion del jugador
    public float xMinPos, xMaxPos, zMinPos, zMaxPos;

    public GameObject ShotObject;
    public GameObject Shot2Object;
    public Transform ShotOrigin; //Origen de la bala
    public Transform ShotOrigin1;
    public float fireRate;

    public float timeElapsed; //tiempo entre disparos

    private Rigidbody rb;

    public Transform ExplosionOrigin;
    public GameObject Explosion;

    public AudioSource AudioSource;
    public AudioClip ShootingClip;
    public AudioSource source;
    public AudioClip ExplosionClip;

    public void Hit()
    {
        health--;
        source.PlayOneShot(ExplosionClip);
        Instantiate(Explosion, ExplosionOrigin.position, Quaternion.identity);

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (health < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        else if (health < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (health < 3)
        {
            Destroy(hearts[2].gameObject);
        }

        timeElapsed += Time.deltaTime;

        if (player == 2 && Input.GetButton("Fire2") && timeElapsed >= fireRate)
        {
        Shoot2();
        timeElapsed = 0;
        }

        if (player != 2 && Input.GetButton("Fire1") && timeElapsed >= fireRate)
        {
        Shoot();
        timeElapsed = 0;
        }
    }


    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (player == 2)
        { 
        float x = Input.GetAxis("Horizontal2");
        float z = Input.GetAxis("Vertical2");

        Vector3 mov = transform.position + new Vector3(x, 0, z) * speed * Time.deltaTime;

        mov.x = Mathf.Clamp(mov.x, xMinPos, xMaxPos);
        mov.z = Mathf.Clamp(mov.z, zMinPos, zMaxPos);

        rb.MovePosition(mov);
        }
        if (player != 2)
        {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 mov = transform.position + new Vector3(x, 0, z) * speed * Time.deltaTime;

        mov.x = Mathf.Clamp(mov.x, xMinPos, xMaxPos);
        mov.z = Mathf.Clamp(mov.z, zMinPos, zMaxPos);

        rb.MovePosition(mov);
        }
    }
    private void Shoot()
    {
        AudioSource.PlayOneShot(ShootingClip);
        Instantiate(ShotObject, ShotOrigin.position, Quaternion.identity);
        Instantiate(ShotObject, ShotOrigin1.position, Quaternion.identity);
    }
    private void Shoot2()
    {
        AudioSource.PlayOneShot(ShootingClip);
        Instantiate(Shot2Object, ShotOrigin.position, Quaternion.identity);
        Instantiate(Shot2Object, ShotOrigin1.position, Quaternion.identity);
    }
}
