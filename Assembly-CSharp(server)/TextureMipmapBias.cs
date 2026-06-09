using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000213 RID: 531
[Token(Token = "0x2000213")]
[ExecuteInEditMode]
public class TextureMipmapBias : MonoBehaviour
{
	// Token: 0x06000A6C RID: 2668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x22655A0", Offset = "0x22655A0", VA = "0x7BBCA655A0")]
	private void Awake()
	{
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x22655F8", Offset = "0x22655F8", VA = "0x7BBCA655F8")]
	public void SetMipmapBias(bool forceUpdate = false)
	{
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x2265878", Offset = "0x2265878", VA = "0x7BBCA65878")]
	public TextureMipmapBias()
	{
	}

	// Token: 0x040009FA RID: 2554
	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x18")]
	public string[] textureNames;

	// Token: 0x040009FB RID: 2555
	[Token(Token = "0x40009FB")]
	[FieldOffset(Offset = "0x20")]
	public bool[] textureMipmapBias;

	// Token: 0x040009FC RID: 2556
	[Token(Token = "0x40009FC")]
	[FieldOffset(Offset = "0x28")]
	private MeshRenderer renderer;
}
