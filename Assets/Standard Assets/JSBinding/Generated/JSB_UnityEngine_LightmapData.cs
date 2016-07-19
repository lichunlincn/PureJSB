﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by CSGenerator.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using jsval = JSApi.jsval;

public class JSB_UnityEngine_LightmapData
{

////////////////////// LightmapData ///////////////////////////////////////
// constructors

static bool LightmapData_LightmapData1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.LightmapData());
    }

    return true;
}

// fields

// properties
static void LightmapData_lightmapFar(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.LightmapData _this = (UnityEngine.LightmapData)vc.csObj;
        var result = _this.lightmapFar;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.LightmapData _this = (UnityEngine.LightmapData)vc.csObj;
        _this.lightmapFar = arg0;
    }
}
static void LightmapData_lightmapNear(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.LightmapData _this = (UnityEngine.LightmapData)vc.csObj;
        var result = _this.lightmapNear;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.LightmapData _this = (UnityEngine.LightmapData)vc.csObj;
        _this.lightmapNear = arg0;
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.LightmapData);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        LightmapData_lightmapFar,
        LightmapData_lightmapNear,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(LightmapData_LightmapData1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}