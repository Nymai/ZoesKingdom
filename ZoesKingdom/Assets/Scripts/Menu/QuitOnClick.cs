using UnityEngine;
using System.Collections;
using UnityEditor;

public class QuitOnClick : MonoBehaviour
{

    /* CALLS THE QUIT OPTION SINCE THE GAME  
     * It makes possible closing the game in a fullscreen mode more easily
     */

    public void Quit()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif

    }

}