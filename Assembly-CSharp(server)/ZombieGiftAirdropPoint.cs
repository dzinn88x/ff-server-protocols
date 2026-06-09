using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000087 RID: 135
[Token(Token = "0x2000087")]
public class ZombieGiftAirdropPoint : MonoBehaviour
{
	// Token: 0x060001C4 RID: 452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x26D55A4", Offset = "0x26D55A4", VA = "0x7BBCED55A4")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x26D5850", Offset = "0x26D5850", VA = "0x7BBCED5850")]
	public ZombieGiftAirdropPoint()
	{
	}

	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x18")]
	public float m_Range;

	// Token: 0x040001E3 RID: 483
	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public float m_Theta;
}
