﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Nova_ScriptDialogueEntryParserWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("ScriptDialogueEntryParser");
		L.RegFunction("AddPattern", AddPattern);
		L.RegFunction("AddPatternWithObject", AddPatternWithObject);
		L.RegFunction("AddPatternForTable", AddPatternForTable);
		L.RegFunction("AddPatternWithObjectForTable", AddPatternWithObjectForTable);
		L.RegFunction("AddPatternWithObjectAndResource", AddPatternWithObjectAndResource);
		L.RegFunction("AddCheckpointPattern", AddCheckpointPattern);
		L.RegFunction("ParseDialogueEntries", ParseDialogueEntries);
		L.RegFunction("ParseLocalizedDialogueEntries", ParseLocalizedDialogueEntries);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddPattern(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			Nova.ScriptDialogueEntryParser.AddPattern(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddPatternWithObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			Nova.ScriptDialogueEntryParser.AddPatternWithObject(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddPatternForTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			Nova.ScriptDialogueEntryParser.AddPatternForTable(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddPatternWithObjectForTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			Nova.ScriptDialogueEntryParser.AddPatternWithObjectForTable(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddPatternWithObjectAndResource(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			string arg2 = ToLua.CheckString(L, 3);
			Nova.ScriptDialogueEntryParser.AddPatternWithObjectAndResource(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddCheckpointPattern(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			string arg1 = ToLua.CheckString(L, 2);
			Nova.ScriptDialogueEntryParser.AddCheckpointPattern(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ParseDialogueEntries(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.Generic.IReadOnlyList<Nova.ScriptLoader.Chunk> arg0 = (System.Collections.Generic.IReadOnlyList<Nova.ScriptLoader.Chunk>)ToLua.CheckObject<System.Collections.Generic.IReadOnlyList<Nova.ScriptLoader.Chunk>>(L, 1);
			System.Collections.Generic.List<Nova.DialogueEntry> o = Nova.ScriptDialogueEntryParser.ParseDialogueEntries(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ParseLocalizedDialogueEntries(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Collections.Generic.IReadOnlyList<Nova.ScriptLoader.Chunk> arg0 = (System.Collections.Generic.IReadOnlyList<Nova.ScriptLoader.Chunk>)ToLua.CheckObject<System.Collections.Generic.IReadOnlyList<Nova.ScriptLoader.Chunk>>(L, 1);
			System.Collections.Generic.List<Nova.LocalizedDialogueEntry> o = Nova.ScriptDialogueEntryParser.ParseLocalizedDialogueEntries(arg0);
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

