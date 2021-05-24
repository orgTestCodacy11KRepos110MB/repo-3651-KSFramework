﻿using System;
using System.Collections.Generic;
using KEngine;
using KSFramework;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Author：qingqing.zhao (569032731@qq.com)
/// Date：2021/2/4 16:29
/// Desc：相当于主界面中的一部分，对于mmo建议把主界面拆到多个UI中
/// </summary>
public class UIMain : ILRuntimeUIBase
{
    public override void OnInit()
    {
        UIClickLister.Get(gameObject.FindChild<Button>("BtnHead"), OnClick);
    }

    public override void BeforeOpen(object[] onOpenArgs)
    {
    }

    public override void OnOpen(params object[] args)
    {
    }

    public override void OnClose()
    {
    }

    void OnClick(MonoBehaviour behaviour)
    {
        var id = behaviour.name.Trim();
        if (id == "BtnHead")
        {
            UIManager.Instance.OpenWindow("UIRoleInfo");
        }
    }
}