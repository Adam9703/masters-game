using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadingController : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public TextMeshProUGUI progressText;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    // A coroutine that has the ability to pause exectuion and return control to unity
    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        // When the coroutine is called a scene is loaded Asynchronously using the scene index specified
        // Store this information into a variable called operation
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        // While loop runs until the process is done and returns a message on current progress
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);

            slider.value = progress;
            progressText.text = progress * 100f + "%";

            yield return null; // Wait until the next frame before continuing
        }
    }
}
