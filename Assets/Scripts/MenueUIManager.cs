using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenueUIManager : MonoBehaviour
{
    [SerializeField] TMP_InputField playerNameInputField;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        DataManager.Instance.playerName = playerNameInputField.text;
        SceneManager.LoadScene(1);
    }
}
