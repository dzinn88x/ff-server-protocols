using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001108 RID: 4360
	[Token(Token = "0x2001108")]
	public class GroupRecruitTagData : CSVBaseData
	{
		// Token: 0x0600441E RID: 17438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600441E")]
		[Address(RVA = "0x17667A4", Offset = "0x17667A4", VA = "0x7BBBF667A4", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600441F")]
		[Address(RVA = "0x17667B0", Offset = "0x17667B0", VA = "0x7BBBF667B0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004420")]
		[Address(RVA = "0x1766868", Offset = "0x1766868", VA = "0x7BBBF66868")]
		public GroupRecruitTagData()
		{
		}

		// Token: 0x04005423 RID: 21539
		[Token(Token = "0x4005423")]
		[FieldOffset(Offset = "0x10")]
		public uint m_ID;

		// Token: 0x04005424 RID: 21540
		[Token(Token = "0x4005424")]
		[FieldOffset(Offset = "0x18")]
		public string m_LocKey;
	}
}
