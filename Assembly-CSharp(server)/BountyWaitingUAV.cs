using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A2 RID: 162
[Token(Token = "0x20000A2")]
internal class BountyWaitingUAV : AttackableEntity
{
	// Token: 0x0600025E RID: 606 RVA: 0x00002508 File Offset: 0x00000708
	[Token(Token = "0x600025E")]
	[Address(RVA = "0x1F96640", Offset = "0x1F96640", VA = "0x7BBC796640", Slot = "22")]
	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025F")]
	[Address(RVA = "0x1F96648", Offset = "0x1F96648", VA = "0x7BBC796648", Slot = "11")]
	protected override void OnAwake()
	{
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000260")]
	[Address(RVA = "0x1F966A0", Offset = "0x1F966A0", VA = "0x7BBC7966A0", Slot = "48")]
	public override void TakeDamage(woZmHkA damageInfo, [Optional] ohSG[ek damagerWeaponDynamicInfo, [Optional] List<float> checkParams, uint vehicleDataID = 0U)
	{
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000261")]
	[Address(RVA = "0x1F8FD14", Offset = "0x1F8FD14", VA = "0x7BBC78FD14")]
	public void SimpleTakeDamage(int damage, int weaponDataID = -1)
	{
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000262")]
	[Address(RVA = "0x1F966F8", Offset = "0x1F966F8", VA = "0x7BBC7966F8")]
	public void OnSpawn(Vector3 spawnPos, Vector3 flyEndPos)
	{
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000263")]
	[Address(RVA = "0x1F96838", Offset = "0x1F96838", VA = "0x7BBC796838")]
	public void Active()
	{
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000264")]
	[Address(RVA = "0x1F96960", Offset = "0x1F96960", VA = "0x7BBC796960", Slot = "52")]
	protected override void OnDead()
	{
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000265")]
	[Address(RVA = "0x1F96D40", Offset = "0x1F96D40", VA = "0x7BBC796D40")]
	private void Update()
	{
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000266")]
	[Address(RVA = "0x1F968EC", Offset = "0x1F968EC", VA = "0x7BBC7968EC")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11327FC", Offset = "0x11327FC")]
	private IEnumerator RandomTakeDamageSelf()
	{
		return null;
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002520 File Offset: 0x00000720
	[Token(Token = "0x6000267")]
	[Address(RVA = "0x1F975F4", Offset = "0x1F975F4", VA = "0x7BBC7975F4")]
	private bool IsDamageSelf()
	{
		return default(bool);
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000268")]
	[Address(RVA = "0x1F96D88", Offset = "0x1F96D88", VA = "0x7BBC796D88")]
	private void UpdateMove()
	{
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000269")]
	[Address(RVA = "0x1F96ED8", Offset = "0x1F96ED8", VA = "0x7BBC796ED8")]
	private void UpdateRandomFire()
	{
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026A")]
	[Address(RVA = "0x1F976C0", Offset = "0x1F976C0", VA = "0x7BBC7976C0")]
	private void ChooseDamageTarget()
	{
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1F97968", Offset = "0x1F97968", VA = "0x7BBC797968")]
	public BountyWaitingUAV()
	{
	}

	// Token: 0x04000273 RID: 627
	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action<BountyWaitingUAV> _OnPostDead;

	// Token: 0x04000274 RID: 628
	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve MoveCurve;

	// Token: 0x04000275 RID: 629
	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int MAXHP;

	// Token: 0x04000276 RID: 630
	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float MAXFlyTime;

	// Token: 0x04000277 RID: 631
	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float SelfTakeDamageRat;

	// Token: 0x04000278 RID: 632
	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int m_HP;

	// Token: 0x04000279 RID: 633
	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform FireEffect;

	// Token: 0x0400027A RID: 634
	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int Damage;

	// Token: 0x0400027B RID: 635
	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float DamageDuration;

	// Token: 0x0400027C RID: 636
	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float ImpactEffectSpawnDuration;

	// Token: 0x0400027D RID: 637
	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float ChangeDamageTargetDuration;

	// Token: 0x0400027E RID: 638
	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool NoRespawn;

	// Token: 0x0400027F RID: 639
	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float m_LastDamageTime;

	// Token: 0x04000280 RID: 640
	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float m_LastChooseDamageTargetTime;

	// Token: 0x04000281 RID: 641
	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool m_IsDamageToLocalPlayer;

	// Token: 0x04000282 RID: 642
	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	private bool m_IsUpdateMove;

	// Token: 0x04000283 RID: 643
	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float m_ActiveTime;

	// Token: 0x04000284 RID: 644
	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Coroutine m_RandomDamgeCor;

	// Token: 0x04000285 RID: 645
	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 m_StartPos;

	// Token: 0x04000286 RID: 646
	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Vector3 m_EndPos;

	// Token: 0x04000287 RID: 647
	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float m_LastHitEffectSpawnTime;

	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1D00", Offset = "0x10E1D00")]
	private sealed class <>c__DisplayClass27_0
	{
		// Token: 0x0600026C RID: 620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1F96D38", Offset = "0x1F96D38", VA = "0x7BBC796D38")]
		public <>c__DisplayClass27_0()
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1F97998", Offset = "0x1F97998", VA = "0x7BBC797998")]
		internal void <OnDead>b__0()
		{
		}

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityEngine.Object ob;
	}

	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x20000A4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1D10", Offset = "0x10E1D10")]
	private sealed class <RandomTakeDamageSelf>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1F975C8", Offset = "0x1F975C8", VA = "0x7BBC7975C8")]
		[DebuggerHidden]
		public <RandomTakeDamageSelf>d__29(int <>1__state)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1F97A90", Offset = "0x1F97A90", VA = "0x7BBC797A90", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1F97A94", Offset = "0x1F97A94", VA = "0x7BBC797A94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		private object Current
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x1F97BC8", Offset = "0x1F97BC8", VA = "0x7BBC797BC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1F97BD0", Offset = "0x1F97BD0", VA = "0x7BBC797BD0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		private object Current
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x1F97C38", Offset = "0x1F97C38", VA = "0x7BBC797C38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000289 RID: 649
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400028A RID: 650
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BountyWaitingUAV <>4__this;
	}
}
