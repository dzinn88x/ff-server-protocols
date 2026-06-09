using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000063 RID: 99
[Token(Token = "0x2000063")]
public class AvatarExtraAmbient : MonoBehaviour
{
	// Token: 0x06000134 RID: 308 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1F8B984", Offset = "0x1F8B984", VA = "0x7BBC78B984")]
	private void OnEnable()
	{
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1F8BA08", Offset = "0x1F8BA08", VA = "0x7BBC78BA08")]
	private void OnValidate()
	{
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1F8B988", Offset = "0x1F8B988", VA = "0x7BBC78B988")]
	private void ApplyAmbient()
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1F8BA68", Offset = "0x1F8BA68", VA = "0x7BBC78BA68")]
	public AvatarExtraAmbient()
	{
	}

	// Token: 0x04000147 RID: 327
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x18")]
	public AvatarExtraAmbient.Part part;

	// Token: 0x04000148 RID: 328
	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x1C")]
	public float ambient;

	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public enum Part
	{
		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		Cloth,
		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		Skin
	}
}
