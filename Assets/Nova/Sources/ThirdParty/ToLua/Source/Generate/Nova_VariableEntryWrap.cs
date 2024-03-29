﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Nova_VariableEntryWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Nova.VariableEntry), typeof(System.Object));
		L.RegFunction("New", _CreateNova_VariableEntry);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("type", get_type, null);
		L.RegVar("value", get_value, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNova_VariableEntry(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Nova.VariableType arg0 = (Nova.VariableType)ToLua.CheckObject(L, 1, typeof(Nova.VariableType));
				string arg1 = ToLua.CheckString(L, 2);
				Nova.VariableEntry obj = new Nova.VariableEntry(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Nova.VariableEntry.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.VariableEntry obj = (Nova.VariableEntry)o;
			Nova.VariableType ret = obj.type;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index type on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Nova.VariableEntry obj = (Nova.VariableEntry)o;
			string ret = obj.value;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index value on a nil value");
		}
	}
}

