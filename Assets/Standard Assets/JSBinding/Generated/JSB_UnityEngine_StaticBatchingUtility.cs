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

public class JSB_UnityEngine_StaticBatchingUtility
{

////////////////////// StaticBatchingUtility ///////////////////////////////////////
// constructors

static bool StaticBatchingUtility_StaticBatchingUtility1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.StaticBatchingUtility());
    }

    return true;
}

// fields

// properties

// methods

static bool StaticBatchingUtility_Combine__GameObject_Array__GameObject(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.GameObject[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.GameObject[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.GameObject[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.GameObject arg1 = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.StaticBatchingUtility.Combine(arg0, arg1);
    }

    return true;
}

static bool StaticBatchingUtility_Combine__GameObject(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.GameObject arg0 = (UnityEngine.GameObject)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.StaticBatchingUtility.Combine(arg0);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.StaticBatchingUtility);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(StaticBatchingUtility_StaticBatchingUtility1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(StaticBatchingUtility_Combine__GameObject_Array__GameObject, "Combine"),
        new JSMgr.MethodCallBackInfo(StaticBatchingUtility_Combine__GameObject, "Combine"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
