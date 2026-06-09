using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010AD RID: 4269
	[Token(Token = "0x20010AD")]
	public class BanInfoUrlData : CSVBaseData
	{
		// Token: 0x0600429C RID: 17052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600429C")]
		[Address(RVA = "0x21CC8B4", Offset = "0x21CC8B4", VA = "0x7BBC9CC8B4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600429D RID: 17053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429D")]
		[Address(RVA = "0x21CC8C0", Offset = "0x21CC8C0", VA = "0x7BBC9CC8C0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600429E RID: 17054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600429E")]
		[Address(RVA = "0x21CC9C0", Offset = "0x21CC9C0", VA = "0x7BBC9CC9C0")]
		public BanInfoUrlData()
		{
		}

		// Token: 0x040051A4 RID: 20900
		[Token(Token = "0x40051A4")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040051A5 RID: 20901
		[Token(Token = "0x40051A5")]
		[FieldOffset(Offset = "0x18")]
		public string Country;

		// Token: 0x040051A6 RID: 20902
		[Token(Token = "0x40051A6")]
		[FieldOffset(Offset = "0x20")]
		public int BanReasonId;

		// Token: 0x040051A7 RID: 20903
		[Token(Token = "0x40051A7")]
		[FieldOffset(Offset = "0x28")]
		public string Url;
	}
}
