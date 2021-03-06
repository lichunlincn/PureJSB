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

public class JSB_UnityEngine_NavMeshHit
{

////////////////////// NavMeshHit ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool NavMeshHit_NavMeshHit1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.NavMeshHit());
    }

    return true;
}

// fields

// properties
static void NavMeshHit_position(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        var result = _this.position;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        _this.position = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void NavMeshHit_normal(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        var result = _this.normal;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        _this.normal = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void NavMeshHit_distance(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        var result = _this.distance;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        _this.distance = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void NavMeshHit_mask(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        var result = _this.mask;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        _this.mask = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void NavMeshHit_hit(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        var result = _this.hit;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.NavMeshHit _this = (UnityEngine.NavMeshHit)vc.csObj;
        _this.hit = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.NavMeshHit);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        NavMeshHit_position,
        NavMeshHit_normal,
        NavMeshHit_distance,
        NavMeshHit_mask,
        NavMeshHit_hit,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(NavMeshHit_NavMeshHit1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
