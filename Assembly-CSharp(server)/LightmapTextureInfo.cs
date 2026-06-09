using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F4 RID: 500
[Token(Token = "0x20001F4")]
[ExecuteInEditMode]
public class LightmapTextureInfo : MonoBehaviour
{
	// Token: 0x06000A08 RID: 2568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x2522230", Offset = "0x2522230", VA = "0x7BBCD22230")]
	private void Awake()
	{
	}

	// Token: 0x06000A09 RID: 2569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x2522334", Offset = "0x2522334", VA = "0x7BBCD22334")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A0A RID: 2570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x2522438", Offset = "0x2522438", VA = "0x7BBCD22438")]
	public LightmapTextureInfo()
	{
	}

	// Token: 0x04000975 RID: 2421
	[Token(Token = "0x4000975")]
	[FieldOffset(Offset = "0x18")]
	public int lightmapOffset;

	// Token: 0x04000976 RID: 2422
	[Token(Token = "0x4000976")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D[] lightmaps;

	// Token: 0x04000977 RID: 2423
	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D[] shadowmasks;
}
