using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010CC RID: 4300
	[Token(Token = "0x20010CC")]
	public class WeaponScoreName : CSVBaseData
	{
		// Token: 0x06004309 RID: 17161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004309")]
		[Address(RVA = "0x179D2DC", Offset = "0x179D2DC", VA = "0x7BBBF9D2DC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600430A")]
		[Address(RVA = "0x179D2E8", Offset = "0x179D2E8", VA = "0x7BBBF9D2E8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600430B")]
		[Address(RVA = "0x179D414", Offset = "0x179D414", VA = "0x7BBBF9D414")]
		public WeaponScoreName()
		{
		}

		// Token: 0x0400527D RID: 21117
		[Token(Token = "0x400527D")]
		[FieldOffset(Offset = "0x10")]
		public string scoreName;

		// Token: 0x0400527E RID: 21118
		[Token(Token = "0x400527E")]
		[FieldOffset(Offset = "0x18")]
		public uint scoreId;
	}
}
