using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005F RID: 95
[Token(Token = "0x200005F")]
public class GhostShadowEffect : MonoBehaviour
{
	// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000119")]
	[Address(RVA = "0x2748BF0", Offset = "0x2748BF0", VA = "0x7BBCF48BF0")]
	public void ReActive()
	{
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2748C28", Offset = "0x2748C28", VA = "0x7BBCF48C28")]
	public void UpdateEffect(float passTime)
	{
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2748E54", Offset = "0x2748E54", VA = "0x7BBCF48E54")]
	public GhostShadowEffect()
	{
	}

	// Token: 0x0400012E RID: 302
	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public float duration;

	// Token: 0x0400012F RID: 303
	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Renderer GhostRenderer;

	// Token: 0x04000130 RID: 304
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Color ghostColor;
}
