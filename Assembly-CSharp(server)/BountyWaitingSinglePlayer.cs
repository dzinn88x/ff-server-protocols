using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009F RID: 159
[Token(Token = "0x200009F")]
internal class BountyWaitingSinglePlayer : Player
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x06000249 RID: 585 RVA: 0x000024C0 File Offset: 0x000006C0
	[Token(Token = "0x17000025")]
	private int LockHP
	{
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1F95E04", Offset = "0x1F95E04", VA = "0x7BBC795E04")]
		get
		{
			return 0;
		}
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024A")]
	[Address(RVA = "0x1F95E0C", Offset = "0x1F95E0C", VA = "0x7BBC795E0C", Slot = "48")]
	public override void TakeDamage(woZmHkA damageInfo, [Optional] ohSG[ek damagerWeaponDynamicInfo, [Optional] List<float> checkParams, uint damagerVehicleID = 0U)
	{
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024B")]
	[Address(RVA = "0x1F8DC84", Offset = "0x1F8DC84", VA = "0x7BBC78DC84")]
	public void TakeFreezeDamage(float freezeTime)
	{
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024C")]
	[Address(RVA = "0x1F95F5C", Offset = "0x1F95F5C", VA = "0x7BBC795F5C")]
	private void StopFreeze()
	{
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600024D")]
	[Address(RVA = "0x1F95EE8", Offset = "0x1F95EE8", VA = "0x7BBC795EE8")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1132694", Offset = "0x1132694")]
	private IEnumerator CalcuFreeze()
	{
		return null;
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024E")]
	[Address(RVA = "0x1F960AC", Offset = "0x1F960AC", VA = "0x7BBC7960AC")]
	private void Update()
	{
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600024F")]
	[Address(RVA = "0x1F961AC", Offset = "0x1F961AC", VA = "0x7BBC7961AC", Slot = "52")]
	protected override void OnDead()
	{
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000250")]
	[Address(RVA = "0x1F96138", Offset = "0x1F96138", VA = "0x7BBC796138")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11326F8", Offset = "0x11326F8")]
	private IEnumerator CoroutineUpdateHealing()
	{
		return null;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000251")]
	[Address(RVA = "0x1F96214", Offset = "0x1F96214", VA = "0x7BBC796214")]
	public BountyWaitingSinglePlayer()
	{
	}

	// Token: 0x04000267 RID: 615
	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAE8")]
	private bool m_IsInFreeze;

	// Token: 0x04000268 RID: 616
	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAEC")]
	private float m_FreezeTime;

	// Token: 0x04000269 RID: 617
	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAF0")]
	private Coroutine m_FreezeCoroutine;

	// Token: 0x0400026A RID: 618
	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAF8")]
	private float m_LastTakeDamageTime;

	// Token: 0x0400026B RID: 619
	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB00")]
	private GameObject m_FreezeEffect;

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB08")]
	private Coroutine m_HealingCoroutine;

	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1CE0", Offset = "0x10E1CE0")]
	private sealed class <CalcuFreeze>d__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1F96080", Offset = "0x1F96080", VA = "0x7BBC796080")]
		[DebuggerHidden]
		public <CalcuFreeze>d__10(int <>1__state)
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1F9627C", Offset = "0x1F9627C", VA = "0x7BBC79627C", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1F96280", Offset = "0x1F96280", VA = "0x7BBC796280", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		private object Current
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x1F96344", Offset = "0x1F96344", VA = "0x7BBC796344", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1F9634C", Offset = "0x1F9634C", VA = "0x7BBC79634C", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		private object Current
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x1F963B4", Offset = "0x1F963B4", VA = "0x7BBC7963B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BountyWaitingSinglePlayer <>4__this;
	}

	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1CF0", Offset = "0x10E1CF0")]
	private sealed class <CoroutineUpdateHealing>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000258 RID: 600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1F961E8", Offset = "0x1F961E8", VA = "0x7BBC7961E8")]
		[DebuggerHidden]
		public <CoroutineUpdateHealing>d__14(int <>1__state)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1F963BC", Offset = "0x1F963BC", VA = "0x7BBC7963BC", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1F963C0", Offset = "0x1F963C0", VA = "0x7BBC7963C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		private object Current
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x1F965C8", Offset = "0x1F965C8", VA = "0x7BBC7965C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1F965D0", Offset = "0x1F965D0", VA = "0x7BBC7965D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		private object Current
		{
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x1F96638", Offset = "0x1F96638", VA = "0x7BBC796638", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BountyWaitingSinglePlayer <>4__this;
	}
}
