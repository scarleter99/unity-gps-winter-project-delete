using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasyMapPageScroll : MonoBehaviour
{
    [SerializeField] private GameObject[] m_pages;
    private int m_currentPageIndex = 0;

    private void Start()
    {
        m_currentPageIndex = 0;
        SetCurrentPage(m_currentPageIndex);
    }
    public void OnClick(bool previousPage)
    {
        if (previousPage)
            m_currentPageIndex--;
        else
            m_currentPageIndex++;

        if(m_currentPageIndex > m_pages.Length - 1)
        {
            m_currentPageIndex = 0;
        }
        else if(m_currentPageIndex < 0)
        {
            m_currentPageIndex = m_pages.Length - 1;
        }

        SetCurrentPage(m_currentPageIndex);
    }
    private void SetCurrentPage(int index)
    {
        for (int i = 0; i < m_pages.Length; i++)
        {
            m_pages[i].SetActive(false);
        }
        m_pages[index].SetActive(true);
    }
}
