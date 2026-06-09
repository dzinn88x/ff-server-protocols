using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public class SwitchSceneManager : MonoBehaviour
{
	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000156 RID: 342 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x1700000D")]
	public bool IsSwitching
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2264438", Offset = "0x2264438", VA = "0x7BBCA64438")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000157")]
	[Address(RVA = "0x2264440", Offset = "0x2264440", VA = "0x7BBCA64440")]
	private void Start()
	{
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000158")]
	[Address(RVA = "0x2264558", Offset = "0x2264558", VA = "0x7BBCA64558")]
	public void RegisterLoadCallBack(Action onSwitchFinised)
	{
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000159")]
	[Address(RVA = "0x2264560", Offset = "0x2264560", VA = "0x7BBCA64560")]
	public void SwitchScene(ResourceID targetSceneResID, int needActiveSceneIndex)
	{
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015A")]
	[Address(RVA = "0x22646A8", Offset = "0x22646A8", VA = "0x7BBCA646A8")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1131FE4", Offset = "0x1131FE4")]
	private IEnumerator UnloadScene()
	{
		return null;
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015B")]
	[Address(RVA = "0x226471C", Offset = "0x226471C", VA = "0x7BBCA6471C")]
	private void OnUnloadFinished()
	{
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600015C")]
	[Address(RVA = "0x2264778", Offset = "0x2264778", VA = "0x7BBCA64778")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1132048", Offset = "0x1132048")]
	private IEnumerator LoadScene()
	{
		return null;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015D")]
	[Address(RVA = "0x2264818", Offset = "0x2264818", VA = "0x7BBCA64818")]
	public void UnloadSingleBountyRes()
	{
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015E")]
	[Address(RVA = "0x2264774", Offset = "0x2264774", VA = "0x7BBCA64774")]
	private void PreSwitchScene()
	{
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600015F")]
	[Address(RVA = "0x22648C8", Offset = "0x22648C8", VA = "0x7BBCA648C8")]
	private void OnSceneLoadFinish()
	{
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000160")]
	[Address(RVA = "0x2264908", Offset = "0x2264908", VA = "0x7BBCA64908")]
	public void OverrideLighting(int index = -1)
	{
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000161")]
	[Address(RVA = "0x2264C9C", Offset = "0x2264C9C", VA = "0x7BBCA64C9C")]
	public SwitchSceneManager()
	{
	}

	// Token: 0x04000172 RID: 370
	[Token(Token = "0x4000172")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID m_CurActivedScene;

	// Token: 0x04000173 RID: 371
	[Token(Token = "0x4000173")]
	[FieldOffset(Offset = "0x1C")]
	private ResourceID m_PendingLoadScene;

	// Token: 0x04000174 RID: 372
	[Token(Token = "0x4000174")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsSwitching;

	// Token: 0x04000175 RID: 373
	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x24")]
	public float DelayLoadTime;

	// Token: 0x04000176 RID: 374
	[Token(Token = "0x4000176")]
	[FieldOffset(Offset = "0x28")]
	private int m_NeedActiveSceneIndex;

	// Token: 0x04000177 RID: 375
	[Token(Token = "0x4000177")]
	[FieldOffset(Offset = "0x30")]
	private Action m_OnSwitchFinisedCall;

	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1B4C", Offset = "0x10E1B4C")]
	private sealed class <UnloadScene>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2264748", Offset = "0x2264748", VA = "0x7BBCA64748")]
		[DebuggerHidden]
		public <UnloadScene>d__11(int <>1__state)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2264FC0", Offset = "0x2264FC0", VA = "0x7BBCA64FC0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2264FC4", Offset = "0x2264FC4", VA = "0x7BBCA64FC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		private object Current
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x2265158", Offset = "0x2265158", VA = "0x7BBCA65158", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2265160", Offset = "0x2265160", VA = "0x7BBCA65160", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		private object Current
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x22651C8", Offset = "0x22651C8", VA = "0x7BBCA651C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x20")]
		public SwitchSceneManager <>4__this;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x28")]
		private AsyncOperation <op>5__2;
	}

	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1B5C", Offset = "0x10E1B5C")]
	private sealed class <LoadScene>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x22647EC", Offset = "0x22647EC", VA = "0x7BBCA647EC")]
		[DebuggerHidden]
		public <LoadScene>d__13(int <>1__state)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2264D20", Offset = "0x2264D20", VA = "0x7BBCA64D20", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2264D24", Offset = "0x2264D24", VA = "0x7BBCA64D24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		private object Current
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x2264F48", Offset = "0x2264F48", VA = "0x7BBCA64F48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2264F50", Offset = "0x2264F50", VA = "0x7BBCA64F50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		private object Current
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2264FB8", Offset = "0x2264FB8", VA = "0x7BBCA64FB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x20")]
		public SwitchSceneManager <>4__this;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x28")]
		private AsyncOperation <op>5__2;
	}
}
