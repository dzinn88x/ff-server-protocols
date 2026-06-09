using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000089 RID: 137
[Token(Token = "0x2000089")]
public class BossRocket : MonoBehaviour
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060001CB RID: 459 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000019")]
	protected Transform CacheTransform
	{
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1F8CF40", Offset = "0x1F8CF40", VA = "0x7BBC78CF40")]
		get
		{
			return null;
		}
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1F8C9C8", Offset = "0x1F8C9C8", VA = "0x7BBC78C9C8", Slot = "4")]
	public virtual void Launch(Vector3 launchPos, Vector3 launchFoward, Vector3 targetPost, [Optional] Transform parent)
	{
	}

	// Token: 0x060001CD RID: 461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1F8D818", Offset = "0x1F8D818", VA = "0x7BBC78D818")]
	public void ActiveWarningZone(BountyWarningZone zone)
	{
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1F8D8B4", Offset = "0x1F8D8B4", VA = "0x7BBC78D8B4", Slot = "5")]
	public virtual void Update()
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1F8CFD0", Offset = "0x1F8CFD0", VA = "0x7BBC78CFD0")]
	protected void Expolde()
	{
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1F8D804", Offset = "0x1F8D804", VA = "0x7BBC78D804")]
	public BossRocket()
	{
	}

	// Token: 0x040001EB RID: 491
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool IsIceRocket;

	// Token: 0x040001EC RID: 492
	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float FreezeTime;

	// Token: 0x040001ED RID: 493
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float MAXSpeed;

	// Token: 0x040001EE RID: 494
	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int Damage;

	// Token: 0x040001EF RID: 495
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float ExplodeRange;

	// Token: 0x040001F0 RID: 496
	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float AccTime;

	// Token: 0x040001F1 RID: 497
	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve SpeedCurve;

	// Token: 0x040001F2 RID: 498
	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve RotCurve;

	// Token: 0x040001F3 RID: 499
	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float RotTime;

	// Token: 0x040001F4 RID: 500
	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string ExplodeEffectResID;

	// Token: 0x040001F5 RID: 501
	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string ExplodeSoundResID;

	// Token: 0x040001F6 RID: 502
	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Vector3 m_TargetPos;

	// Token: 0x040001F7 RID: 503
	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 m_LaunchForward;

	// Token: 0x040001F8 RID: 504
	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected bool m_IsFlying;

	// Token: 0x040001F9 RID: 505
	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float m_BeginLaunchTime;

	// Token: 0x040001FA RID: 506
	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform m_Transform;

	// Token: 0x040001FB RID: 507
	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private BountyWarningZone m_CurWarningZone;

	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1C70", Offset = "0x10E1C70")]
	private sealed class <>c__DisplayClass22_0
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1F8DC7C", Offset = "0x1F8DC7C", VA = "0x7BBC78DC7C")]
		public <>c__DisplayClass22_0()
		{
		}

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ResourceID effectID;
	}

	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1C80", Offset = "0x10E1C80")]
	private sealed class <>c__DisplayClass22_1
	{
		// Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1F8DF50", Offset = "0x1F8DF50", VA = "0x7BBC78DF50")]
		public <>c__DisplayClass22_1()
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1F8E04C", Offset = "0x1F8E04C", VA = "0x7BBC78E04C")]
		internal void <Expolde>b__0()
		{
		}

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject effect;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BossRocket.<>c__DisplayClass22_0 CS$<>8__locals1;
	}
}
