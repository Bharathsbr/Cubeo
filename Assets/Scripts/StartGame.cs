
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void StarGame(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
