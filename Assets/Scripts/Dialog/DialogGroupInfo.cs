using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogGroupInfo : DialogBase
{
    [SerializeField]
    Button btnNext;
    [SerializeField]
    Button btnBack;
    [SerializeField]
    Button btnClose;
    public override void Setup()
    {
        btnNext.onClick.AddListener(() => );
    }

    public override void Close()
    {
        btnNext.onClick.RemoveAllListeners();
        btnBack.onClick.RemoveAllListeners();
        btnClose.onClick.RemoveAllListeners();
    }

    public void OnDestroy()
    {
        Close();
    }
}
