﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using UnityEngine;
using LuaInterface;

public static partial class LuaBinder
{
	static partial void Bind_Gen(LuaState L)
	{
		float t = Time.realtimeSinceStartup;
		L.BeginModule(null);
		L.BeginModule("UnityEngine");
		UnityEngine_GameObjectWrap.Register(L);
		UnityEngine_Texture2DWrap.Register(L);
		UnityEngine_RenderTextureWrap.Register(L);
		UnityEngine_RectTransformWrap.Register(L);
		UnityEngine_SpriteRendererWrap.Register(L);
		UnityEngine_TextureWrap.Register(L);
		UnityEngine_MonoBehaviourWrap.Register(L);
		UnityEngine_BehaviourWrap.Register(L);
		UnityEngine_ComponentWrap.Register(L);
		UnityEngine_TransformWrap.Register(L);
		UnityEngine_RendererWrap.Register(L);
		UnityEngine_MaterialWrap.Register(L);
		L.BeginModule("UI");
		UnityEngine_UI_ImageWrap.Register(L);
		UnityEngine_UI_MaskableGraphicWrap.Register(L);
		UnityEngine_UI_GraphicWrap.Register(L);
		L.EndModule();
		L.BeginModule("Playables");
		UnityEngine_Playables_PlayableDirectorWrap.Register(L);
		L.EndModule();
		L.BeginModule("Video");
		UnityEngine_Video_VideoClipWrap.Register(L);
		UnityEngine_Video_VideoPlayerWrap.Register(L);
		L.BeginModule("VideoPlayer");
		L.RegFunction("EventHandler", UnityEngine_Video_VideoPlayer_EventHandler);
		L.RegFunction("ErrorEventHandler", UnityEngine_Video_VideoPlayer_ErrorEventHandler);
		L.RegFunction("TimeEventHandler", UnityEngine_Video_VideoPlayer_TimeEventHandler);
		L.RegFunction("FrameReadyEventHandler", UnityEngine_Video_VideoPlayer_FrameReadyEventHandler);
		L.EndModule();
		L.EndModule();
		L.BeginModule("EventSystems");
		UnityEngine_EventSystems_UIBehaviourWrap.Register(L);
		L.EndModule();
		L.BeginModule("Events");
		L.RegFunction("UnityAction", UnityEngine_Events_UnityAction);
		L.EndModule();
		L.BeginModule("RectTransform");
		L.RegFunction("ReapplyDrivenProperties", UnityEngine_RectTransform_ReapplyDrivenProperties);
		L.EndModule();
		L.EndModule();
		L.BeginModule("TMPro");
		TMPro_TextAlignmentOptionsWrap.Register(L);
		L.EndModule();
		L.BeginModule("Nova");
		Nova_SelectionListWrap.Register(L);
		Nova_AdvancedDialogueHelperWrap.Register(L);
		Nova_AlertWrap.Register(L);
		Nova_ActionAnimationPropertyWrap.Register(L);
		Nova_AnchorAnimationPropertyWrap.Register(L);
		Nova_AnimationEntryWrap.Register(L);
		Nova_CameraSizeAnimationPropertyWrap.Register(L);
		Nova_ColorAnimationPropertyWrap.Register(L);
		Nova_UseRelativeValueWrap.Register(L);
		Nova_MaterialFloatAnimationPropertyWrap.Register(L);
		Nova_AnimationTypeWrap.Register(L);
		Nova_NovaAnimationWrap.Register(L);
		Nova_OffsetAnimationPropertyWrap.Register(L);
		Nova_PositionAnimationPropertyWrap.Register(L);
		Nova_RectTransformAnimationPropertyWrap.Register(L);
		Nova_RotationAnimationPropertyWrap.Register(L);
		Nova_ScaleAnimationPropertyWrap.Register(L);
		Nova_TimeAnimationPropertyWrap.Register(L);
		Nova_VolumeAnimationPropertyWrap.Register(L);
		Nova_AssetCacheTypeWrap.Register(L);
		Nova_AssetLoaderWrap.Register(L);
		Nova_CoroutineHelperWrap.Register(L);
		Nova_I18nWrap.Register(L);
		Nova_I18nHelperWrap.Register(L);
		Nova_BranchModeWrap.Register(L);
		Nova_BranchImageInformationWrap.Register(L);
		Nova_DialogueActionStageWrap.Register(L);
		Nova_ExecutionModeWrap.Register(L);
		Nova_ExecutionContextWrap.Register(L);
		Nova_ScriptDialogueEntryParserWrap.Register(L);
		Nova_ScriptLoaderWrap.Register(L);
		Nova_MaterialPoolWrap.Register(L);
		Nova_PostProcessingWrap.Register(L);
		Nova_RestorableMaterialWrap.Register(L);
		Nova_VariableTypeWrap.Register(L);
		Nova_VariableEntryWrap.Register(L);
		Nova_VariablesWrap.Register(L);
		Nova_AutoVoiceWrap.Register(L);
		Nova_CameraOverlayMaskWrap.Register(L);
		Nova_CheckpointHelperWrap.Register(L);
		Nova_AudioControllerWrap.Register(L);
		Nova_CameraControllerWrap.Register(L);
		Nova_CharacterColorWrap.Register(L);
		Nova_CharacterControllerWrap.Register(L);
		Nova_MeshControllerWrap.Register(L);
		Nova_SoundControllerWrap.Register(L);
		Nova_SpriteControllerWrap.Register(L);
		Nova_TimelineControllerWrap.Register(L);
		Nova_VideoControllerWrap.Register(L);
		Nova_FenceHelperWrap.Register(L);
		Nova_InputHelperWrap.Register(L);
		Nova_RenderQueueOverriderWrap.Register(L);
		Nova_ScreenCapturerWrap.Register(L);
		Nova_AvatarControllerWrap.Register(L);
		Nova_DialogueBoxStateWrap.Register(L);
		Nova_ImageUnlockHelperWrap.Register(L);
		Nova_MusicUnlockHelperWrap.Register(L);
		Nova_DialogueBoxControllerWrap.Register(L);
		Nova_DialogueBoxColorWrap.Register(L);
		Nova_LazyComputableAnimationProperty_UnityEngine_Vector4_UnityEngine_Vector4Wrap.Register(L);
		Nova_FloatBaseAnimationPropertyWrap.Register(L);
		Nova_LazyComputableAnimationProperty_float_floatWrap.Register(L);
		Nova_LazyComputableAnimationProperty_UnityEngine_Color_UnityEngine_ColorWrap.Register(L);
		Nova_LazyComputableAnimationProperty_UnityEngine_Vector3_UnityEngine_Vector3Wrap.Register(L);
		Nova_LazyComputableAnimationProperty_UnityEngine_Quaternion_UnityEngine_QuaternionWrap.Register(L);
		Nova_CompositeSpriteControllerBaseWrap.Register(L);
		Nova_ViewControllerBaseWrap.Register(L);
		L.BeginModule("SelectionOccursData");
		Nova_SelectionOccursData_SelectionWrap.Register(L);
		L.EndModule();
		L.BeginModule("CharacterColor");
		Nova_CharacterColor_TypeWrap.Register(L);
		L.EndModule();
		L.BeginModule("DialogueBoxController");
		Nova_DialogueBoxController_DialogueUpdateModeWrap.Register(L);
		Nova_DialogueBoxController_ThemeWrap.Register(L);
		L.EndModule();
		L.BeginModule("DialogueBoxColor");
		Nova_DialogueBoxColor_TypeWrap.Register(L);
		L.EndModule();
		L.BeginModule("AnimationEntry");
		L.RegFunction("EasingFunction", Nova_AnimationEntry_EasingFunction);
		L.EndModule();
		L.EndModule();
		L.BeginModule("System");
		L.RegFunction("Action", System_Action);
		L.RegFunction("Action_int", System_Action_int);
		L.RegFunction("Comparison_int", System_Comparison_int);
		L.RegFunction("Func_int_int", System_Func_int_int);
		L.RegFunction("Predicate_int", System_Predicate_int);
		L.RegFunction("Action_UnityEngine_Playables_PlayableDirector", System_Action_UnityEngine_Playables_PlayableDirector);
		L.EndModule();
		L.EndModule();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Video_VideoPlayer_EventHandler(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Video.VideoPlayer.EventHandler>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Video.VideoPlayer.EventHandler>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Video_VideoPlayer_ErrorEventHandler(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Video.VideoPlayer.ErrorEventHandler>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Video.VideoPlayer.ErrorEventHandler>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Video_VideoPlayer_TimeEventHandler(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Video.VideoPlayer.TimeEventHandler>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Video.VideoPlayer.TimeEventHandler>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Video_VideoPlayer_FrameReadyEventHandler(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Video.VideoPlayer.FrameReadyEventHandler>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Video.VideoPlayer.FrameReadyEventHandler>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_Events_UnityAction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.Events.UnityAction>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnityEngine_RectTransform_ReapplyDrivenProperties(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<UnityEngine.RectTransform.ReapplyDrivenProperties>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<UnityEngine.RectTransform.ReapplyDrivenProperties>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Nova_AnimationEntry_EasingFunction(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<Nova.AnimationEntry.EasingFunction>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<Nova.AnimationEntry.EasingFunction>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action<int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action<int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Comparison_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Comparison<int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Comparison<int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Func_int_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Func<int,int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Func<int,int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Predicate_int(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Predicate<int>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Predicate<int>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int System_Action_UnityEngine_Playables_PlayableDirector(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<System.Action<UnityEngine.Playables.PlayableDirector>>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<System.Action<UnityEngine.Playables.PlayableDirector>>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
