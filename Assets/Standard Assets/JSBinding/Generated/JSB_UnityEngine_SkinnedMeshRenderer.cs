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

public class JSB_UnityEngine_SkinnedMeshRenderer
{

////////////////////// SkinnedMeshRenderer ///////////////////////////////////////
// constructors

static bool SkinnedMeshRenderer_SkinnedMeshRenderer1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.SkinnedMeshRenderer());
    }

    return true;
}

// fields

// properties
static void SkinnedMeshRenderer_bones(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        var result = _this.bones;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }
    else
    { 
        UnityEngine.Transform[] arg0 = JSDataExchangeMgr.GetJSArg<UnityEngine.Transform[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new UnityEngine.Transform[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        _this.bones = arg0;
    }
}
static void SkinnedMeshRenderer_rootBone(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        var result = _this.rootBone;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Transform arg0 = (UnityEngine.Transform)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        _this.rootBone = arg0;
    }
}
static void SkinnedMeshRenderer_quality(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        var result = _this.quality;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.SkinQuality arg0 = (UnityEngine.SkinQuality)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        _this.quality = arg0;
    }
}
static void SkinnedMeshRenderer_sharedMesh(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        var result = _this.sharedMesh;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Mesh arg0 = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        _this.sharedMesh = arg0;
    }
}
static void SkinnedMeshRenderer_updateWhenOffscreen(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        var result = _this.updateWhenOffscreen;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        _this.updateWhenOffscreen = arg0;
    }
}
static void SkinnedMeshRenderer_localBounds(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        var result = _this.localBounds;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Bounds arg0 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.SkinnedMeshRenderer _this = (UnityEngine.SkinnedMeshRenderer)vc.csObj;
        _this.localBounds = arg0;
    }
}

// methods

static bool SkinnedMeshRenderer_BakeMesh__Mesh(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Mesh arg0 = (UnityEngine.Mesh)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.SkinnedMeshRenderer)vc.csObj).BakeMesh(arg0);
    }

    return true;
}

static bool SkinnedMeshRenderer_GetBlendShapeWeight__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(((UnityEngine.SkinnedMeshRenderer)vc.csObj).GetBlendShapeWeight(arg0)));
    }

    return true;
}

static bool SkinnedMeshRenderer_SetBlendShapeWeight__Int32__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        ((UnityEngine.SkinnedMeshRenderer)vc.csObj).SetBlendShapeWeight(arg0, arg1);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.SkinnedMeshRenderer);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        SkinnedMeshRenderer_bones,
        SkinnedMeshRenderer_rootBone,
        SkinnedMeshRenderer_quality,
        SkinnedMeshRenderer_sharedMesh,
        SkinnedMeshRenderer_updateWhenOffscreen,
        SkinnedMeshRenderer_localBounds,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(SkinnedMeshRenderer_SkinnedMeshRenderer1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(SkinnedMeshRenderer_BakeMesh__Mesh, "BakeMesh"),
        new JSMgr.MethodCallBackInfo(SkinnedMeshRenderer_GetBlendShapeWeight__Int32, "GetBlendShapeWeight"),
        new JSMgr.MethodCallBackInfo(SkinnedMeshRenderer_SetBlendShapeWeight__Int32__Single, "SetBlendShapeWeight"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}