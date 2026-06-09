using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using proto;

// Token: 0x0200010B RID: 267
[Token(Token = "0x200010B")]
public class UIGuildSignInItemController : UIBaseController, IUIModelDataChangeObserver
{
	// Token: 0x060004ED RID: 1261 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x1CA8178", Offset = "0x1CA8178", VA = "0x7BBC4A8178")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x060004EE RID: 1262 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x1CA81C8", Offset = "0x1CA81C8", VA = "0x7BBC4A81C8", Slot = "29")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0U;
	}

	// Token: 0x060004EF RID: 1263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x1CA820C", Offset = "0x1CA820C", VA = "0x7BBC4A820C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x1CA835C", Offset = "0x1CA835C", VA = "0x7BBC4A835C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x1CA846C", Offset = "0x1CA846C", VA = "0x7BBC4A846C", Slot = "28")]
	public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
	{
	}

	// Token: 0x060004F2 RID: 1266 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x1CA7E18", Offset = "0x1CA7E18", VA = "0x7BBC4A7E18")]
	public void SetData(BaseItemInfo info, DayOfWeek day, EClan.ClanSignInRewardStatus state = EClan.ClanSignInRewardStatus.ClanSignInRewardStatus_NOT_SIGNED, bool showCurrentDay = true)
	{
	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x1CA8750", Offset = "0x1CA8750", VA = "0x7BBC4A8750")]
	private void UpdateState()
	{
	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x1CA8C7C", Offset = "0x1CA8C7C", VA = "0x7BBC4A8C7C")]
	private void OnClickItem()
	{
	}

	// Token: 0x060004F5 RID: 1269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x1CA8E9C", Offset = "0x1CA8E9C", VA = "0x7BBC4A8E9C")]
	public UIGuildSignInItemController()
	{
	}

	// Token: 0x060004F6 RID: 1270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x1CA8EA4", Offset = "0x1CA8EA4", VA = "0x7BBC4A8EA4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1132E04", Offset = "0x1132E04")]
	private void <OnClickItem>b__15_0()
	{
	}

	// Token: 0x04000430 RID: 1072
	[Token(Token = "0x4000430")]
	private const uint m_Yellow = 4256760319U;

	// Token: 0x04000431 RID: 1073
	[Token(Token = "0x4000431")]
	[FieldOffset(Offset = "0x58")]
	private UIGuildSignInItemView m_View;

	// Token: 0x04000432 RID: 1074
	[Token(Token = "0x4000432")]
	[FieldOffset(Offset = "0x60")]
	private EClan.ClanSignInRewardStatus m_State;

	// Token: 0x04000433 RID: 1075
	[Token(Token = "0x4000433")]
	[FieldOffset(Offset = "0x64")]
	private DayOfWeek m_Day;

	// Token: 0x04000434 RID: 1076
	[Token(Token = "0x4000434")]
	[FieldOffset(Offset = "0x68")]
	private bool m_IsRequestResponse;

	// Token: 0x04000435 RID: 1077
	[Token(Token = "0x4000435")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_DelayCallID;

	// Token: 0x04000436 RID: 1078
	[Token(Token = "0x4000436")]
	[FieldOffset(Offset = "0x70")]
	private BaseItemInfo m_Data;

	// Token: 0x04000437 RID: 1079
	[Token(Token = "0x4000437")]
	[FieldOffset(Offset = "0x78")]
	private bool m_IsShowCurrentDay;

	// Token: 0x0200010C RID: 268
	[Token(Token = "0x200010C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10E1E90", Offset = "0x10E1E90")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1CA8F14", Offset = "0x1CA8F14", VA = "0x7BBC4A8F14")]
		public <>c()
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1CA8F1C", Offset = "0x1CA8F1C", VA = "0x7BBC4A8F1C")]
		internal CommonRewardItemInfo <OnDataChanged>b__12_0(BaseItemInfo item)
		{
			return null;
		}

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIGuildSignInItemController.<>c <>9;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x8")]
		public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__12_0;
	}
}
