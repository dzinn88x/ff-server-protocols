using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010C1 RID: 4289
	[Token(Token = "0x20010C1")]
	public class ClimbingTriggerSettingData : CSVBaseData
	{
		// Token: 0x060042E4 RID: 17124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042E4")]
		[Address(RVA = "0x14F9E38", Offset = "0x14F9E38", VA = "0x7BBBCF9E38", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042E5 RID: 17125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E5")]
		[Address(RVA = "0x14F9E44", Offset = "0x14F9E44", VA = "0x7BBBCF9E44", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042E6")]
		[Address(RVA = "0x14F9F00", Offset = "0x14F9F00", VA = "0x7BBBCF9F00")]
		public ClimbingTriggerSettingData()
		{
		}

		// Token: 0x04005208 RID: 21000
		[Token(Token = "0x4005208")]
		[FieldOffset(Offset = "0x10")]
		public uint uniqueID;

		// Token: 0x04005209 RID: 21001
		[Token(Token = "0x4005209")]
		[FieldOffset(Offset = "0x14")]
		public bool enbale;
	}
}
