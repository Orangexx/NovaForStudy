﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Nova_AlertWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.Alert), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Show", Show);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("AlertKeyPrefix", get_AlertKeyPrefix, null);
		L.RegVar("alertFunction", get_alertFunction, set_alertFunction);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Show(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				Nova.Alert.Show(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				Nova.Alert.Show(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<System.Action>(L, 2))
			{
				string arg0 = ToLua.CheckString(L, 1);
				System.Action arg1 = (System.Action)ToLua.ToObject(L, 2);
				Nova.Alert.Show(arg0, arg1);
				return 0;
			}
			else if (count == 3)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				System.Action arg2 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 3);
				Nova.Alert.Show(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				System.Action arg2 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 3);
				System.Action arg3 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 4);
				Nova.Alert.Show(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 5)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				System.Action arg2 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 3);
				System.Action arg3 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 4);
				string arg4 = ToLua.CheckString(L, 5);
				Nova.Alert.Show(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Nova.Alert.Show");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AlertKeyPrefix(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, Nova.Alert.AlertKeyPrefix);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_alertFunction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.Alert obj = (Nova.Alert)o;
			Nova.AlertEvent ret = obj.alertFunction;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alertFunction on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_alertFunction(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.Alert obj = (Nova.Alert)o;
			Nova.AlertEvent arg0 = (Nova.AlertEvent)ToLua.CheckObject<Nova.AlertEvent>(L, 2);
			obj.alertFunction = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index alertFunction on a nil value");
		}
	}
}
