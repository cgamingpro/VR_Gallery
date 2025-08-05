using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacktoMain : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject CurrentCanvas;
    [SerializeField] private GameObject Main_canvas;


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

        GalleryPannel();
    }

    private void GalleryPannel()
    {
        Main_canvas.SetActive(true);
        CurrentCanvas.SetActive(false);
        
    }
}
