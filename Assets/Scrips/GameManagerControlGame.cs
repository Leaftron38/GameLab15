using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerControlGame : MonoBehaviour
{
    public Text score;
    public int currentScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int points)
    {
        currentScore = currentScore + points;
        score.text = "Score: " + currentScore;
    }
    

    
}
