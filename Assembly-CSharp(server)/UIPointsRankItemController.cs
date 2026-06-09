using System;
using System.Collections.Generic;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200011C RID: 284
[Token(Token = "0x200011C")]
public class UIPointsRankItemController : UIEasyListItemController
{
	// Token: 0x06000547 RID: 1351 RVA: 0x00002F28 File Offset: 0x00001128
	[Token(Token = "0x6000547")]
	[Address(RVA = "0x1FC9880", Offset = "0x1FC9880", VA = "0x7BBC7C9880")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000548")]
	[Address(RVA = "0x1FC98D0", Offset = "0x1FC98D0", VA = "0x7BBC7C98D0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000549")]
	[Address(RVA = "0x1FC9A2C", Offset = "0x1FC9A2C", VA = "0x7BBC7C9A2C")]
	private void SetItemData(LeaderBoardInfo info)
	{
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054A")]
	[Address(RVA = "0x1FC9680", Offset = "0x1FC9680", VA = "0x7BBC7C9680")]
	public void SetWidgetColor(Color color)
	{
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054B")]
	[Address(RVA = "0x1FC9F98", Offset = "0x1FC9F98", VA = "0x7BBC7C9F98", Slot = "28")]
	public override void SetViewData(object data, int data_index)
	{
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054C")]
	[Address(RVA = "0x1FCA034", Offset = "0x1FCA034", VA = "0x7BBC7CA034", Slot = "31")]
	public override void OnItemBtnSelect()
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054D")]
	[Address(RVA = "0x1FC97A8", Offset = "0x1FC97A8", VA = "0x7BBC7C97A8")]
	public void SetRankFormat(bool usePercentFormat)
	{
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054E")]
	[Address(RVA = "0x1FC9D94", Offset = "0x1FC9D94", VA = "0x7BBC7C9D94")]
	private void UpdateView()
	{
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600054F")]
	[Address(RVA = "0x1FCA11C", Offset = "0x1FCA11C", VA = "0x7BBC7CA11C")]
	public UIPointsRankItemController()
	{
	}

	// Token: 0x0400047B RID: 1147
	[Token(Token = "0x400047B")]
	[FieldOffset(Offset = "0x70")]
	private UIPointsRankItemView m_View;

	// Token: 0x0400047C RID: 1148
	[Token(Token = "0x400047C")]
	[FieldOffset(Offset = "0x78")]
	private LeaderBoardInfo m_Info;

	// Token: 0x0400047D RID: 1149
	[Token(Token = "0x400047D")]
	[FieldOffset(Offset = "0x80")]
	private uint m_MaxSize;

	// Token: 0x0400047E RID: 1150
	[Token(Token = "0x400047E")]
	[FieldOffset(Offset = "0x88")]
	private Dictionary<uint, string> m_RankCupIcon;

	// Token: 0x0400047F RID: 1151
	[Token(Token = "0x400047F")]
	[FieldOffset(Offset = "0x90")]
	private bool m_UsePercentFormat;
}
