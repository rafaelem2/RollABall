using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private float currentTime = 0f;
    private float startingTime = 5f;
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
            SceneManager.LoadScene("Game Over");
            currentTime = 0;
        }
    }
}