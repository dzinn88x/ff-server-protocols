using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000090 RID: 144
[Token(Token = "0x2000090")]
public class BountyCutsceneSwitchWeapon : MonoBehaviour
{
	// Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1F8EDEC", Offset = "0x1F8EDEC", VA = "0x7BBC78EDEC")]
	public void InitSlot()
	{
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1F8EE6C", Offset = "0x1F8EE6C", VA = "0x7BBC78EE6C")]
	public Transform FindTransformByName(string name)
	{
		return null;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1F8EFF8", Offset = "0x1F8EFF8", VA = "0x7BBC78EFF8")]
	public void ShowWeaponOnHand(int isShow)
	{
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1F8F318", Offset = "0x1F8F318", VA = "0x7BBC78F318")]
	public void ShowWeaponOnBack(int isShow)
	{
	}

	// Token: 0x060001EC RID: 492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1F8F004", Offset = "0x1F8F004", VA = "0x7BBC78F004")]
	public void ShowWeaponOnHand(bool isShow)
	{
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1F8F324", Offset = "0x1F8F324", VA = "0x7BBC78F324")]
	public void ShowWeaponOnBack(bool isShow)
	{
	}

	// Token: 0x060001EE RID: 494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1F8F638", Offset = "0x1F8F638", VA = "0x7BBC78F638")]
	public BountyCutsceneSwitchWeapon()
	{
	}

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_WeaponOnHand;

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_WeaponOnBack;

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x28")]
	private Transform HandSlot;

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x30")]
	private Transform BackSlot;

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsInited;
}
