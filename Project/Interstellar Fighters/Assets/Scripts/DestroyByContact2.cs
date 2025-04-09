using UnityEngine;

public class DestroyByContact2 : MonoBehaviour
{
    public float cantidadPuntos2;
    public Puntaje2 puntaje2;

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "bala2")
        {
            puntaje2.SumarPuntos2(cantidadPuntos2);
            Destroy(other.gameObject);
        }
        Destroy(gameObject);
    }
}
