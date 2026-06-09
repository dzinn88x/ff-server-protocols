using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000047 RID: 71
[Token(Token = "0x2000047")]
public class PlayerNameIcon : MonoBehaviour
{
	// Token: 0x060000CB RID: 203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x23C2854", Offset = "0x23C2854", VA = "0x7BBCBC2854")]
	private void Awake()
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x23C2888", Offset = "0x23C2888", VA = "0x7BBCBC2888")]
	public void ChangeToWolf()
	{
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x23C28BC", Offset = "0x23C28BC", VA = "0x7BBCBC28BC")]
	public void ChangeNumber(int showNumber)
	{
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x23C2998", Offset = "0x23C2998", VA = "0x7BBCBC2998")]
	public void ChangeToDead()
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x23C299C", Offset = "0x23C299C", VA = "0x7BBCBC299C")]
	private void Update()
	{
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x23C2AE8", Offset = "0x23C2AE8", VA = "0x7BBCBC2AE8")]
	public PlayerNameIcon()
	{
	}

	// Token: 0x040000FB RID: 251
	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x18")]
	public Transform ShowRoot;

	// Token: 0x040000FC RID: 252
	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NumberMesh;

	// Token: 0x040000FD RID: 253
	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_IsWolf;

	// Token: 0x040000FE RID: 254
	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x30")]
	public List<Texture> NumberTextureConfigs;
}
