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

public class JSB_UnityEngine_LightProbes
{

////////////////////// LightProbes ///////////////////////////////////////
// constructors

static bool LightProbes_LightProbes1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.LightProbes());
    }

    return true;
}

// fields

// properties
static void LightProbes_positions(JSVCall vc)
{
        UnityEngine.LightProbes _this = (UnityEngine.LightProbes)vc.csObj;
        var result = _this.positions;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setVector3S((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
}
static void LightProbes_coefficients(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.LightProbes _this = (UnityEngine.LightProbes)vc.csObj;
        var result = _this.coefficients;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setSingle((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else
    { 
        System.Single[] arg0 = JSDataExchangeMgr.GetJSArg<System.Single[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Single[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Single)JSApi.getSingle((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.LightProbes _this = (UnityEngine.LightProbes)vc.csObj;
        _this.coefficients = arg0;
    }
}
static void LightProbes_count(JSVCall vc)
{
        UnityEngine.LightProbes _this = (UnityEngine.LightProbes)vc.csObj;
        var result = _this.count;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void LightProbes_cellCount(JSVCall vc)
{
        UnityEngine.LightProbes _this = (UnityEngine.LightProbes)vc.csObj;
        var result = _this.cellCount;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}

// methods

static bool LightProbes_GetInterpolatedLightProbe__Vector3__Renderer__Single_Array(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Renderer arg1 = (UnityEngine.Renderer)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Single[] arg2 = JSDataExchangeMgr.GetJSArg<System.Single[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Single[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Single)JSApi.getSingle((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        ((UnityEngine.LightProbes)vc.csObj).GetInterpolatedLightProbe(arg0, arg1, arg2);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.LightProbes);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        LightProbes_positions,
        LightProbes_coefficients,
        LightProbes_count,
        LightProbes_cellCount,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(LightProbes_LightProbes1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(LightProbes_GetInterpolatedLightProbe__Vector3__Renderer__Single_Array, "GetInterpolatedLightProbe"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}