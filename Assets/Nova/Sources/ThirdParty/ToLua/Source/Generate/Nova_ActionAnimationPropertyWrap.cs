﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Nova_ActionAnimationPropertyWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.ActionAnimationProperty), typeof(System.Object));
		L.RegFunction("New", _CreateNova_ActionAnimationProperty);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("value", get_value, set_value);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNova_ActionAnimationProperty(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 1);
				Nova.ActionAnimationProperty obj = new Nova.ActionAnimationProperty(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Nova.ActionAnimationProperty.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.ActionAnimationProperty obj = (Nova.ActionAnimationProperty)o;
			float ret = obj.value;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.ActionAnimationProperty obj = (Nova.ActionAnimationProperty)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.value = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}
}

