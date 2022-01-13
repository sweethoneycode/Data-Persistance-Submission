using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{

    private int best_score;
    public Text BestScoreText;

    private void Awake()
    {
        //SaveGame.Instance.LoadScore();
    }

    // Start is called before the first frame update
    void Start()
    {
 
        best_score= SaveGame.Instance.activeSave.best_score;
        BestScoreText.text = $"Best Score : {best_score}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
