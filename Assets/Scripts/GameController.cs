using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Transform brick;
    private float offset = 2.0f;

    public static int score;
    
    public Text scoreDisplay;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreDisplay.text = "SCORE : " + score.ToString();
    }

}