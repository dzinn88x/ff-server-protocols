using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200005E RID: 94
[Token(Token = "0x200005E")]
public class PreviewWsuJumpCgPanelController : MonoBehaviour
{
	// Token: 0x06000114 RID: 276 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000114")]
	[Address(RVA = "0x23CB6BC", Offset = "0x23CB6BC", VA = "0x7BBCBCB6BC")]
	public void SetInterfaceMaskEnable(bool maskVisible, bool labelVisible)
	{
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000115")]
	[Address(RVA = "0x23CB890", Offset = "0x23CB890", VA = "0x7BBCBCB890")]
	protected void Awake()
	{
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000116")]
	[Address(RVA = "0x23CBA00", Offset = "0x23CBA00", VA = "0x7BBCBCBA00")]
	private void OnInterfaceMaskClick()
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000117")]
	[Address(RVA = "0x23CBAF0", Offset = "0x23CBAF0", VA = "0x7BBCBCBAF0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000118")]
	[Address(RVA = "0x23CBAF4", Offset = "0x23CBAF4", VA = "0x7BBCBCBAF4")]
	public PreviewWsuJumpCgPanelController()
	{
	}

	// Token: 0x0400012B RID: 299
	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x18")]
	public UIButton m_InterfaceMask;

	// Token: 0x0400012C RID: 300
	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_InterfaceMaskLabel;

	// Token: 0x0400012D RID: 301
	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x28")]
	public Camera m_CurrentBgCamera;
}
