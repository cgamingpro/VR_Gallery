using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphicsettings : MonoBehaviour
{
    private Coroutine HoveringCour;
    [SerializeField] private float hoverTime = 2f;
    [SerializeField] private int settingnum = 0;
    [SerializeField]private GameObject main_canvas;
    [SerializeField] private GameObject Current_canvas;
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

        QualitySet();
    }

    private void QualitySet()
    {
        QualitySettings.SetQualityLevel(settingnum);
        main_canvas.SetActive(true);
        Current_canvas.SetActive(false);
    }
}
