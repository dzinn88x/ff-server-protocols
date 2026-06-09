using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200009B RID: 155
[Token(Token = "0x200009B")]
internal class BountyWaitingBoss : AttackableEntity
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000227 RID: 551 RVA: 0x00002460 File Offset: 0x00000660
	// (set) Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000020")]
	private int CurHP
	{
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1F92104", Offset = "0x1F92104", VA = "0x7BBC792104")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1F9210C", Offset = "0x1F9210C", VA = "0x7BBC79210C")]
		set
		{
		}
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000229")]
	[Address(RVA = "0x1F927B8", Offset = "0x1F927B8", VA = "0x7BBC7927B8", Slot = "11")]
	protected override void OnAwake()
	{
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1F928E8", Offset = "0x1F928E8", VA = "0x7BBC7928E8")]
	private void ActiveShiled(bool isActive)
	{
	}

	// Token: 0x0600022B RID: 555 RVA: 0x00002478 File Offset: 0x00000678
	[Token(Token = "0x600022B")]
	[Address(RVA = "0x1F92950", Offset = "0x1F92950", VA = "0x7BBC792950", Slot = "22")]
	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022C")]
	[Address(RVA = "0x1F92958", Offset = "0x1F92958", VA = "0x7BBC792958")]
	public void Active()
	{
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022D")]
	[Address(RVA = "0x1F92CE4", Offset = "0x1F92CE4", VA = "0x7BBC792CE4")]
	private void ChangeMaterialColor(Color color)
	{
	}

	// Token: 0x0600022E RID: 558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022E")]
	[Address(RVA = "0x1F92F20", Offset = "0x1F92F20", VA = "0x7BBC792F20", Slot = "48")]
	public override void TakeDamage(woZmHkA damageInfo, [Optional] ohSG[ek damagerWeaponDynamicInfo, [Optional] List<float> checkParams, uint vehicleDataID = 0U)
	{
	}

	// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600022F")]
	[Address(RVA = "0x1F92F90", Offset = "0x1F92F90", VA = "0x7BBC792F90")]
	public void SimpleTakeDamage(int damage, int weaponDataID = -1, TNugLVg hitColliderType = TNugLVg.UAV)
	{
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000230")]
	[Address(RVA = "0x1F93424", Offset = "0x1F93424", VA = "0x7BBC793424", Slot = "52")]
	protected override void OnDead()
	{
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000231")]
	[Address(RVA = "0x1F92180", Offset = "0x1F92180", VA = "0x7BBC792180")]
	private void EndCurPhase()
	{
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000232")]
	[Address(RVA = "0x1F92184", Offset = "0x1F92184", VA = "0x7BBC792184")]
	private void GotoNextPhase()
	{
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000233")]
	[Address(RVA = "0x1F92EAC", Offset = "0x1F92EAC", VA = "0x7BBC792EAC")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11324EC", Offset = "0x11324EC")]
	private IEnumerator SelfTakeDamage()
	{
		return null;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000234")]
	[Address(RVA = "0x1F92C70", Offset = "0x1F92C70", VA = "0x7BBC792C70")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1132550", Offset = "0x1132550")]
	private IEnumerator AttackUpdate()
	{
		return null;
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000235")]
	[Address(RVA = "0x1F93484", Offset = "0x1F93484", VA = "0x7BBC793484")]
	private void Fire(List<BossRocketLauncher> launcers, GameObject rocketTemplate)
	{
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000236")]
	[Address(RVA = "0x1F93808", Offset = "0x1F93808", VA = "0x7BBC793808")]
	public void DebugFire()
	{
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000237")]
	[Address(RVA = "0x1F93878", Offset = "0x1F93878", VA = "0x7BBC793878")]
	public void ResetBoss()
	{
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x1F938B0", Offset = "0x1F938B0", VA = "0x7BBC7938B0")]
	public BountyWaitingBoss()
	{
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x1F9397C", Offset = "0x1F9397C", VA = "0x7BBC79397C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11325B4", Offset = "0x11325B4")]
	private void <Active>b__36_0()
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x1F9398C", Offset = "0x1F9398C", VA = "0x7BBC79398C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11325C4", Offset = "0x11325C4")]
	private void <GotoNextPhase>b__42_0()
	{
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023B")]
	[Address(RVA = "0x1F939CC", Offset = "0x1F939CC", VA = "0x7BBC7939CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11325D4", Offset = "0x11325D4")]
	private void <GotoNextPhase>b__42_1()
	{
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x1F93A0C", Offset = "0x1F93A0C", VA = "0x7BBC793A0C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11325E4", Offset = "0x11325E4")]
	private void <GotoNextPhase>b__42_2()
	{
	}

	// Token: 0x0400023F RID: 575
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material PhaseMaterial;

	// Token: 0x04000240 RID: 576
	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Color> PhaseColor;

	// Token: 0x04000241 RID: 577
	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject NPCRoot;

	// Token: 0x04000242 RID: 578
	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject BossMeshRoot;

	// Token: 0x04000243 RID: 579
	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform CoreTransform;

	// Token: 0x04000244 RID: 580
	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject ShiledEffectRoot;

	// Token: 0x04000245 RID: 581
	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject CoreEffectRoot;

	// Token: 0x04000246 RID: 582
	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject PhaseSwtichBodyEffectRoot;

	// Token: 0x04000247 RID: 583
	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Animator BossAnimator;

	// Token: 0x04000248 RID: 584
	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int MAXHP;

	// Token: 0x04000249 RID: 585
	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float SecondPhaseBeginHPRat;

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float ThirdPhaseBeginHPRat;

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float FourthPhaseBeginHPRat;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float BaseAttackDelta;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public BossRocket RocketTemplate;

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<BossRocketLauncher> RocketLauncher;

	// Token: 0x0400024F RID: 591
	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFD04", Offset = "0x10FFD04")]
	public BossRocket CannonTemplate;

	// Token: 0x04000250 RID: 592
	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<BossRocketLauncher> CannonLauncher;

	// Token: 0x04000251 RID: 593
	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x10FFD3C", Offset = "0x10FFD3C")]
	public float BossSelfDamageHPRate;

	// Token: 0x04000252 RID: 594
	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float NormalDamageHPRate;

	// Token: 0x04000253 RID: 595
	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float WeakPointDamageHPRate;

	// Token: 0x04000254 RID: 596
	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private BountyWaitingBoss.BOSSHPPhase m_CurPhase;

	// Token: 0x04000255 RID: 597
	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int m_CurHP;

	// Token: 0x04000256 RID: 598
	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Coroutine m_AttackCoroutine;

	// Token: 0x04000257 RID: 599
	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float m_CurBaseAttackDelta;

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private bool m_IsRokcetAttackPhase;

	// Token: 0x04000259 RID: 601
	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
	private bool m_IsCannonAttackPhase;

	// Token: 0x0400025A RID: 602
	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private LineRenderer[] m_LightEffects;

	// Token: 0x0400025B RID: 603
	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool m_IsGod;

	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	private enum BOSSHPPhase
	{
		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		Phase_First = 1,
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		Phase_Second,
		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		Phase_Third,
		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		Phase_Fourth
	}

	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1CC0", Offset = "0x10E1CC0")]
	private sealed class <SelfTakeDamage>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1F9342C", Offset = "0x1F9342C", VA = "0x7BBC79342C")]
		[DebuggerHidden]
		public <SelfTakeDamage>d__43(int <>1__state)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x1F93D34", Offset = "0x1F93D34", VA = "0x7BBC793D34", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x1F93D38", Offset = "0x1F93D38", VA = "0x7BBC793D38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		private object Current
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1F93E88", Offset = "0x1F93E88", VA = "0x7BBC793E88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1F93E90", Offset = "0x1F93E90", VA = "0x7BBC793E90", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		private object Current
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x1F93EF8", Offset = "0x1F93EF8", VA = "0x7BBC793EF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BountyWaitingBoss <>4__this;
	}

	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1CD0", Offset = "0x10E1CD0")]
	private sealed class <AttackUpdate>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06000243 RID: 579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x1F93458", Offset = "0x1F93458", VA = "0x7BBC793458")]
		[DebuggerHidden]
		public <AttackUpdate>d__44(int <>1__state)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1F93A48", Offset = "0x1F93A48", VA = "0x7BBC793A48", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1F93A4C", Offset = "0x1F93A4C", VA = "0x7BBC793A4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		private object Current
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x1F93CBC", Offset = "0x1F93CBC", VA = "0x7BBC793CBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1F93CC4", Offset = "0x1F93CC4", VA = "0x7BBC793CC4", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		private object Current
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x1F93D2C", Offset = "0x1F93D2C", VA = "0x7BBC793D2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BountyWaitingBoss <>4__this;
	}
}
