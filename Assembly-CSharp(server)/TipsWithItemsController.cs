using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000FD RID: 253
[Token(Token = "0x20000FD")]
public class TipsWithItemsController : UIPopupWindowController
{
	// Token: 0x060004A3 RID: 1187 RVA: 0x00002C70 File Offset: 0x00000E70
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x2265888", Offset = "0x2265888", VA = "0x7BBCA65888")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x22658D8", Offset = "0x22658D8", VA = "0x7BBCA658D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x22659BC", Offset = "0x22659BC", VA = "0x7BBCA659BC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x2265A88", Offset = "0x2265A88", VA = "0x7BBCA65A88")]
	public void SetData(Vector3 itemCenter, Vector3 offset, List<TipsWithItemsItemVO> dataList)
	{
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x22666D4", Offset = "0x22666D4", VA = "0x7BBCA666D4")]
	private void OnClickClose(params object[] args)
	{
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x22666DC", Offset = "0x22666DC", VA = "0x7BBCA666DC")]
	public TipsWithItemsController()
	{
	}

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x98")]
	private TipsWithItemsView m_View;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0xA0")]
	private int m_PaddingY;
}
