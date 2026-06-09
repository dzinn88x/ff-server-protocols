using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000092 RID: 146
[Token(Token = "0x2000092")]
internal class BountyOilDrum : AttackableEntity
{
	// Token: 0x060001F1 RID: 497 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1F8F7A4", Offset = "0x1F8F7A4", VA = "0x7BBC78F7A4", Slot = "22")]
	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1F8F7AC", Offset = "0x1F8F7AC", VA = "0x7BBC78F7AC", Slot = "48")]
	public override void TakeDamage(woZmHkA damageInfo, [Optional] ohSG[ek damagerWeaponDynamicInfo, [Optional] List<float> checkParams, uint damagerVehicleID = 0U)
	{
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1F8F834", Offset = "0x1F8F834", VA = "0x7BBC78F834")]
	private void Explode()
	{
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1F8FA6C", Offset = "0x1F8FA6C", VA = "0x7BBC78FA6C")]
	public void PlayExplodeEffect()
	{
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1F90088", Offset = "0x1F90088", VA = "0x7BBC790088")]
	public void StopExplodeEfect()
	{
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1F901D0", Offset = "0x1F901D0", VA = "0x7BBC7901D0", Slot = "13")]
	protected override void OnOnDestroy()
	{
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1F901F8", Offset = "0x1F901F8", VA = "0x7BBC7901F8")]
	public BountyOilDrum()
	{
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1F90200", Offset = "0x1F90200", VA = "0x7BBC790200")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132364", Offset = "0x1132364")]
	private void <PlayExplodeEffect>b__7_0()
	{
	}

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int MAXHP;

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int m_CurHP;

	// Token: 0x04000216 RID: 534
	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject m_ExplodeEffectNode;

	// Token: 0x04000217 RID: 535
	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private uint m_DelayCallID;
}
