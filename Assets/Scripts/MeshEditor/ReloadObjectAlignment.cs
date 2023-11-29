using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadObjectAlignment : MonoBehaviour
{
    public void OnButtonPress (string ObjectAlignment) {
        SceneManager.LoadScene( ObjectAlignment );
    }
}
