using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public float puntosplayer1;
    public TextMeshProUGUI textMesh1;
    
    private void Start()
    {
        textMesh1 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        puntosplayer1 += Time.deltaTime;
        textMesh1.text = puntosplayer1.ToString("0");
    }
    public void SumarPuntos1(float puntosEntrada1)
    {
        puntosplayer1 += puntosEntrada1;
    }

}
