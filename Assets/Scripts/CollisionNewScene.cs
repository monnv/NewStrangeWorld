using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionNewScene : MonoBehaviour
{
    public void LoadNextLevel(int x)
    {
        SceneManager.LoadScene(x);
    }
}
