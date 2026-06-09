using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FA RID: 506
[Token(Token = "0x20001FA")]
public class MaterialLOD : MonoBehaviour
{
	// Token: 0x06000A22 RID: 2594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x253DEF8", Offset = "0x253DEF8", VA = "0x7BBCD3DEF8")]
	private void Start()
	{
	}

	// Token: 0x06000A23 RID: 2595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x253E74C", Offset = "0x253E74C", VA = "0x7BBCD3E74C")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000A24 RID: 2596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x253ED6C", Offset = "0x253ED6C", VA = "0x7BBCD3ED6C")]
	public MaterialLOD()
	{
	}

	// Token: 0x04000985 RID: 2437
	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x18")]
	public List<MaterialLOD.MaterialLODInfo> m_materialLODInfoList;

	// Token: 0x04000986 RID: 2438
	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0x20")]
	public List<MaterialLOD.TextureLODInfo> m_textureLODInfoList;

	// Token: 0x04000987 RID: 2439
	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x28")]
	private GGfm}Dt m_quality;

	// Token: 0x020001FB RID: 507
	[Token(Token = "0x20001FB")]
	[Serializable]
	public class TextureLODInfo
	{
		// Token: 0x06000A25 RID: 2597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x253EE9C", Offset = "0x253EE9C", VA = "0x7BBCD3EE9C")]
		public TextureLODInfo()
		{
		}

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x10")]
		public List<Material> m_matList;
	}

	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	[Serializable]
	public class MaterialLODInfo
	{
		// Token: 0x06000A26 RID: 2598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x253EE04", Offset = "0x253EE04", VA = "0x7BBCD3EE04")]
		public MaterialLODInfo()
		{
		}

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x10")]
		public Renderer m_renderer;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x18")]
		public List<int> m_matIDList;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x20")]
		public List<string> m_matNameList;
	}
}
