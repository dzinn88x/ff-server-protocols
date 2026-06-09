using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010DE RID: 4318
	[Token(Token = "0x20010DE")]
	public class DirtyData : CSVBaseData
	{
		// Token: 0x06004363 RID: 17251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004363")]
		[Address(RVA = "0x1608A78", Offset = "0x1608A78", VA = "0x7BBBE08A78", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004364")]
		[Address(RVA = "0x1608A84", Offset = "0x1608A84", VA = "0x7BBBE08A84", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004365")]
		[Address(RVA = "0x1608B44", Offset = "0x1608B44", VA = "0x7BBBE08B44")]
		public DirtyData()
		{
		}

		// Token: 0x0400531A RID: 21274
		[Token(Token = "0x400531A")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x0400531B RID: 21275
		[Token(Token = "0x400531B")]
		[FieldOffset(Offset = "0x18")]
		public string Name;
	}
}
