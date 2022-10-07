using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuSceneFlow : MonoBehaviour
{
    [SerializeField] Button buttonNewGame;
    [SerializeField] Button buttonLoadGame;
    [SerializeField] Button buttonOptions;
    // Start is called before the first frame update
    void Start()
    {
        buttonLoadGame.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene("GameplayScene");
    }
}
