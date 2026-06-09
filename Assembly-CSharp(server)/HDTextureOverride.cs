using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F3 RID: 499
[Token(Token = "0x20001F3")]
[ExecuteInEditMode]
public class HDTextureOverride : MonoBehaviour
{
	// Token: 0x06000A04 RID: 2564 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x2750E7C", Offset = "0x2750E7C", VA = "0x7BBCF50E7C")]
	private void Awake()
	{
	}

	// Token: 0x06000A05 RID: 2565 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x2750ED4", Offset = "0x2750ED4", VA = "0x7BBCF50ED4")]
	public void SetOverrideTextures()
	{
	}

	// Token: 0x06000A06 RID: 2566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x2751314", Offset = "0x2751314", VA = "0x7BBCF51314")]
	public void ResetTextures()
	{
	}

	// Token: 0x06000A07 RID: 2567 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x2751548", Offset = "0x2751548", VA = "0x7BBCF51548")]
	public HDTextureOverride()
	{
	}

	// Token: 0x04000971 RID: 2417
	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x18")]
	public string[] textureNames;

	// Token: 0x04000972 RID: 2418
	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x20")]
	public string[] texturePaths;

	// Token: 0x04000973 RID: 2419
	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x28")]
	private Texture2D[] originalTextures;

	// Token: 0x04000974 RID: 2420
	[Token(Token = "0x4000974")]
	[FieldOffset(Offset = "0x30")]
	private MeshRenderer renderer;
}
