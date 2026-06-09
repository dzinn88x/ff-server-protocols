using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005A RID: 90
[Token(Token = "0x200005A")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class PrefabLightmapData : MonoBehaviour
{
	// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x23CA9E8", Offset = "0x23CA9E8", VA = "0x7BBCBCA9E8")]
	private void Awake()
	{
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000109")]
	[Address(RVA = "0x23CAC30", Offset = "0x23CAC30", VA = "0x7BBCBCAC30")]
	private static void ApplyRendererInfo(PrefabLightmapData.RendererInfo[] infos, int lightmapOffsetIndex)
	{
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010A")]
	[Address(RVA = "0x23CAD18", Offset = "0x23CAD18", VA = "0x7BBCBCAD18")]
	public PrefabLightmapData()
	{
	}

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private PrefabLightmapData.RendererInfo[] m_RendererInfo;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Texture2D[] m_Lightmaps;

	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	[Serializable]
	private struct RendererInfo
	{
		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x0")]
		public Renderer renderer;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x8")]
		public int lightmapIndex;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0xC")]
		public Vector4 lightmapOffsetScale;
	}
}
