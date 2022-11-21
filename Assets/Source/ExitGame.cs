using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}