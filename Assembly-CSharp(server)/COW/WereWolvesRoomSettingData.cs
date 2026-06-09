using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011AC RID: 4524
	[Token(Token = "0x20011AC")]
	public class WereWolvesRoomSettingData : CSVBaseData
	{
		// Token: 0x0600465E RID: 18014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600465E")]
		[Address(RVA = "0x23DF97C", Offset = "0x23DF97C", VA = "0x7BBCBDF97C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465F")]
		[Address(RVA = "0x23DF988", Offset = "0x23DF988", VA = "0x7BBCBDF988", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004660")]
		[Address(RVA = "0x23DFAF8", Offset = "0x23DFAF8", VA = "0x7BBCBDFAF8")]
		public WereWolvesRoomSettingData()
		{
		}

		// Token: 0x040057B1 RID: 22449
		[Token(Token = "0x40057B1")]
		[FieldOffset(Offset = "0x10")]
		public int TypeID;

		// Token: 0x040057B2 RID: 22450
		[Token(Token = "0x40057B2")]
		[FieldOffset(Offset = "0x18")]
		public string LocKey;

		// Token: 0x040057B3 RID: 22451
		[Token(Token = "0x40057B3")]
		[FieldOffset(Offset = "0x20")]
		public uint DefaultValue;

		// Token: 0x040057B4 RID: 22452
		[Token(Token = "0x40057B4")]
		[FieldOffset(Offset = "0x24")]
		public uint MinValue;

		// Token: 0x040057B5 RID: 22453
		[Token(Token = "0x40057B5")]
		[FieldOffset(Offset = "0x28")]
		public uint MaxValue;

		// Token: 0x040057B6 RID: 22454
		[Token(Token = "0x40057B6")]
		[FieldOffset(Offset = "0x2C")]
		public uint StepValue;

		// Token: 0x040057B7 RID: 22455
		[Token(Token = "0x40057B7")]
		[FieldOffset(Offset = "0x30")]
		public uint[] OptionValues;
	}
}
