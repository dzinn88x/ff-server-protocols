using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020010FD RID: 4349
	[Token(Token = "0x20010FD")]
	public class FriendTagRuleData : CSVBaseData
	{
		// Token: 0x060043F5 RID: 17397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F5")]
		[Address(RVA = "0x1B9C1E0", Offset = "0x1B9C1E0", VA = "0x7BBC39C1E0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F6")]
		[Address(RVA = "0x1B9C2B8", Offset = "0x1B9C2B8", VA = "0x7BBC39C2B8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043F7")]
		[Address(RVA = "0x1B9C414", Offset = "0x1B9C414", VA = "0x7BBC39C414")]
		public FriendTagRuleData()
		{
		}

		// Token: 0x040053F9 RID: 21497
		[Token(Token = "0x40053F9")]
		[FieldOffset(Offset = "0x10")]
		public RecommendedFriendTag Tag;

		// Token: 0x040053FA RID: 21498
		[Token(Token = "0x40053FA")]
		[FieldOffset(Offset = "0x14")]
		public bool Switch;

		// Token: 0x040053FB RID: 21499
		[Token(Token = "0x40053FB")]
		[FieldOffset(Offset = "0x18")]
		public int TagNumLimit;

		// Token: 0x040053FC RID: 21500
		[Token(Token = "0x40053FC")]
		[FieldOffset(Offset = "0x1C")]
		public Color BgColor;

		// Token: 0x040053FD RID: 21501
		[Token(Token = "0x40053FD")]
		[FieldOffset(Offset = "0x30")]
		public string Key;
	}
}
