using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;

// Token: 0x0200010A RID: 266
[Token(Token = "0x200010A")]
public class UIGuildSignInController : UIPopupWindowController, IUIModelDataChangeObserver
{
	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x17000046")]
	private bool m_HasNextLevel
	{
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1CA6BA4", Offset = "0x1CA6BA4", VA = "0x7BBC4A6BA4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x1CA6BB4", Offset = "0x1CA6BB4", VA = "0x7BBC4A6BB4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x1CA6C04", Offset = "0x1CA6C04", VA = "0x7BBC4A6C04", Slot = "41")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0U;
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x1CA6C48", Offset = "0x1CA6C48", VA = "0x7BBC4A6C48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060004E6 RID: 1254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x1CA7CDC", Offset = "0x1CA7CDC", VA = "0x7BBC4A7CDC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x060004E7 RID: 1255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x1CA7D90", Offset = "0x1CA7D90", VA = "0x7BBC4A7D90")]
	private void OnClickClose()
	{
	}

	// Token: 0x060004E8 RID: 1256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x1CA7D98", Offset = "0x1CA7D98", VA = "0x7BBC4A7D98", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	// Token: 0x060004E9 RID: 1257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004E9")]
	[Address(RVA = "0x1CA7DA0", Offset = "0x1CA7DA0", VA = "0x7BBC4A7DA0", Slot = "40")]
	public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
	{
	}

	// Token: 0x060004EA RID: 1258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EA")]
	[Address(RVA = "0x1CA709C", Offset = "0x1CA709C", VA = "0x7BBC4A709C")]
	private void UpdateView()
	{
	}

	// Token: 0x060004EB RID: 1259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EB")]
	[Address(RVA = "0x1CA80F0", Offset = "0x1CA80F0", VA = "0x7BBC4A80F0")]
	private void OnClickNextClan()
	{
	}

	// Token: 0x060004EC RID: 1260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x1CA8100", Offset = "0x1CA8100", VA = "0x7BBC4A8100")]
	public UIGuildSignInController()
	{
	}

	// Token: 0x0400042B RID: 1067
	[Token(Token = "0x400042B")]
	[FieldOffset(Offset = "0x98")]
	private UIGuildSignInView m_View;

	// Token: 0x0400042C RID: 1068
	[Token(Token = "0x400042C")]
	[FieldOffset(Offset = "0xA0")]
	private List<UIGuildSignInItemController> m_Items;

	// Token: 0x0400042D RID: 1069
	[Token(Token = "0x400042D")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_IsJumpToNextClan;

	// Token: 0x0400042E RID: 1070
	[Token(Token = "0x400042E")]
	[FieldOffset(Offset = "0xB0")]
	private ClanLevelData m_CurLevelData;

	// Token: 0x0400042F RID: 1071
	[Token(Token = "0x400042F")]
	[FieldOffset(Offset = "0xB8")]
	private ClanLevelData m_NextLevelData;
}
