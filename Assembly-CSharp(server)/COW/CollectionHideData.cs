using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010D1 RID: 4305
	[Token(Token = "0x20010D1")]
	public class CollectionHideData : CSVBaseData
	{
		// Token: 0x06004319 RID: 17177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004319")]
		[Address(RVA = "0x15FB844", Offset = "0x15FB844", VA = "0x7BBBDFB844", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431A")]
		[Address(RVA = "0x15FB850", Offset = "0x15FB850", VA = "0x7BBBDFB850", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600431B")]
		[Address(RVA = "0x15FB9A8", Offset = "0x15FB9A8", VA = "0x7BBBDFB9A8")]
		public CollectionHideData()
		{
		}

		// Token: 0x040052A1 RID: 21153
		[Token(Token = "0x40052A1")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040052A2 RID: 21154
		[Token(Token = "0x40052A2")]
		[FieldOffset(Offset = "0x18")]
		public uint ID;

		// Token: 0x040052A3 RID: 21155
		[Token(Token = "0x40052A3")]
		[FieldOffset(Offset = "0x1C")]
		public uint itemID;
	}
}
