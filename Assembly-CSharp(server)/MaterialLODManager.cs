using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FD RID: 509
[Token(Token = "0x20001FD")]
public class MaterialLODManager : MonoSingleton<MaterialLODManager>
{
	// Token: 0x06000A27 RID: 2599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x253EF0C", Offset = "0x253EF0C", VA = "0x7BBCD3EF0C")]
	private void Start()
	{
	}

	// Token: 0x06000A28 RID: 2600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x253E180", Offset = "0x253E180", VA = "0x7BBCD3E180")]
	public void ApplyMaterial(Renderer render, List<int> matIDList, List<string> matNameList)
	{
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x253F19C", Offset = "0x253F19C", VA = "0x7BBCD3F19C")]
	private Material CreateMaterial(string matName)
	{
		return null;
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x253E3CC", Offset = "0x253E3CC", VA = "0x7BBCD3E3CC")]
	public void ApplyTexture(List<Material> matList)
	{
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x253E9F4", Offset = "0x253E9F4", VA = "0x7BBCD3E9F4")]
	public void UnloadMaterial(string matName)
	{
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x253EB38", Offset = "0x253EB38", VA = "0x7BBCD3EB38")]
	public void UnloadTexture(List<Material> matList)
	{
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x253F398", Offset = "0x253F398", VA = "0x7BBCD3F398")]
	public MaterialLODManager()
	{
	}

	// Token: 0x0400098C RID: 2444
	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0x18")]
	public List<MaterialLODManager.TextureLODInfoManager> m_TextureLODList;

	// Token: 0x0400098D RID: 2445
	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, MaterialLODManager.TextureLODInfoManager> m_textureLODDict;

	// Token: 0x0400098E RID: 2446
	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, int> m_loadedMatDict;

	// Token: 0x0400098F RID: 2447
	[Token(Token = "0x400098F")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<string, MaterialLODManager.MaterialLODInfoManager> m_materialLOD;

	// Token: 0x04000990 RID: 2448
	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x38")]
	private string m_materialLODResPath;

	// Token: 0x020001FE RID: 510
	[Token(Token = "0x20001FE")]
	[Serializable]
	public class TextureLODInfoManager
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x228DBB4", Offset = "0x228DBB4", VA = "0x7BBCA8DBB4")]
		public TextureLODInfoManager()
		{
		}

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x10")]
		public string m_matName;

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x18")]
		public List<string> m_texNameList;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x20")]
		public List<string> m_texPathList;
	}

	// Token: 0x020001FF RID: 511
	[Token(Token = "0x20001FF")]
	public class MaterialLODInfoManager
	{
		// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x228DBAC", Offset = "0x228DBAC", VA = "0x7BBCA8DBAC")]
		public MaterialLODInfoManager()
		{
		}

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x10")]
		public Material m_material;

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x18")]
		public int m_refCount;
	}
}
