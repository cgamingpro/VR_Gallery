using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXit : MonoBehaviour
{
    // Start is called before the first frame update
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

        ExitGame();
    }

    private void ExitGame()
    {
        Debug.Log("exiting now ");
        Application.Quit();
    }
}
