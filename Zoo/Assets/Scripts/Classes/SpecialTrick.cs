using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialTrick : MonoBehaviour
{
    public void PerformTrick()
    {
        StartCoroutine(DoTrick());
    }

    IEnumerator DoTrick()
    {
        for (int i = 0; i < 360; i++)
        {
            transform.localRotation = Quaternion.Euler(i, 0, 0);
            yield return new WaitForEndOfFrame();
        }
    }
}
