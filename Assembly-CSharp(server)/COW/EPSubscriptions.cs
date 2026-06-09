using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010EF RID: 4335
	[Token(Token = "0x20010EF")]
	internal class EPSubscriptions : CSVBaseData
	{
		// Token: 0x060043AC RID: 17324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AC")]
		[Address(RVA = "0x16126E4", Offset = "0x16126E4", VA = "0x7BBBE126E4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AD")]
		[Address(RVA = "0x16126F4", Offset = "0x16126F4", VA = "0x7BBBE126F4")]
		public static string FormatPrimaryKey(string region, int itemId)
		{
			return null;
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043AE")]
		[Address(RVA = "0x1612778", Offset = "0x1612778", VA = "0x7BBBE12778", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043AF")]
		[Address(RVA = "0x16128C0", Offset = "0x16128C0", VA = "0x7BBBE128C0")]
		public static string Detail(EPSubscriptions epSubscriptions)
		{
			return null;
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043B0")]
		[Address(RVA = "0x1612B20", Offset = "0x1612B20", VA = "0x7BBBE12B20")]
		public EPSubscriptions()
		{
		}

		// Token: 0x0400539E RID: 21406
		[Token(Token = "0x400539E")]
		[FieldOffset(Offset = "0x10")]
		public string Region;

		// Token: 0x0400539F RID: 21407
		[Token(Token = "0x400539F")]
		[FieldOffset(Offset = "0x18")]
		public string Price;

		// Token: 0x040053A0 RID: 21408
		[Token(Token = "0x40053A0")]
		[FieldOffset(Offset = "0x20")]
		public int RebateID;

		// Token: 0x040053A1 RID: 21409
		[Token(Token = "0x40053A1")]
		[FieldOffset(Offset = "0x24")]
		public int ItemID;

		// Token: 0x040053A2 RID: 21410
		[Token(Token = "0x40053A2")]
		[FieldOffset(Offset = "0x28")]
		public int SubscribeBonus;

		// Token: 0x040053A3 RID: 21411
		[Token(Token = "0x40053A3")]
		[FieldOffset(Offset = "0x30")]
		public PayItemData SubscriptionFromCSV;
	}
}
