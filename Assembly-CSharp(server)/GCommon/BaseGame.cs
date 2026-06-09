using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EDE RID: 3806
	[Token(Token = "0x2000EDE")]
	public abstract class BaseGame
	{
		// Token: 0x060034AE RID: 13486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AE")]
		[Address(RVA = "0x25E3FA0", Offset = "0x25E3FA0", VA = "0x7BBCDE3FA0")]
		internal static void RegisterEntity(Entity entity)
		{
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034AF")]
		[Address(RVA = "0x25E4188", Offset = "0x25E4188", VA = "0x7BBCDE4188")]
		internal static void UnregisterEntity(Entity entity)
		{
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069A")]
		public UIBaseScene UIScene
		{
			[Token(Token = "0x60034B0")]
			[Address(RVA = "0x25E437C", Offset = "0x25E437C", VA = "0x7BBCDE437C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060034B1 RID: 13489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069B")]
		public TimeService GameTimer
		{
			[Token(Token = "0x60034B1")]
			[Address(RVA = "0x25E4384", Offset = "0x25E4384", VA = "0x7BBCDE4384")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069C")]
		public TimeService SimulationTimer
		{
			[Token(Token = "0x60034B2")]
			[Address(RVA = "0x25E438C", Offset = "0x25E438C", VA = "0x7BBCDE438C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069D")]
		public EventDispatcher GameEventDispatcher
		{
			[Token(Token = "0x60034B3")]
			[Address(RVA = "0x25E4394", Offset = "0x25E4394", VA = "0x7BBCDE4394")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700069E")]
		public BaseGameContext GameContext
		{
			[Token(Token = "0x60034B4")]
			[Address(RVA = "0x25E439C", Offset = "0x25E439C", VA = "0x7BBCDE439C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B5")]
		[Address(RVA = "0x25E43A4", Offset = "0x25E43A4", VA = "0x7BBCDE43A4")]
		public void Init([Optional] BaseGameContext gameContext)
		{
		}

		// Token: 0x060034B6 RID: 13494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B6")]
		[Address(RVA = "0x25E4748", Offset = "0x25E4748", VA = "0x7BBCDE4748")]
		public void SceneLoaded()
		{
		}

		// Token: 0x060034B7 RID: 13495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B7")]
		[Address(RVA = "0x25E4758", Offset = "0x25E4758", VA = "0x7BBCDE4758")]
		private void InitSceneIfNeed()
		{
		}

		// Token: 0x060034B8 RID: 13496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B8")]
		[Address(RVA = "0x25E47AC", Offset = "0x25E47AC", VA = "0x7BBCDE47AC")]
		public void SceneStart()
		{
		}

		// Token: 0x060034B9 RID: 13497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034B9")]
		[Address(RVA = "0x25E47B0", Offset = "0x25E47B0", VA = "0x7BBCDE47B0")]
		public void PreloadLoaded()
		{
		}

		// Token: 0x060034BA RID: 13498 RVA: 0x0000FD50 File Offset: 0x0000DF50
		[Token(Token = "0x60034BA")]
		[Address(RVA = "0x25E47BC", Offset = "0x25E47BC", VA = "0x7BBCDE47BC", Slot = "4")]
		public virtual uint GetPreloadCountPerFrame()
		{
			return 0U;
		}

		// Token: 0x060034BB RID: 13499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BB")]
		[Address(RVA = "0x25E47C4", Offset = "0x25E47C4", VA = "0x7BBCDE47C4")]
		public void RunOneFrame()
		{
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BC")]
		[Address(RVA = "0x25E50D0", Offset = "0x25E50D0", VA = "0x7BBCDE50D0")]
		public void FixedRunOneFrame()
		{
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034BD")]
		[Address(RVA = "0x25E53D0", Offset = "0x25E53D0", VA = "0x7BBCDE53D0")]
		public void UnInit()
		{
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x0000FD68 File Offset: 0x0000DF68
		[Token(Token = "0x60034BE")]
		[Address(RVA = "0x25E555C", Offset = "0x25E555C", VA = "0x7BBCDE555C")]
		public uint DelayCall(float delayTime, Action action, bool isRepeated = false)
		{
			return 0U;
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x60034BF")]
		[Address(RVA = "0x25E5708", Offset = "0x25E5708", VA = "0x7BBCDE5708")]
		public uint CancelAndDelayCall(uint id, float delayTime, Action action, bool isRepeated = false)
		{
			return 0U;
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C0")]
		[Address(RVA = "0x25E575C", Offset = "0x25E575C", VA = "0x7BBCDE575C")]
		public void CancelDelayCall(uint id)
		{
		}

		// Token: 0x060034C1 RID: 13505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C1")]
		[Address(RVA = "0x25E5860", Offset = "0x25E5860", VA = "0x7BBCDE5860")]
		public void MoveFrontDelayCall(uint id)
		{
		}

		// Token: 0x060034C2 RID: 13506 RVA: 0x0000FD98 File Offset: 0x0000DF98
		[Token(Token = "0x60034C2")]
		[Address(RVA = "0x25E58FC", Offset = "0x25E58FC", VA = "0x7BBCDE58FC")]
		public bool HasInited()
		{
			return default(bool);
		}

		// Token: 0x060034C3 RID: 13507 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x25E5904", Offset = "0x25E5904", VA = "0x7BBCDE5904")]
		public bool HasLoadingFailed()
		{
			return default(bool);
		}

		// Token: 0x060034C4 RID: 13508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C4")]
		[Address(RVA = "0x25E590C", Offset = "0x25E590C", VA = "0x7BBCDE590C", Slot = "5")]
		public virtual void OnStartLoadScene()
		{
		}

		// Token: 0x060034C5 RID: 13509 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x25E5910", Offset = "0x25E5910", VA = "0x7BBCDE5910", Slot = "6")]
		public virtual bool NeedPreloadBeforeLoadScene()
		{
			return default(bool);
		}

		// Token: 0x060034C6 RID: 13510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034C6")]
		[Address(RVA = "0x25E5918", Offset = "0x25E5918", VA = "0x7BBCDE5918", Slot = "7")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113B3F8", Offset = "0x113B3F8")]
		public virtual IEnumerator OnPreprocessFinished()
		{
			return null;
		}

		// Token: 0x060034C7 RID: 13511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x25E59A4", Offset = "0x25E59A4", VA = "0x7BBCDE59A4", Slot = "8")]
		protected virtual void OnAwake()
		{
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x25E59A8", Offset = "0x25E59A8", VA = "0x7BBCDE59A8", Slot = "9")]
		protected virtual void OnSceneLoaded()
		{
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x25E59AC", Offset = "0x25E59AC", VA = "0x7BBCDE59AC", Slot = "10")]
		protected virtual void OnPreloadLoaded()
		{
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CA")]
		[Address(RVA = "0x25E59B0", Offset = "0x25E59B0", VA = "0x7BBCDE59B0", Slot = "11")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CB")]
		[Address(RVA = "0x25E59B4", Offset = "0x25E59B4", VA = "0x7BBCDE59B4", Slot = "12")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x25E59B8", Offset = "0x25E59B8", VA = "0x7BBCDE59B8", Slot = "13")]
		protected virtual void OnInputUpdate()
		{
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x25E59BC", Offset = "0x25E59BC", VA = "0x7BBCDE59BC", Slot = "14")]
		protected virtual void OnFixedUpdate()
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x25E59C0", Offset = "0x25E59C0", VA = "0x7BBCDE59C0", Slot = "15")]
		protected virtual void OnNetworkFixedUpdate()
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x25E59C4", Offset = "0x25E59C4", VA = "0x7BBCDE59C4", Slot = "16")]
		protected virtual bool SkipFixedUpdate()
		{
			return default(bool);
		}

		// Token: 0x060034D0 RID: 13520
		[Token(Token = "0x60034D0")]
		public abstract ResourceID[] GetResourceID();

		// Token: 0x060034D1 RID: 13521
		[Token(Token = "0x60034D1")]
		public abstract Type GetUISceneType();

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x25E59CC", Offset = "0x25E59CC", VA = "0x7BBCDE59CC", Slot = "19")]
		public virtual ResourceID[] GetPreloadResourceID()
		{
			return null;
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x25E59D4", Offset = "0x25E59D4", VA = "0x7BBCDE59D4", Slot = "20")]
		public virtual ResourceID[] GetAudioPreloadResourceID()
		{
			return null;
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x25E59DC", Offset = "0x25E59DC", VA = "0x7BBCDE59DC", Slot = "21")]
		public virtual LoadingProcess[] GetLoadingProcesses()
		{
			return null;
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x25E59E4", Offset = "0x25E59E4", VA = "0x7BBCDE59E4", Slot = "22")]
		public virtual void OnLoadingFailed(int expectionProcessIndex)
		{
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D6")]
		[Address(RVA = "0x25E59E8", Offset = "0x25E59E8", VA = "0x7BBCDE59E8", Slot = "23")]
		public virtual void OnLoadingSceneFailed()
		{
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[Token(Token = "0x60034D7")]
		[Address(RVA = "0x25E59EC", Offset = "0x25E59EC", VA = "0x7BBCDE59EC", Slot = "24")]
		public virtual int GetGameType()
		{
			return 0;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x60034D8")]
		[Address(RVA = "0x25E59F4", Offset = "0x25E59F4", VA = "0x7BBCDE59F4", Slot = "25")]
		public virtual int GetSubGameType()
		{
			return 0;
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x60034D9")]
		[Address(RVA = "0x25E59FC", Offset = "0x25E59FC", VA = "0x7BBCDE59FC", Slot = "26")]
		public virtual bool NotUsingAB()
		{
			return default(bool);
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034DA")]
		[Address(RVA = "0x25E5A04", Offset = "0x25E5A04", VA = "0x7BBCDE5A04", Slot = "27")]
		public virtual void SetSceneABInfo(AssetBundle ab, bool useAB, string abPath, string streamPath)
		{
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DB")]
		[Address(RVA = "0x25E5A08", Offset = "0x25E5A08", VA = "0x7BBCDE5A08", Slot = "28")]
		public virtual AssetBundle GetStreamSceneAB()
		{
			return null;
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DC")]
		[Address(RVA = "0x25E5A10", Offset = "0x25E5A10", VA = "0x7BBCDE5A10", Slot = "29")]
		public virtual byte[] GetStreamSceneABTexRefInfo()
		{
			return null;
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x25E5A18", Offset = "0x25E5A18", VA = "0x7BBCDE5A18", Slot = "30")]
		public virtual string GetSceneStreamABPath()
		{
			return null;
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034DE")]
		[Address(RVA = "0x25E5A60", Offset = "0x25E5A60", VA = "0x7BBCDE5A60", Slot = "31")]
		public virtual string GetSceneName()
		{
			return null;
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x0000FE40 File Offset: 0x0000E040
		[Token(Token = "0x60034DF")]
		[Address(RVA = "0x25E5AB0", Offset = "0x25E5AB0", VA = "0x7BBCDE5AB0", Slot = "32")]
		public virtual bool ShouldClearPreloadAssets(Type nextGameType)
		{
			return default(bool);
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E0")]
		[Address(RVA = "0x25E5AB8", Offset = "0x25E5AB8", VA = "0x7BBCDE5AB8", Slot = "33")]
		public virtual void PauseGame(bool v)
		{
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0000FE58 File Offset: 0x0000E058
		[Token(Token = "0x60034E1")]
		[Address(RVA = "0x25E5ABC", Offset = "0x25E5ABC", VA = "0x7BBCDE5ABC", Slot = "34")]
		public virtual bool IsGamePaused()
		{
			return default(bool);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0000FE70 File Offset: 0x0000E070
		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x25E5AC4", Offset = "0x25E5AC4", VA = "0x7BBCDE5AC4", Slot = "35")]
		public virtual bool NeedAimAssist()
		{
			return default(bool);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x25E5ACC", Offset = "0x25E5ACC", VA = "0x7BBCDE5ACC", Slot = "36")]
		public virtual void OnMatchEnd()
		{
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x25E5AD0", Offset = "0x25E5AD0", VA = "0x7BBCDE5AD0", Slot = "37")]
		public virtual void LocalPlayerSelectEquipSet(uint index)
		{
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x25E5AD4", Offset = "0x25E5AD4", VA = "0x7BBCDE5AD4", Slot = "38")]
		public virtual void OnLoadingMaskClosed()
		{
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x25E5AD8", Offset = "0x25E5AD8", VA = "0x7BBCDE5AD8")]
		protected BaseGame()
		{
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x25E5B84", Offset = "0x25E5B84", VA = "0x7BBCDE5B84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113B45C", Offset = "0x113B45C")]
		private void <Init>b__29_0(bool result, int exceptionProcessIndex)
		{
		}

		// Token: 0x04004856 RID: 18518
		[Token(Token = "0x4004856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static Dictionary<uint, IEntityTicker> sTickedEntities;

		// Token: 0x04004857 RID: 18519
		[Token(Token = "0x4004857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static Dictionary<uint, Entity> sAllEntities;

		// Token: 0x04004858 RID: 18520
		[Token(Token = "0x4004858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected UIBaseScene m_UIScene;

		// Token: 0x04004859 RID: 18521
		[Token(Token = "0x4004859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected TimeService m_GameTimer;

		// Token: 0x0400485A RID: 18522
		[Token(Token = "0x400485A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected TimeService m_SimulationTimer;

		// Token: 0x0400485B RID: 18523
		[Token(Token = "0x400485B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected EventDispatcher m_GameEventDispatcher;

		// Token: 0x0400485C RID: 18524
		[Token(Token = "0x400485C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected BaseGameContext m_GameContext;

		// Token: 0x0400485D RID: 18525
		[Token(Token = "0x400485D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected LoadingProcessManager m_LoadingProcessManager;

		// Token: 0x0400485E RID: 18526
		[Token(Token = "0x400485E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected UniqueIDGenerator m_UniqueIDGen;

		// Token: 0x0400485F RID: 18527
		[Token(Token = "0x400485F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Dictionary<uint, TimerAction> m_TimerActions;

		// Token: 0x04004860 RID: 18528
		[Token(Token = "0x4004860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected List<uint> m_ExpiredTimerActions;

		// Token: 0x04004861 RID: 18529
		[Token(Token = "0x4004861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Dictionary<uint, Action> m_TimerActionsToBeCalled;

		// Token: 0x04004862 RID: 18530
		[Token(Token = "0x4004862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_HasInited;

		// Token: 0x04004863 RID: 18531
		[Token(Token = "0x4004863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_HasLoadingFailed;

		// Token: 0x04004864 RID: 18532
		[Token(Token = "0x4004864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool m_HasFixedUpdated;

		// Token: 0x04004865 RID: 18533
		[Token(Token = "0x4004865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool m_SceneLoaded;

		// Token: 0x04004866 RID: 18534
		[Token(Token = "0x4004866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected bool m_IsPaused;

		// Token: 0x02000EDF RID: 3807
		[Token(Token = "0x2000EDF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA3A8", Offset = "0x10EA3A8")]
		private sealed class <OnPreprocessFinished>d__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060034E9 RID: 13545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034E9")]
			[Address(RVA = "0x25E5978", Offset = "0x25E5978", VA = "0x7BBCDE5978")]
			[DebuggerHidden]
			public <OnPreprocessFinished>d__46(int <>1__state)
			{
			}

			// Token: 0x060034EA RID: 13546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034EA")]
			[Address(RVA = "0x25E5BB4", Offset = "0x25E5BB4", VA = "0x7BBCDE5BB4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060034EB RID: 13547 RVA: 0x0000FE88 File Offset: 0x0000E088
			[Token(Token = "0x60034EB")]
			[Address(RVA = "0x25E5BB8", Offset = "0x25E5BB8", VA = "0x7BBCDE5BB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x060034EC RID: 13548 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700069F")]
			private object Current
			{
				[Token(Token = "0x60034EC")]
				[Address(RVA = "0x25E5BF4", Offset = "0x25E5BF4", VA = "0x7BBCDE5BF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060034ED RID: 13549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034ED")]
			[Address(RVA = "0x25E5BFC", Offset = "0x25E5BFC", VA = "0x7BBCDE5BFC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x060034EE RID: 13550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A0")]
			private object Current
			{
				[Token(Token = "0x60034EE")]
				[Address(RVA = "0x25E5C64", Offset = "0x25E5C64", VA = "0x7BBCDE5C64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04004867 RID: 18535
			[Token(Token = "0x4004867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004868 RID: 18536
			[Token(Token = "0x4004868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}
	}
}
