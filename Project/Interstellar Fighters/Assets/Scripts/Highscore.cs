using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public TextMeshProUGUI highscore;

    // Start is called before the first frame update
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        int number = Random.Range(1, 7);
        textMesh.text = number.ToString();

        if (number > PlayerPrefs.GetInt("Highscore", 0))
        { 
            PlayerPrefs.SetInt("HighScore", number);
            highscore.text = number.ToString();
        }
    }
}
