using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    
    [SerializeField] private GameObject model;


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

        Rotateee();
    }

    private void Rotateee()
    {
        Vector3 current = model.transform.eulerAngles;
        Vector3 target = new Vector3(model.transform.eulerAngles.x, model.transform.eulerAngles.y + 45, model.transform.eulerAngles.z);

        model.transform.eulerAngles = target;
        

    }
}
