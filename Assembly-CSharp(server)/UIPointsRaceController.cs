using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;

// Token: 0x02000117 RID: 279
[Token(Token = "0x2000117")]
public class UIPointsRaceController : UIBaseController, IUIModelDataChangeObserver
{
	// Token: 0x06000522 RID: 1314 RVA: 0x00002E80 File Offset: 0x00001080
	[Token(Token = "0x6000522")]
	[Address(RVA = "0x1FC6174", Offset = "0x1FC6174", VA = "0x7BBC7C6174")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x00002E98 File Offset: 0x00001098
	[Token(Token = "0x6000523")]
	[Address(RVA = "0x1FC61C4", Offset = "0x1FC61C4", VA = "0x7BBC7C61C4", Slot = "29")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0U;
	}

	// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000524")]
	[Address(RVA = "0x1FC6208", Offset = "0x1FC6208", VA = "0x7BBC7C6208", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x06000525 RID: 1317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000525")]
	[Address(RVA = "0x1FC65FC", Offset = "0x1FC65FC", VA = "0x7BBC7C65FC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000526")]
	[Address(RVA = "0x1FC6644", Offset = "0x1FC6644", VA = "0x7BBC7C6644")]
	private void OnClickClose()
	{
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000527")]
	[Address(RVA = "0x1FC664C", Offset = "0x1FC664C", VA = "0x7BBC7C664C", Slot = "28")]
	public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
	{
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000528")]
	[Address(RVA = "0x1FC76F0", Offset = "0x1FC76F0", VA = "0x7BBC7C76F0")]
	private void UpdateIndividualItems()
	{
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00002EB0 File Offset: 0x000010B0
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x1FC72E8", Offset = "0x1FC72E8", VA = "0x7BBC7C72E8")]
	private float GetProgressValue()
	{
		return 0f;
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052A")]
	[Address(RVA = "0x1FC7CF4", Offset = "0x1FC7CF4", VA = "0x7BBC7C7CF4")]
	public void OnClickPointsRank()
	{
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052B")]
	[Address(RVA = "0x1FC7F40", Offset = "0x1FC7F40", VA = "0x7BBC7C7F40")]
	private void OnClickClaimClanAward()
	{
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052C")]
	[Address(RVA = "0x1FC7F70", Offset = "0x1FC7F70", VA = "0x7BBC7C7F70")]
	private void OnClickRaceTips()
	{
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052D")]
	[Address(RVA = "0x1FC7964", Offset = "0x1FC7964", VA = "0x7BBC7C7964")]
	private void UpdateMyPoints(uint myPoints)
	{
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x1FC808C", Offset = "0x1FC808C", VA = "0x7BBC7C808C")]
	public UIPointsRaceController()
	{
	}

	// Token: 0x04000462 RID: 1122
	[Token(Token = "0x4000462")]
	[FieldOffset(Offset = "0x58")]
	private UIPointsRaceView m_View;

	// Token: 0x04000463 RID: 1123
	[Token(Token = "0x4000463")]
	[FieldOffset(Offset = "0x60")]
	private UIModelClanRace m_UIModelClanRace;

	// Token: 0x04000464 RID: 1124
	[Token(Token = "0x4000464")]
	[FieldOffset(Offset = "0x68")]
	private uint m_CurStageID;

	// Token: 0x04000465 RID: 1125
	[Token(Token = "0x4000465")]
	[FieldOffset(Offset = "0x70")]
	private List<UIPointsRaceClanItemController> m_ClanItems;

	// Token: 0x04000466 RID: 1126
	[Token(Token = "0x4000466")]
	[FieldOffset(Offset = "0x78")]
	private ClanLevelData m_CurLevelData;

	// Token: 0x04000467 RID: 1127
	[Token(Token = "0x4000467")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsClaimedClanAwards;

	// Token: 0x04000468 RID: 1128
	[Token(Token = "0x4000468")]
	[FieldOffset(Offset = "0x88")]
	private List<UIPointsRaceIndividualItemController> m_IndividualItems;

	// Token: 0x04000469 RID: 1129
	[Token(Token = "0x4000469")]
	[FieldOffset(Offset = "0x90")]
	private bool m_HasGetRaceInfo;
}
