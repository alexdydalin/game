using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{    public void ClickExit()
    {
        SceneManager.LoadScene(0);
    }
}
