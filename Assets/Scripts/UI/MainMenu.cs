using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startButton;
    public InputField nicknameInput;


    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.Find("Button").GetComponent<Button>();
        nicknameInput = GameObject.Find("InputField").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SaveNickname()
    {
        PersistanceManager.currentNickname = nicknameInput.text;
    }

    public void StartGame()
    {
        SaveNickname();
        SceneManager.LoadScene(1);
    }
}
