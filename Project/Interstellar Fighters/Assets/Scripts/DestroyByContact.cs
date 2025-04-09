using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public float cantidadPuntos1;
    public Puntaje puntaje1;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "bala1")
        {
            puntaje1.SumarPuntos1(cantidadPuntos1);
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
