using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000A5 RID: 165
[Token(Token = "0x20000A5")]
public class BountyWarningZone : MonoBehaviour
{
	// Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1F8D854", Offset = "0x1F8D854", VA = "0x7BBC78D854")]
	public void ShowZone(bool isIceZone)
	{
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1F8DF58", Offset = "0x1F8DF58", VA = "0x7BBC78DF58")]
	public void HideZone(bool isIceZone)
	{
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1F97C40", Offset = "0x1F97C40", VA = "0x7BBC797C40")]
	public BountyWarningZone()
	{
	}

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RedZone;

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BlueZone;

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x28")]
	private int m_RedZoneUseCount;

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x2C")]
	private int m_BlueZoneUseCount;
}
