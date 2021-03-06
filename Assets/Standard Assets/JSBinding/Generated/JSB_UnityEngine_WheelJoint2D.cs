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

public class JSB_UnityEngine_WheelJoint2D
{

////////////////////// WheelJoint2D ///////////////////////////////////////
// constructors

static bool WheelJoint2D_WheelJoint2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.WheelJoint2D());
    }

    return true;
}

// fields

// properties
static void WheelJoint2D_suspension(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WheelJoint2D _this = (UnityEngine.WheelJoint2D)vc.csObj;
        var result = _this.suspension;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.JointSuspension2D arg0 = (UnityEngine.JointSuspension2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.WheelJoint2D _this = (UnityEngine.WheelJoint2D)vc.csObj;
        _this.suspension = arg0;
    }
}
static void WheelJoint2D_useMotor(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WheelJoint2D _this = (UnityEngine.WheelJoint2D)vc.csObj;
        var result = _this.useMotor;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.WheelJoint2D _this = (UnityEngine.WheelJoint2D)vc.csObj;
        _this.useMotor = arg0;
    }
}
static void WheelJoint2D_motor(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WheelJoint2D _this = (UnityEngine.WheelJoint2D)vc.csObj;
        var result = _this.motor;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.JointMotor2D arg0 = (UnityEngine.JointMotor2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.WheelJoint2D _this = (UnityEngine.WheelJoint2D)vc.csObj;
        _this.motor = arg0;
    }
}
static void WheelJoint2D_jointTranslation(JSVCall vc)
{
        UnityEngine.WheelJoint2D _this = (UnityEngine.WheelJoint2D)vc.csObj;
        var result = _this.jointTranslation;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void WheelJoint2D_jointSpeed(JSVCall vc)
{
        UnityEngine.WheelJoint2D _this = (UnityEngine.WheelJoint2D)vc.csObj;
        var result = _this.jointSpeed;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}

// methods

static bool WheelJoint2D_GetMotorTorque__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(((UnityEngine.WheelJoint2D)vc.csObj).GetMotorTorque(arg0)));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.WheelJoint2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        WheelJoint2D_suspension,
        WheelJoint2D_useMotor,
        WheelJoint2D_motor,
        WheelJoint2D_jointTranslation,
        WheelJoint2D_jointSpeed,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(WheelJoint2D_WheelJoint2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(WheelJoint2D_GetMotorTorque__Single, "GetMotorTorque"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}
