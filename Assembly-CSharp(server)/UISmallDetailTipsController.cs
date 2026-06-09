using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E0 RID: 224
[Token(Token = "0x20000E0")]
public class UISmallDetailTipsController : UIPopupWindowController
{
	// Token: 0x060003EC RID: 1004 RVA: 0x00002AD8 File Offset: 0x00000CD8
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x1FCDF74", Offset = "0x1FCDF74", VA = "0x7BBC7CDF74")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1FCDFC4", Offset = "0x1FCDFC4", VA = "0x7BBC7CDFC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x1FCE230", Offset = "0x1FCE230", VA = "0x7BBC7CE230", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00002AF0 File Offset: 0x00000CF0
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x1FCE350", Offset = "0x1FCE350", VA = "0x7BBC7CE350", Slot = "34")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00002B08 File Offset: 0x00000D08
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x1FCE358", Offset = "0x1FCE358", VA = "0x7BBC7CE358", Slot = "31")]
	public override int MinGroupDepth()
	{
		return 0;
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x1FCE374", Offset = "0x1FCE374", VA = "0x7BBC7CE374")]
	public void SetData(Vector3 itemPos, BaseItemInfo info)
	{
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x1FCE438", Offset = "0x1FCE438", VA = "0x7BBC7CE438")]
	public void SetData(Vector3 itemPos, BaseItemInfo info, string name, string descrip, Vector3 offset, TipsBtnInfo[] btn_info_list, bool use_collider, EArrowFixedType arrowFixedType)
	{
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x1FCF3BC", Offset = "0x1FCF3BC", VA = "0x7BBC7CF3BC")]
	private void OnConfirmClick()
	{
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x1FCF41C", Offset = "0x1FCF41C", VA = "0x7BBC7CF41C")]
	private void OnCancleClick()
	{
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x1FCF408", Offset = "0x1FCF408", VA = "0x7BBC7CF408")]
	private void CloseWithCollider()
	{
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x1FCF468", Offset = "0x1FCF468", VA = "0x7BBC7CF468")]
	private void _OnClose(params object[] args)
	{
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x1FCF570", Offset = "0x1FCF570", VA = "0x7BBC7CF570")]
	private void OnNavigationPused(params object[] args)
	{
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x1FCF584", Offset = "0x1FCF584", VA = "0x7BBC7CF584")]
	public UISmallDetailTipsController()
	{
	}

	// Token: 0x0400039C RID: 924
	[Token(Token = "0x400039C")]
	[FieldOffset(Offset = "0x98")]
	private UISmallDetailTipsView m_View;

	// Token: 0x0400039D RID: 925
	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0xA0")]
	public Action<UIDetailTipsController> _onClose;

	// Token: 0x0400039E RID: 926
	[Token(Token = "0x400039E")]
	[FieldOffset(Offset = "0xA8")]
	private Action m_ConfirmCallBack;

	// Token: 0x0400039F RID: 927
	[Token(Token = "0x400039F")]
	[FieldOffset(Offset = "0xB0")]
	private Action m_CancelCallBack;

	// Token: 0x040003A0 RID: 928
	[Token(Token = "0x40003A0")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_CloseWithCollider;
}
