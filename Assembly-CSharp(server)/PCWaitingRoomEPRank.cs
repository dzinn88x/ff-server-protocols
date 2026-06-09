using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200006B RID: 107
[Token(Token = "0x200006B")]
public class PCWaitingRoomEPRank : MonoBehaviour
{
	// Token: 0x06000147 RID: 327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000147")]
	[Address(RVA = "0x22AB358", Offset = "0x22AB358", VA = "0x7BBCAAB358")]
	public void InitRenderInfo(Transform TextureRoot)
	{
	}

	// Token: 0x06000148 RID: 328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000148")]
	[Address(RVA = "0x22AB7B4", Offset = "0x22AB7B4", VA = "0x7BBCAAB7B4")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000149")]
	[Address(RVA = "0x22AB884", Offset = "0x22AB884", VA = "0x7BBCAAB884")]
	public PCWaitingRoomEPRank()
	{
	}

	// Token: 0x04000160 RID: 352
	[Token(Token = "0x4000160")]
	[FieldOffset(Offset = "0x18")]
	public Camera m_RTCamera;

	// Token: 0x04000161 RID: 353
	[Token(Token = "0x4000161")]
	[FieldOffset(Offset = "0x20")]
	public UITexture m_PCRenderTexture;

	// Token: 0x04000162 RID: 354
	[Token(Token = "0x4000162")]
	[FieldOffset(Offset = "0x28")]
	private RenderTexture m_PCBiliboardRT;
}
