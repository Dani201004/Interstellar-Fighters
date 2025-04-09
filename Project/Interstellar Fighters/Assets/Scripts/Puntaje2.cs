using UnityEngine;
using TMPro;

public class Puntaje2 : MonoBehaviour
{
    public float puntosplayer2;
    public TextMeshProUGUI textMesh2;
    
    private void Start()
    {
        textMesh2 = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        puntosplayer2 += Time.deltaTime;
        textMesh2.text = puntosplayer2.ToString("0");
    }
    public void SumarPuntos2(float puntosEntrada2)
    {
        puntosplayer2 += puntosEntrada2;
    }
}
