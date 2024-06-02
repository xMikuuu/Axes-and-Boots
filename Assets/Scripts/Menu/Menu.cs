using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    [SerializeField] Image newGame;

    public void NewGame()
    {
        newGame.gameObject.SetActive(true);
    }

    public void Options()
    {
        Debug.Log("options");
    }

    public void ExitGame()
    {
        Debug.Log("exit");
    }
}
