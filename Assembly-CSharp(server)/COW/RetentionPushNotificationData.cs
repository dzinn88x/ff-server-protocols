using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001182 RID: 4482
	[Token(Token = "0x2001182")]
	public class RetentionPushNotificationData : CSVBaseData
	{
		// Token: 0x060045BD RID: 17853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BD")]
		[Address(RVA = "0x175D90C", Offset = "0x175D90C", VA = "0x7BBBF5D90C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x175D9C4", Offset = "0x175D9C4", VA = "0x7BBBF5D9C4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x175D91C", Offset = "0x175D91C", VA = "0x7BBBF5D91C")]
		public static string FormatPrimaryKey(string region, uint newbie_days, uint notify_days)
		{
			return null;
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C0")]
		[Address(RVA = "0x175DB80", Offset = "0x175DB80", VA = "0x7BBBF5DB80")]
		public RetentionPushNotificationData()
		{
		}

		// Token: 0x040056BF RID: 22207
		[Token(Token = "0x40056BF")]
		public const int SECONDS_PER_DAY = 86400;

		// Token: 0x040056C0 RID: 22208
		[Token(Token = "0x40056C0")]
		public const string REGION_DEFAULT = "default";

		// Token: 0x040056C1 RID: 22209
		[Token(Token = "0x40056C1")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x040056C2 RID: 22210
		[Token(Token = "0x40056C2")]
		[FieldOffset(Offset = "0x18")]
		public string NotifyTitleKey;

		// Token: 0x040056C3 RID: 22211
		[Token(Token = "0x40056C3")]
		[FieldOffset(Offset = "0x20")]
		public string NotifyContentKey;

		// Token: 0x040056C4 RID: 22212
		[Token(Token = "0x40056C4")]
		[FieldOffset(Offset = "0x28")]
		public uint NewbieDays;

		// Token: 0x040056C5 RID: 22213
		[Token(Token = "0x40056C5")]
		[FieldOffset(Offset = "0x2C")]
		public uint NotifyDays;

		// Token: 0x040056C6 RID: 22214
		[Token(Token = "0x40056C6")]
		[FieldOffset(Offset = "0x30")]
		public uint RewardID;

		// Token: 0x040056C7 RID: 22215
		[Token(Token = "0x40056C7")]
		[FieldOffset(Offset = "0x34")]
		public uint RewardNum;

		// Token: 0x040056C8 RID: 22216
		[Token(Token = "0x40056C8")]
		[FieldOffset(Offset = "0x38")]
		public uint RewardTime;
	}
}
