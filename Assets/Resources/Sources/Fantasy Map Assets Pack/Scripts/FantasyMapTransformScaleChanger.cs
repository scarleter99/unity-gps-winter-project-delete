using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasyMapTransformScaleChanger : MonoBehaviour
{
    private Transform m_transform;
    private void Start()
    {
        m_transform = GetComponent<Transform>();
    }
    public void ChangeScale(float scale)
    {
        m_transform.localScale = new Vector3 (scale, scale, scale);
    }
}
