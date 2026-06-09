using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[Token(Token = "0x20000A9")]
internal class UAVManager : MonoBehaviour
{
	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700002C")]
	public List<BountyWaitingUAV> AllUAV
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1C9730C", Offset = "0x1C9730C", VA = "0x7BBC49730C")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027F")]
	[Address(RVA = "0x1C97314", Offset = "0x1C97314", VA = "0x7BBC497314")]
	private void Awake()
	{
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000280")]
	[Address(RVA = "0x1C973A4", Offset = "0x1C973A4", VA = "0x7BBC4973A4")]
	private void Start()
	{
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x1C97454", Offset = "0x1C97454", VA = "0x7BBC497454")]
	public void StartSpawnUAV()
	{
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x1C97634", Offset = "0x1C97634", VA = "0x7BBC497634")]
	private void SpawnUAV([Optional] BountyWaitingUAV deadUAV)
	{
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x1C978E4", Offset = "0x1C978E4", VA = "0x7BBC4978E4")]
	private void SpawnGroup()
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x1C97B88", Offset = "0x1C97B88", VA = "0x7BBC497B88")]
	public void StopAndKillAllUAV()
	{
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1C97C0C", Offset = "0x1C97C0C", VA = "0x7BBC497C0C")]
	private void OnUAVDead(BountyWaitingUAV deadUAV)
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1C9754C", Offset = "0x1C9754C", VA = "0x7BBC49754C")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11328B0", Offset = "0x11328B0")]
	private IEnumerator SpawnUAVByTime()
	{
		return null;
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1C975C0", Offset = "0x1C975C0", VA = "0x7BBC4975C0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1132914", Offset = "0x1132914")]
	private IEnumerator SpawnGroupUAVByTime()
	{
		return null;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1C97D2C", Offset = "0x1C97D2C", VA = "0x7BBC497D2C")]
	public UAVManager()
	{
	}

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> UAVSpawnPoint;

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Transform> UAVFlyEndPoint;

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Transform> GroupUAVSpawnPoint;

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Transform> GroupUAVEndPoint;

	// Token: 0x04000296 RID: 662
	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int UAVMaxCount;

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject UAVTemplate;

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject UAVGroupTemplate;

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float UAVGroupSpawnDelta;

	// Token: 0x0400029A RID: 666
	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject OilDrumRoot;

	// Token: 0x0400029B RID: 667
	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject NPCRoot;

	// Token: 0x0400029C RID: 668
	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<BountyWaitingUAV> m_AllUAV;

	// Token: 0x0400029D RID: 669
	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool m_IsActive;

	// Token: 0x0400029E RID: 670
	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int newUAVCount;

	// Token: 0x020000AA RID: 170
	[Token(Token = "0x20000AA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1D20", Offset = "0x10E1D20")]
	private sealed class <SpawnUAVByTime>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1C97CD4", Offset = "0x1C97CD4", VA = "0x7BBC497CD4")]
		[DebuggerHidden]
		public <SpawnUAVByTime>d__22(int <>1__state)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1C97EF4", Offset = "0x1C97EF4", VA = "0x7BBC497EF4", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1C97EF8", Offset = "0x1C97EF8", VA = "0x7BBC497EF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		private object Current
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x1C97FB4", Offset = "0x1C97FB4", VA = "0x7BBC497FB4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1C97FBC", Offset = "0x1C97FBC", VA = "0x7BBC497FBC", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		private object Current
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1C98024", Offset = "0x1C98024", VA = "0x7BBC498024", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UAVManager <>4__this;
	}

	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1D30", Offset = "0x10E1D30")]
	private sealed class <SpawnGroupUAVByTime>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1C97D00", Offset = "0x1C97D00", VA = "0x7BBC497D00")]
		[DebuggerHidden]
		public <SpawnGroupUAVByTime>d__23(int <>1__state)
		{
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1C97DA4", Offset = "0x1C97DA4", VA = "0x7BBC497DA4", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1C97DA8", Offset = "0x1C97DA8", VA = "0x7BBC497DA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		private object Current
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x1C97E7C", Offset = "0x1C97E7C", VA = "0x7BBC497E7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1C97E84", Offset = "0x1C97E84", VA = "0x7BBC497E84", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		private object Current
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x1C97EEC", Offset = "0x1C97EEC", VA = "0x7BBC497EEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UAVManager <>4__this;
	}
}
