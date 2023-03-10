using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public PlayerController PlayerController;
    public TextMeshProUGUI countText;
    private float currentTime = 0f;
    private float startingTime = 30f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1*Time.deltaTime;
        countText.text = "Tempo:" + currentTime.ToString("0");

        if(currentTime <= 0){
            Time.timeScale = 0;
            PlayerController.GameOver();
            currentTime = 0;
        }
    }
}
