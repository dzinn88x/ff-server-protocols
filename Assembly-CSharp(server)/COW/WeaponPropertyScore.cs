using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010CD RID: 4301
	[Token(Token = "0x20010CD")]
	public class WeaponPropertyScore : CSVBaseData, IGetId
	{
		// Token: 0x0600430C RID: 17164 RVA: 0x00014A48 File Offset: 0x00012C48
		[Token(Token = "0x600430C")]
		[Address(RVA = "0x179C11C", Offset = "0x179C11C", VA = "0x7BBBF9C11C", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600430D")]
		[Address(RVA = "0x179C124", Offset = "0x179C124", VA = "0x7BBBF9C124", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600430E")]
		[Address(RVA = "0x179C130", Offset = "0x179C130", VA = "0x7BBBF9C130", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600430F")]
		[Address(RVA = "0x179C7D8", Offset = "0x179C7D8", VA = "0x7BBBF9C7D8")]
		public WeaponPropertyScore()
		{
		}

		// Token: 0x0400527F RID: 21119
		[Token(Token = "0x400527F")]
		[FieldOffset(Offset = "0x10")]
		public int[] Property;

		// Token: 0x04005280 RID: 21120
		[Token(Token = "0x4005280")]
		[FieldOffset(Offset = "0x18")]
		public uint WeaponID;
	}
}
