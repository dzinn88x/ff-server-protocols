using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
public class BountySkipBattle : MonoBehaviour
{
	// Token: 0x06000203 RID: 515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1F90C80", Offset = "0x1F90C80", VA = "0x7BBC790C80")]
	private void Start()
	{
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1F90D34", Offset = "0x1F90D34", VA = "0x7BBC790D34")]
	private void OnEnable()
	{
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1F90D6C", Offset = "0x1F90D6C", VA = "0x7BBC790D6C")]
	public void OnHUDTouch()
	{
	}

	// Token: 0x06000206 RID: 518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1F90EDC", Offset = "0x1F90EDC", VA = "0x7BBC790EDC")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000207 RID: 519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1F90F64", Offset = "0x1F90F64", VA = "0x7BBC790F64")]
	public BountySkipBattle()
	{
	}

	// Token: 0x06000208 RID: 520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1F90F74", Offset = "0x1F90F74", VA = "0x7BBC790F74")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132374", Offset = "0x1132374")]
	private void <OnHUDTouch>b__7_0()
	{
	}

	// Token: 0x0400021B RID: 539
	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SkipBtn;

	// Token: 0x0400021C RID: 540
	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject TipLabel;

	// Token: 0x0400021D RID: 541
	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x28")]
	public float DelayHideTip;

	// Token: 0x0400021E RID: 542
	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsTrigged;

	// Token: 0x0400021F RID: 543
	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x30")]
	private uint m_DelayHandle;
}
