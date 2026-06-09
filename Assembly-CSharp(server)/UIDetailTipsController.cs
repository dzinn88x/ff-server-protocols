using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DE RID: 222
[Token(Token = "0x20000DE")]
public class UIDetailTipsController : UIPopupWindowController
{
	// Token: 0x060003CF RID: 975 RVA: 0x00002A48 File Offset: 0x00000C48
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x1CA0DA0", Offset = "0x1CA0DA0", VA = "0x7BBC4A0DA0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x1CA0DF0", Offset = "0x1CA0DF0", VA = "0x7BBC4A0DF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x1CA1064", Offset = "0x1CA1064", VA = "0x7BBC4A1064", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00002A60 File Offset: 0x00000C60
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x1CA1184", Offset = "0x1CA1184", VA = "0x7BBC4A1184", Slot = "34")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00002A78 File Offset: 0x00000C78
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x1CA118C", Offset = "0x1CA118C", VA = "0x7BBC4A118C", Slot = "31")]
	public override int MinGroupDepth()
	{
		return 0;
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x1CA11A8", Offset = "0x1CA11A8", VA = "0x7BBC4A11A8")]
	public void SetTipsStype(EDetailTipsStyle style)
	{
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x1CA11B0", Offset = "0x1CA11B0", VA = "0x7BBC4A11B0")]
	public void SetData(Vector3 itemPos, string title, string descrip)
	{
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x1CA2E44", Offset = "0x1CA2E44", VA = "0x7BBC4A2E44")]
	public void SetData(Vector3 itemPos, string title, string descrip, List<ResourceID> spriteResIds)
	{
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x1CA3174", Offset = "0x1CA3174", VA = "0x7BBC4A3174")]
	public void SetData(Vector3 itemPos, uint id)
	{
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x1CA3448", Offset = "0x1CA3448", VA = "0x7BBC4A3448")]
	public void SetData(Vector3 itemPos, BaseItemInfo info)
	{
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x1CA3514", Offset = "0x1CA3514", VA = "0x7BBC4A3514")]
	public void SetData(Vector3 itemPos, string title, string descrip, bool use_collider, EArrowFixedType arrowFixedType)
	{
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x1CA35EC", Offset = "0x1CA35EC", VA = "0x7BBC4A35EC")]
	public void SetData(Vector3 itemPos, string title, string descrip, TipsBtnInfo confirm_btn_info, TipsBtnInfo cancle_btn_info, bool use_collider, EArrowFixedType arrowFixedType)
	{
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x1CA1278", Offset = "0x1CA1278", VA = "0x7BBC4A1278")]
	public void SetData(Vector3 itemPos, BaseItemInfo info, string name, string descrip, Vector3 offset, TipsBtnInfo[] btn_info_list, bool use_collider, EArrowFixedType arrowFixedType)
	{
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x1CA379C", Offset = "0x1CA379C", VA = "0x7BBC4A379C")]
	private void OnConfirmClick()
	{
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x1CA37FC", Offset = "0x1CA37FC", VA = "0x7BBC4A37FC")]
	private void OnCancleClick()
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x1CA37E8", Offset = "0x1CA37E8", VA = "0x7BBC4A37E8")]
	private void CloseWithCollider()
	{
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x1CA3848", Offset = "0x1CA3848", VA = "0x7BBC4A3848")]
	private void _OnClose(params object[] args)
	{
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x1CA3950", Offset = "0x1CA3950", VA = "0x7BBC4A3950")]
	private void OnNavigationPused(params object[] args)
	{
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x1CA3964", Offset = "0x1CA3964", VA = "0x7BBC4A3964")]
	public UIDetailTipsController()
	{
	}

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Vector3 s_offset;

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x98")]
	public Action<UIDetailTipsController> _onClose;

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0xA0")]
	private UIDetailTipsViewExt m_View;

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0xA8")]
	private int m_TopAndBottomPadding;

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0xAC")]
	private EDetailTipsStyle m_TipsStyle;

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0xB0")]
	private Action m_ConfirmCallBack;

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0xB8")]
	private Action m_CancelCallBack;

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_CloseWithCollider;
}
