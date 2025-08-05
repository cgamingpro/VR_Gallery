using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLOader : MonoBehaviour
{
    [SerializeField] private int  SceneIndex ;

    private Coroutine HoveringCour;
    [SerializeField] private float hoverTime = 2f;

    public void OnPointerEnter()
    {
        HoveringCour = StartCoroutine(HoveringCourtinefx());
    }
    public void OnPointerExit()
    {
        if (HoveringCour != null)
        {
            Debug.Log("stopingggg now");
            StopCoroutine(HoveringCour);

            HoveringCour = null;
        }
    }

    private IEnumerator HoveringCourtinefx()
    {
        yield return new WaitForSeconds(hoverTime);

        Debug.Log("tryin onoo");

        LoadScene();
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
