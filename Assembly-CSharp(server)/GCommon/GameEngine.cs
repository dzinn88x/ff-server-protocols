using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000EE1 RID: 3809
	[Token(Token = "0x2000EE1")]
	internal class GameEngine : MonoBehaviour
	{
		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[Token(Token = "0x170006A2")]
		public float LoadingPreloadedResourceProgress
		{
			[Token(Token = "0x60034F6")]
			[Address(RVA = "0x2116110", Offset = "0x2116110", VA = "0x7BBC916110")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060034F7 RID: 13559 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[Token(Token = "0x170006A3")]
		public float LoadingPendingGameProgress
		{
			[Token(Token = "0x60034F7")]
			[Address(RVA = "0x2116118", Offset = "0x2116118", VA = "0x7BBC916118")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A4")]
		public TimeService EngineTimer
		{
			[Token(Token = "0x60034F8")]
			[Address(RVA = "0x2116120", Offset = "0x2116120", VA = "0x7BBC916120")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060034F9 RID: 13561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006A5")]
		public Type PendingGameType
		{
			[Token(Token = "0x60034F9")]
			[Address(RVA = "0x2116128", Offset = "0x2116128", VA = "0x7BBC916128")]
			get
			{
				return null;
			}
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x2116130", Offset = "0x2116130", VA = "0x7BBC916130")]
		private void Awake()
		{
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x21161D0", Offset = "0x21161D0", VA = "0x7BBC9161D0")]
		public BaseGame GetCurrentGame()
		{
			return null;
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x21161D8", Offset = "0x21161D8", VA = "0x7BBC9161D8")]
		public void SetLoadingSceneResourceID(ResourceID id)
		{
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x21161E0", Offset = "0x21161E0", VA = "0x7BBC9161E0")]
		public uint DelayCall(float delayTime, Action action, bool isRepeated = false)
		{
			return 0U;
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x2116354", Offset = "0x2116354", VA = "0x7BBC916354")]
		public void CancelDelayCall(uint id)
		{
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x2116458", Offset = "0x2116458", VA = "0x7BBC916458")]
		public void RunOneFrame()
		{
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x21171A8", Offset = "0x21171A8", VA = "0x7BBC9171A8")]
		public void FixedRunOneFrame()
		{
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x21171BC", Offset = "0x21171BC", VA = "0x7BBC9171BC")]
		public float GetEngineTime()
		{
			return 0f;
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x6003502")]
		[Address(RVA = "0x21171EC", Offset = "0x21171EC", VA = "0x7BBC9171EC")]
		public bool LoadAndRun(Type gameType, [Optional] BaseGameContext sharedData, bool useAdditiveLoading = false, [Optional] Action OnFinished)
		{
			return default(bool);
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003503")]
		[Address(RVA = "0x2117560", Offset = "0x2117560", VA = "0x7BBC917560")]
		private void AfterCleanAssets()
		{
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003504")]
		[Address(RVA = "0x211768C", Offset = "0x211768C", VA = "0x7BBC91768C")]
		public void LoadPendingGame()
		{
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003505")]
		[Address(RVA = "0x21178C4", Offset = "0x21178C4", VA = "0x7BBC9178C4")]
		public void LoadPreloadResource()
		{
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003506")]
		public void LoadAndRun<T>([Optional] BaseGameContext sharedData, bool useAdditiveLoading = false, [Optional] Action onFinished) where T : BaseGame, new()
		{
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x21174C4", Offset = "0x21174C4", VA = "0x7BBC9174C4")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113B4DC", Offset = "0x113B4DC")]
		private IEnumerator CleanAssets(bool shouldCleanPreloadResources)
		{
			return null;
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003508")]
		[Address(RVA = "0x2117618", Offset = "0x2117618", VA = "0x7BBC917618")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113B540", Offset = "0x113B540")]
		private IEnumerator LoadLoadingScene()
		{
			return null;
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x2117908", Offset = "0x2117908", VA = "0x7BBC917908")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113B5A4", Offset = "0x113B5A4")]
		private IEnumerator LoadPreloadResource(BaseGame game)
		{
			return null;
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350A")]
		[Address(RVA = "0x211782C", Offset = "0x211782C", VA = "0x7BBC91782C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113B608", Offset = "0x113B608")]
		private IEnumerator LoadGameProcess(BaseGame game)
		{
			return null;
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350B")]
		[Address(RVA = "0x2117A50", Offset = "0x2117A50", VA = "0x7BBC917A50")]
		public GameEngine()
		{
		}

		// Token: 0x0400486B RID: 18539
		[Token(Token = "0x400486B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GameEngine instance;

		// Token: 0x0400486C RID: 18540
		[Token(Token = "0x400486C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ObjectPool<TimerAction> GlobalTimerActionPool;

		// Token: 0x0400486D RID: 18541
		[Token(Token = "0x400486D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BaseGame m_CurrentGame;

		// Token: 0x0400486E RID: 18542
		[Token(Token = "0x400486E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TimeService m_EngineTimer;

		// Token: 0x0400486F RID: 18543
		[Token(Token = "0x400486F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ResourceID m_LoadingSceneResourceID;

		// Token: 0x04004870 RID: 18544
		[Token(Token = "0x4004870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type m_PendingGameType;

		// Token: 0x04004871 RID: 18545
		[Token(Token = "0x4004871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BaseGameContext m_PendingGameContext;

		// Token: 0x04004872 RID: 18546
		[Token(Token = "0x4004872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_LoadingPreloadedResourceProgress;

		// Token: 0x04004873 RID: 18547
		[Token(Token = "0x4004873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_LoadingInProcess;

		// Token: 0x04004874 RID: 18548
		[Token(Token = "0x4004874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool m_UseAdditiveLoading;

		// Token: 0x04004875 RID: 18549
		[Token(Token = "0x4004875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Action m_OnLoadAndRunFinished;

		// Token: 0x04004876 RID: 18550
		[Token(Token = "0x4004876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UniqueIDGenerator m_UniqueIDGen;

		// Token: 0x04004877 RID: 18551
		[Token(Token = "0x4004877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<uint, TimerAction> m_TimerActions;

		// Token: 0x04004878 RID: 18552
		[Token(Token = "0x4004878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<uint> m_ExpiredTimerActions;

		// Token: 0x04004879 RID: 18553
		[Token(Token = "0x4004879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<uint, Action> m_TimerActionsToBeCalled;

		// Token: 0x0400487A RID: 18554
		[Token(Token = "0x400487A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<string, string> BugReportSetKeyValue;

		// Token: 0x0400487B RID: 18555
		[Token(Token = "0x400487B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_LoadingPendingGameProgress;

		// Token: 0x02000EE2 RID: 3810
		[Token(Token = "0x2000EE2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA3B8", Offset = "0x10EA3B8")]
		private sealed class <CleanAssets>d__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600350D RID: 13581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600350D")]
			[Address(RVA = "0x21179A0", Offset = "0x21179A0", VA = "0x7BBC9179A0")]
			[DebuggerHidden]
			public <CleanAssets>d__38(int <>1__state)
			{
			}

			// Token: 0x0600350E RID: 13582 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600350E")]
			[Address(RVA = "0x2117BD4", Offset = "0x2117BD4", VA = "0x7BBC917BD4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600350F RID: 13583 RVA: 0x0000FF18 File Offset: 0x0000E118
			[Token(Token = "0x600350F")]
			[Address(RVA = "0x2117BD8", Offset = "0x2117BD8", VA = "0x7BBC917BD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06003510 RID: 13584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A6")]
			private object Current
			{
				[Token(Token = "0x6003510")]
				[Address(RVA = "0x2117EB4", Offset = "0x2117EB4", VA = "0x7BBC917EB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06003511 RID: 13585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003511")]
			[Address(RVA = "0x2117EBC", Offset = "0x2117EBC", VA = "0x7BBC917EBC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06003512 RID: 13586 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A7")]
			private object Current
			{
				[Token(Token = "0x6003512")]
				[Address(RVA = "0x2117F24", Offset = "0x2117F24", VA = "0x7BBC917F24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400487C RID: 18556
			[Token(Token = "0x400487C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400487D RID: 18557
			[Token(Token = "0x400487D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400487E RID: 18558
			[Token(Token = "0x400487E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool shouldCleanPreloadResources;

			// Token: 0x0400487F RID: 18559
			[Token(Token = "0x400487F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameEngine <>4__this;
		}

		// Token: 0x02000EE3 RID: 3811
		[Token(Token = "0x2000EE3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA3C8", Offset = "0x10EA3C8")]
		private sealed class <LoadLoadingScene>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06003513 RID: 13587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003513")]
			[Address(RVA = "0x21179CC", Offset = "0x21179CC", VA = "0x7BBC9179CC")]
			[DebuggerHidden]
			public <LoadLoadingScene>d__39(int <>1__state)
			{
			}

			// Token: 0x06003514 RID: 13588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003514")]
			[Address(RVA = "0x2118AE4", Offset = "0x2118AE4", VA = "0x7BBC918AE4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06003515 RID: 13589 RVA: 0x0000FF30 File Offset: 0x0000E130
			[Token(Token = "0x6003515")]
			[Address(RVA = "0x2118AE8", Offset = "0x2118AE8", VA = "0x7BBC918AE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x06003516 RID: 13590 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A8")]
			private object Current
			{
				[Token(Token = "0x6003516")]
				[Address(RVA = "0x2118FD4", Offset = "0x2118FD4", VA = "0x7BBC918FD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06003517 RID: 13591 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003517")]
			[Address(RVA = "0x2118FDC", Offset = "0x2118FDC", VA = "0x7BBC918FDC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170006A9 RID: 1705
			// (get) Token: 0x06003518 RID: 13592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A9")]
			private object Current
			{
				[Token(Token = "0x6003518")]
				[Address(RVA = "0x2119044", Offset = "0x2119044", VA = "0x7BBC919044", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04004880 RID: 18560
			[Token(Token = "0x4004880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004881 RID: 18561
			[Token(Token = "0x4004881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004882 RID: 18562
			[Token(Token = "0x4004882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameEngine <>4__this;
		}

		// Token: 0x02000EE4 RID: 3812
		[Token(Token = "0x2000EE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA3D8", Offset = "0x10EA3D8")]
		private sealed class <LoadPreloadResource>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06003519 RID: 13593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003519")]
			[Address(RVA = "0x21179F8", Offset = "0x21179F8", VA = "0x7BBC9179F8")]
			[DebuggerHidden]
			public <LoadPreloadResource>d__40(int <>1__state)
			{
			}

			// Token: 0x0600351A RID: 13594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600351A")]
			[Address(RVA = "0x211904C", Offset = "0x211904C", VA = "0x7BBC91904C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600351B RID: 13595 RVA: 0x0000FF48 File Offset: 0x0000E148
			[Token(Token = "0x600351B")]
			[Address(RVA = "0x2119050", Offset = "0x2119050", VA = "0x7BBC919050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170006AA RID: 1706
			// (get) Token: 0x0600351C RID: 13596 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AA")]
			private object Current
			{
				[Token(Token = "0x600351C")]
				[Address(RVA = "0x2119650", Offset = "0x2119650", VA = "0x7BBC919650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600351D RID: 13597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600351D")]
			[Address(RVA = "0x2119658", Offset = "0x2119658", VA = "0x7BBC919658", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170006AB RID: 1707
			// (get) Token: 0x0600351E RID: 13598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AB")]
			private object Current
			{
				[Token(Token = "0x600351E")]
				[Address(RVA = "0x21196C0", Offset = "0x21196C0", VA = "0x7BBC9196C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04004883 RID: 18563
			[Token(Token = "0x4004883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04004884 RID: 18564
			[Token(Token = "0x4004884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04004885 RID: 18565
			[Token(Token = "0x4004885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseGame game;

			// Token: 0x04004886 RID: 18566
			[Token(Token = "0x4004886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameEngine <>4__this;

			// Token: 0x04004887 RID: 18567
			[Token(Token = "0x4004887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <time>5__2;

			// Token: 0x04004888 RID: 18568
			[Token(Token = "0x4004888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ResourceID[] <audio_preloadedResource>5__3;

			// Token: 0x04004889 RID: 18569
			[Token(Token = "0x4004889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <preload_count>5__4;

			// Token: 0x0400488A RID: 18570
			[Token(Token = "0x400488A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private int <loadedCount>5__5;

			// Token: 0x0400488B RID: 18571
			[Token(Token = "0x400488B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceID[] <>7__wrap5;

			// Token: 0x0400488C RID: 18572
			[Token(Token = "0x400488C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int <>7__wrap6;
		}

		// Token: 0x02000EE5 RID: 3813
		[Token(Token = "0x2000EE5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA3E8", Offset = "0x10EA3E8")]
		private sealed class <LoadGameProcess>d__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600351F RID: 13599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600351F")]
			[Address(RVA = "0x2117A24", Offset = "0x2117A24", VA = "0x7BBC917A24")]
			[DebuggerHidden]
			public <LoadGameProcess>d__41(int <>1__state)
			{
			}

			// Token: 0x06003520 RID: 13600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003520")]
			[Address(RVA = "0x2117F2C", Offset = "0x2117F2C", VA = "0x7BBC917F2C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06003521 RID: 13601 RVA: 0x0000FF60 File Offset: 0x0000E160
			[Token(Token = "0x6003521")]
			[Address(RVA = "0x2117F30", Offset = "0x2117F30", VA = "0x7BBC917F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170006AC RID: 1708
			// (get) Token: 0x06003522 RID: 13602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AC")]
			private object Current
			{
				[Token(Token = "0x6003522")]
				[Address(RVA = "0x2118A6C", Offset = "0x2118A6C", VA = "0x7BBC918A6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06003523 RID: 13603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003523")]
			[Address(RVA = "0x2118A74", Offset = "0x2118A74", VA = "0x7BBC918A74", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170006AD RID: 1709
			// (get) Token: 0x06003524 RID: 13604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006AD")]
			private object Current
			{
				[Token(Token = "0x6003524")]
				[Address(RVA = "0x2118ADC", Offset = "0x2118ADC", VA = "0x7BBC918ADC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400488D RID: 18573
			[Token(Token = "0x400488D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400488E RID: 18574
			[Token(Token = "0x400488E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400488F RID: 18575
			[Token(Token = "0x400488F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BaseGame game;

			// Token: 0x04004890 RID: 18576
			[Token(Token = "0x4004890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameEngine <>4__this;

			// Token: 0x04004891 RID: 18577
			[Token(Token = "0x4004891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ResourceID[] <sceneList>5__2;

			// Token: 0x04004892 RID: 18578
			[Token(Token = "0x4004892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__3;

			// Token: 0x04004893 RID: 18579
			[Token(Token = "0x4004893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private AsyncOperation <sceneLoadState>5__4;
		}
	}
}
