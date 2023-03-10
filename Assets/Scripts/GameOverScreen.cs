using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameOverScreen : MonoBehaviour
{

    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI GameOverText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        ScoreText.text = score.ToString() + " POINTS";
        if(score >= 12)
        {
            GameOverText.text = "YOU WIN!";
        }
        else
        {
            GameOverText.text = "GAME OVER!";
        }
    }

    public void RestartButton()
    {
        
        SceneManager.LoadScene("Minigame");
    }
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
