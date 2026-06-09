using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200014C RID: 332
[Token(Token = "0x200014C")]
public class UIMatchResultDetailView : MonoBehaviour
{
	// Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000652")]
	[Address(RVA = "0x1CABE08", Offset = "0x1CABE08", VA = "0x7BBC4ABE08")]
	public void Open(MatchResultDetailInfo info, Vector3 pos)
	{
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x1CAC558", Offset = "0x1CAC558", VA = "0x7BBC4AC558")]
	public void Close()
	{
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000654")]
	[Address(RVA = "0x1CAC590", Offset = "0x1CAC590", VA = "0x7BBC4AC590")]
	public UIMatchResultDetailView()
	{
	}

	// Token: 0x04000593 RID: 1427
	[Token(Token = "0x4000593")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UILabel _goldCount_MatchLabel;

	// Token: 0x04000594 RID: 1428
	[Token(Token = "0x4000594")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private UILabel _expValue_MatchLabel;

	// Token: 0x04000595 RID: 1429
	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private UILabel _goldCount_DailyLabel;

	// Token: 0x04000596 RID: 1430
	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private UILabel _expValue_DailyLabel;

	// Token: 0x04000597 RID: 1431
	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UILabel _goldCount_ClanLabel;

	// Token: 0x04000598 RID: 1432
	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private UILabel _expValue_ClanLabel;

	// Token: 0x04000599 RID: 1433
	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UILabel _honorValue_ClanLabel;

	// Token: 0x0400059A RID: 1434
	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UILabel _goldCount_EventLabel;

	// Token: 0x0400059B RID: 1435
	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private UILabel _expValue_EventLabel;

	// Token: 0x0400059C RID: 1436
	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private UILabel _goldCount_CardLabel;

	// Token: 0x0400059D RID: 1437
	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UILabel _expValue_CardLabel;

	// Token: 0x0400059E RID: 1438
	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UILabel _goldCount_RankLabel;

	// Token: 0x0400059F RID: 1439
	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UILabel _expValue_RankLabel;

	// Token: 0x040005A0 RID: 1440
	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UILabel m_GoldDailyLimitLabel;

	// Token: 0x040005A1 RID: 1441
	[Token(Token = "0x40005A1")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private UILabel m_DebrisDailyLimitLabel;

	// Token: 0x040005A2 RID: 1442
	[Token(Token = "0x40005A2")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private UILabel m_ExpOtherBonusLabel;

	// Token: 0x040005A3 RID: 1443
	[Token(Token = "0x40005A3")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject _matchObj;

	// Token: 0x040005A4 RID: 1444
	[Token(Token = "0x40005A4")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject _dailyObj;

	// Token: 0x040005A5 RID: 1445
	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private GameObject _clanObj;

	// Token: 0x040005A6 RID: 1446
	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject _eventObj;

	// Token: 0x040005A7 RID: 1447
	[Token(Token = "0x40005A7")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private GameObject _cardObj;

	// Token: 0x040005A8 RID: 1448
	[Token(Token = "0x40005A8")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private GameObject _rankObj;

	// Token: 0x040005A9 RID: 1449
	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject m_DailyLimitObj;

	// Token: 0x040005AA RID: 1450
	[Token(Token = "0x40005AA")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private GameObject m_ExpBonusObj;

	// Token: 0x040005AB RID: 1451
	[Token(Token = "0x40005AB")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite BG;

	// Token: 0x040005AC RID: 1452
	[Token(Token = "0x40005AC")]
	[FieldOffset(Offset = "0xE0")]
	public UIGrid grid;
}
