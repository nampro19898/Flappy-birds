using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

    public void _DeButton()
    {
        //Application.LoadLevel("GamePlay");
        SceneManager.LoadScene ("GamePlay");
    }

    public void _TbButton()
    {
        Application.LoadLevel("GamePlay2");
        //SceneManager.LoadScene ("GamePlay2");
    }
}
