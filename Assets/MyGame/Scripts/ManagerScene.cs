using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public void SceneSwitch()
    {
       SceneManager.LoadScene(1);
    }

    public void SceneSwitch2()
    {
        SceneManager.LoadScene(2);
    }
}
  
