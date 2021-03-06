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

public class JSB_UnityEngine_ProceduralPropertyDescription
{

////////////////////// ProceduralPropertyDescription ///////////////////////////////////////
// constructors

static bool ProceduralPropertyDescription_ProceduralPropertyDescription1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.ProceduralPropertyDescription());
    }

    return true;
}

// fields
static void ProceduralPropertyDescription_name(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.name;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    else {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.name = arg0;
    }
}
static void ProceduralPropertyDescription_label(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.label;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    else {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.label = arg0;
    }
}
static void ProceduralPropertyDescription_group(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.group;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    else {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.group = arg0;
    }
}
static void ProceduralPropertyDescription_type(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.type;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else {
        UnityEngine.ProceduralPropertyType arg0 = (UnityEngine.ProceduralPropertyType)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.type = arg0;
    }
}
static void ProceduralPropertyDescription_hasRange(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.hasRange;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.hasRange = arg0;
    }
}
static void ProceduralPropertyDescription_minimum(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.minimum;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.minimum = arg0;
    }
}
static void ProceduralPropertyDescription_maximum(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.maximum;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.maximum = arg0;
    }
}
static void ProceduralPropertyDescription_step(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.step;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.step = arg0;
    }
}
static void ProceduralPropertyDescription_enumOptions(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.enumOptions;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else {
        System.String[] arg0 = JSDataExchangeMgr.GetJSArg<System.String[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.String[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.String)JSApi.getStringS((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.enumOptions = arg0;
    }
}
static void ProceduralPropertyDescription_componentLabels(JSVCall vc)
{
    if (vc.bGet) {
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        var result = _this.componentLabels;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else {
        System.String[] arg0 = JSDataExchangeMgr.GetJSArg<System.String[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.String[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.String)JSApi.getStringS((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.ProceduralPropertyDescription _this = (UnityEngine.ProceduralPropertyDescription)vc.csObj;
        _this.componentLabels = arg0;
    }
}

// properties

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ProceduralPropertyDescription);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        ProceduralPropertyDescription_name,
        ProceduralPropertyDescription_label,
        ProceduralPropertyDescription_group,
        ProceduralPropertyDescription_type,
        ProceduralPropertyDescription_hasRange,
        ProceduralPropertyDescription_minimum,
        ProceduralPropertyDescription_maximum,
        ProceduralPropertyDescription_step,
        ProceduralPropertyDescription_enumOptions,
        ProceduralPropertyDescription_componentLabels,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ProceduralPropertyDescription_ProceduralPropertyDescription1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
