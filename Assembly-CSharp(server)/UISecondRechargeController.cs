using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;

// Token: 0x0200011D RID: 285
[Token(Token = "0x200011D")]
public class UISecondRechargeController : UIPopupWindowController, IUIModelDataChangeObserver
{
	// Token: 0x06000550 RID: 1360 RVA: 0x00002F40 File Offset: 0x00001140
	[Token(Token = "0x6000550")]
	[Address(RVA = "0x1FCB4B8", Offset = "0x1FCB4B8", VA = "0x7BBC7CB4B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x00002F58 File Offset: 0x00001158
	[Token(Token = "0x6000551")]
	[Address(RVA = "0x1FCB508", Offset = "0x1FCB508", VA = "0x7BBC7CB508", Slot = "41")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0U;
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000552")]
	[Address(RVA = "0x1FCB54C", Offset = "0x1FCB54C", VA = "0x7BBC7CB54C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000553")]
	[Address(RVA = "0x1FCBB18", Offset = "0x1FCBB18", VA = "0x7BBC7CBB18", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000554")]
	[Address(RVA = "0x1FCBB5C", Offset = "0x1FCBB5C", VA = "0x7BBC7CBB5C")]
	private void OnClickClose()
	{
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000555")]
	[Address(RVA = "0x1FCBB64", Offset = "0x1FCBB64", VA = "0x7BBC7CBB64", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000556")]
	[Address(RVA = "0x1FCBB6C", Offset = "0x1FCBB6C", VA = "0x7BBC7CBB6C", Slot = "40")]
	public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
	{
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000557")]
	[Address(RVA = "0x1FCB7F0", Offset = "0x1FCB7F0", VA = "0x7BBC7CB7F0")]
	public void UpdateView(object data)
	{
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000558")]
	[Address(RVA = "0x1FCBEFC", Offset = "0x1FCBEFC", VA = "0x7BBC7CBEFC")]
	private void CreateRewardItemList()
	{
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000559")]
	[Address(RVA = "0x1FCBD84", Offset = "0x1FCBD84", VA = "0x7BBC7CBD84")]
	private void SetOperateButtonUI()
	{
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055A")]
	[Address(RVA = "0x1FCC68C", Offset = "0x1FCC68C", VA = "0x7BBC7CC68C")]
	private void OnClickCharge()
	{
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x600055B")]
	[Address(RVA = "0x1FCC1F8", Offset = "0x1FCC1F8", VA = "0x7BBC7CC1F8")]
	private bool HasReceived()
	{
		return default(bool);
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600055C")]
	[Address(RVA = "0x1FCC7FC", Offset = "0x1FCC7FC", VA = "0x7BBC7CC7FC")]
	public UISecondRechargeController()
	{
	}

	// Token: 0x04000480 RID: 1152
	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0x98")]
	private UISecondRechargeView m_View;

	// Token: 0x04000481 RID: 1153
	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0xA0")]
	private List<UISecondRechargeRewardItemController> m_Items;

	// Token: 0x04000482 RID: 1154
	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0xA8")]
	private UIModelActivity m_ModelActivity;

	// Token: 0x04000483 RID: 1155
	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0xB0")]
	private ActivityGroupDesc m_GroupDesc;

	// Token: 0x04000484 RID: 1156
	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0xB8")]
	private UISecondRechargeController.OperateStatus m_OperateStatus;

	// Token: 0x04000485 RID: 1157
	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0xC0")]
	private string activityTimeStr;

	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	private enum OperateStatus
	{
		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		None,
		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		GoTo,
		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		UnFinished,
		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		Available,
		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		Received
	}
}
