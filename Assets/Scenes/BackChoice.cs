using UnityEngine;
using UnityEngine.SceneManagement;

public class BackChoice : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Choice");
    }
}