using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MomentHandler : MonoBehaviour
{
    
    [SerializeField] private GameObject PlayerTransform;
   
    [SerializeField]private GameObject FinaPosTranform;
    private Coroutine HoveringCour;
    [SerializeField] private float hoverTime = 2f;
    public void OnPointerEnter()
    {
        HoveringCour =  StartCoroutine(HoveringCourtinefx());
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

        WayPointSwitch();
    }

    private void WayPointSwitch()
    {
        Debug.Log("empty callled");

        Vector3 finalPos = FinaPosTranform.transform.position;
        PlayerTransform.transform.localPosition = finalPos;
    }

}
