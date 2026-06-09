using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using proto;

// Token: 0x02000119 RID: 281
[Token(Token = "0x2000119")]
public class UIPointsRaceIndividualItemController : UIBaseController, IUIModelDataChangeObserver
{
	// Token: 0x0600052F RID: 1327 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x600052F")]
	[Address(RVA = "0x1FC8124", Offset = "0x1FC8124", VA = "0x7BBC7C8124")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x00002EE0 File Offset: 0x000010E0
	[Token(Token = "0x6000530")]
	[Address(RVA = "0x1FC8174", Offset = "0x1FC8174", VA = "0x7BBC7C8174", Slot = "29")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0U;
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000531")]
	[Address(RVA = "0x1FC81B8", Offset = "0x1FC81B8", VA = "0x7BBC7C81B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000532")]
	[Address(RVA = "0x1FC8438", Offset = "0x1FC8438", VA = "0x7BBC7C8438", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000533")]
	[Address(RVA = "0x1FC84EC", Offset = "0x1FC84EC", VA = "0x7BBC7C84EC")]
	private void OnClickClose()
	{
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000534")]
	[Address(RVA = "0x1FC84F4", Offset = "0x1FC84F4", VA = "0x7BBC7C84F4", Slot = "28")]
	public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000535")]
	[Address(RVA = "0x1FC7A18", Offset = "0x1FC7A18", VA = "0x7BBC7C7A18")]
	public void SetData(AwardDesc info, uint stageId, uint minPoints, bool isUnlock, bool isClaimed, bool isOpen, uint minClanPoints)
	{
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000536")]
	[Address(RVA = "0x1FC8370", Offset = "0x1FC8370", VA = "0x7BBC7C8370")]
	private void UpdateView()
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000537")]
	[Address(RVA = "0x1FC88C8", Offset = "0x1FC88C8", VA = "0x7BBC7C88C8")]
	public void OnClickClaim()
	{
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000538")]
	[Address(RVA = "0x1FC8B90", Offset = "0x1FC8B90", VA = "0x7BBC7C8B90")]
	public void OnClickTips()
	{
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000539")]
	[Address(RVA = "0x1FC8650", Offset = "0x1FC8650", VA = "0x7BBC7C8650")]
	private void OnClaimed()
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600053A")]
	[Address(RVA = "0x1FC8E84", Offset = "0x1FC8E84", VA = "0x7BBC7C8E84")]
	public UIPointsRaceIndividualItemController()
	{
	}

	// Token: 0x0400046F RID: 1135
	[Token(Token = "0x400046F")]
	[FieldOffset(Offset = "0x58")]
	private UIPointsRaceIndividualItemView m_View;

	// Token: 0x04000470 RID: 1136
	[Token(Token = "0x4000470")]
	[FieldOffset(Offset = "0x60")]
	private AwardDesc m_Info;

	// Token: 0x04000471 RID: 1137
	[Token(Token = "0x4000471")]
	[FieldOffset(Offset = "0x68")]
	private uint m_StageID;

	// Token: 0x04000472 RID: 1138
	[Token(Token = "0x4000472")]
	[FieldOffset(Offset = "0x6C")]
	private EClaimItemState m_State;

	// Token: 0x04000473 RID: 1139
	[Token(Token = "0x4000473")]
	[FieldOffset(Offset = "0x70")]
	private uint m_ExchangePointsCost;

	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1F40", Offset = "0x10E1F40")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600053C RID: 1340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1FC8EF0", Offset = "0x1FC8EF0", VA = "0x7BBC7C8EF0")]
		public <>c()
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1FC8EF8", Offset = "0x1FC8EF8", VA = "0x7BBC7C8EF8")]
		internal CommonRewardItemInfo <OnClaimed>b__15_0(BaseItemInfo item)
		{
			return null;
		}

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIPointsRaceIndividualItemController.<>c <>9;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x8")]
		public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__15_0;
	}
}
