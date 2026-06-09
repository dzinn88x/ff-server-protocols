using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010BF RID: 4287
	[Token(Token = "0x20010BF")]
	public class ClanRenameData : CSVBaseData
	{
		// Token: 0x060042DE RID: 17118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042DE")]
		[Address(RVA = "0x14F98A8", Offset = "0x14F98A8", VA = "0x7BBBCF98A8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042DF RID: 17119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042DF")]
		[Address(RVA = "0x14F98B4", Offset = "0x14F98B4", VA = "0x7BBBCF98B4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E0")]
		[Address(RVA = "0x14F996C", Offset = "0x14F996C", VA = "0x7BBBCF996C")]
		public ClanRenameData()
		{
		}

		// Token: 0x04005202 RID: 20994
		[Token(Token = "0x4005202")]
		[FieldOffset(Offset = "0x10")]
		public int Id;

		// Token: 0x04005203 RID: 20995
		[Token(Token = "0x4005203")]
		[FieldOffset(Offset = "0x14")]
		public int DiamondCost;
	}
}
