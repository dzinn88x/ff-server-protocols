using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DF RID: 223
[Token(Token = "0x20000DF")]
public class UIHudCommonlTipsController : UIPopupWindowController
{
	// Token: 0x060003E3 RID: 995 RVA: 0x00002A90 File Offset: 0x00000C90
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x1CAA108", Offset = "0x1CAA108", VA = "0x7BBC4AA108")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x1CAA158", Offset = "0x1CAA158", VA = "0x7BBC4AA158", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x1CAA290", Offset = "0x1CAA290", VA = "0x7BBC4AA290", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00002AA8 File Offset: 0x00000CA8
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x1CAA3B0", Offset = "0x1CAA3B0", VA = "0x7BBC4AA3B0", Slot = "34")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00002AC0 File Offset: 0x00000CC0
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x1CAA3B8", Offset = "0x1CAA3B8", VA = "0x7BBC4AA3B8", Slot = "31")]
	public override int MinGroupDepth()
	{
		return 0;
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x1CAA3D4", Offset = "0x1CAA3D4", VA = "0x7BBC4AA3D4")]
	public void SetData(Vector3 itemPos, string descrip, Vector3 offset, EArrowFixedType arrowFixedType = EArrowFixedType.None)
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x1CAA5E0", Offset = "0x1CAA5E0", VA = "0x7BBC4AA5E0")]
	private void _OnClose(params object[] args)
	{
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x1CAA5E8", Offset = "0x1CAA5E8", VA = "0x7BBC4AA5E8")]
	private void OnNavigationPused(params object[] args)
	{
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x1CAA5F0", Offset = "0x1CAA5F0", VA = "0x7BBC4AA5F0")]
	public UIHudCommonlTipsController()
	{
	}

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x98")]
	private UIHudCommonlTipsView m_View;

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0xA0")]
	public Action<UIDetailTipsController> _onClose;
}
