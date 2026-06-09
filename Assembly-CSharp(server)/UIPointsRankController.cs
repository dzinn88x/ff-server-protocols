using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011B RID: 283
[Token(Token = "0x200011B")]
public class UIPointsRankController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
{
	// Token: 0x0600053E RID: 1342 RVA: 0x00002EF8 File Offset: 0x000010F8
	[Token(Token = "0x600053E")]
	[Address(RVA = "0x1FC8F04", Offset = "0x1FC8F04", VA = "0x7BBC7C8F04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x00002F10 File Offset: 0x00001110
	[Token(Token = "0x600053F")]
	[Address(RVA = "0x1FC8F54", Offset = "0x1FC8F54", VA = "0x7BBC7C8F54", Slot = "41")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0U;
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000540")]
	[Address(RVA = "0x1FC8F98", Offset = "0x1FC8F98", VA = "0x7BBC7C8F98", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000541")]
	[Address(RVA = "0x1FC9344", Offset = "0x1FC9344", VA = "0x7BBC7C9344", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000542")]
	[Address(RVA = "0x1FC9388", Offset = "0x1FC9388", VA = "0x7BBC7C9388")]
	private void OnClickClose()
	{
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000543")]
	[Address(RVA = "0x1FC9390", Offset = "0x1FC9390", VA = "0x7BBC7C9390", Slot = "40")]
	public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
	{
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000544")]
	[Address(RVA = "0x1FC97B4", Offset = "0x1FC97B4", VA = "0x7BBC7C97B4", Slot = "42")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000545")]
	[Address(RVA = "0x1FC9848", Offset = "0x1FC9848", VA = "0x7BBC7C9848", Slot = "43")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000546")]
	[Address(RVA = "0x1FC9878", Offset = "0x1FC9878", VA = "0x7BBC7C9878")]
	public UIPointsRankController()
	{
	}

	// Token: 0x04000476 RID: 1142
	[Token(Token = "0x4000476")]
	[FieldOffset(Offset = "0x98")]
	public LeaderBoardInfo m_SelectedInfo;

	// Token: 0x04000477 RID: 1143
	[Token(Token = "0x4000477")]
	[FieldOffset(Offset = "0xA0")]
	private UIPointsRankView m_View;

	// Token: 0x04000478 RID: 1144
	[Token(Token = "0x4000478")]
	[FieldOffset(Offset = "0xA8")]
	private UIModelLeaderBoard m_ModelLeaderBoard;

	// Token: 0x04000479 RID: 1145
	[Token(Token = "0x4000479")]
	[FieldOffset(Offset = "0xB0")]
	private UIPointsRankItemController m_SelfRankUI;

	// Token: 0x0400047A RID: 1146
	[Token(Token = "0x400047A")]
	public const uint PropID = 131104U;
}
