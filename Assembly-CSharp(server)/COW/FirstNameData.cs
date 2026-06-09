using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010FA RID: 4346
	[Token(Token = "0x20010FA")]
	internal class FirstNameData : CSVBaseData
	{
		// Token: 0x060043DA RID: 17370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DA")]
		[Address(RVA = "0x1B997CC", Offset = "0x1B997CC", VA = "0x7BBC3997CC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043DB")]
		[Address(RVA = "0x1B997D8", Offset = "0x1B997D8", VA = "0x7BBC3997D8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043DC")]
		[Address(RVA = "0x1B99898", Offset = "0x1B99898", VA = "0x7BBC399898")]
		public FirstNameData()
		{
		}

		// Token: 0x040053E8 RID: 21480
		[Token(Token = "0x40053E8")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x040053E9 RID: 21481
		[Token(Token = "0x40053E9")]
		[FieldOffset(Offset = "0x18")]
		public string Name;
	}
}
