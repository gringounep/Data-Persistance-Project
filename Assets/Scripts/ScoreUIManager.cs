using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUIManager : MonoBehaviour
{
    [SerializeField] Text bestScoreNameText;
    
    // Start is called before the first frame update
    void Start()
    {
        UpdateBestScoreNameText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateBestScoreNameText()
    {
        bestScoreNameText.text = "Best Score : " + DataManager.Instance.bestPlayerName + " : " + DataManager.Instance.bestScore;
    }
}
