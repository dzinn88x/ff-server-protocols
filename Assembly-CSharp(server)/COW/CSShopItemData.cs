using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010DC RID: 4316
	[Token(Token = "0x20010DC")]
	public class CSShopItemData : CSVBaseData, IGetId
	{
		// Token: 0x0600435C RID: 17244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600435C")]
		[Address(RVA = "0x14F3B30", Offset = "0x14F3B30", VA = "0x7BBBCF3B30", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x00014B80 File Offset: 0x00012D80
		[Token(Token = "0x600435D")]
		[Address(RVA = "0x14F3B3C", Offset = "0x14F3B3C", VA = "0x7BBBCF3B3C", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435E")]
		[Address(RVA = "0x14F3B44", Offset = "0x14F3B44", VA = "0x7BBBCF3B44", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435F")]
		[Address(RVA = "0x14F3D88", Offset = "0x14F3D88", VA = "0x7BBBCF3D88")]
		public CSShopItemData()
		{
		}

		// Token: 0x04005312 RID: 21266
		[Token(Token = "0x4005312")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x04005313 RID: 21267
		[Token(Token = "0x4005313")]
		[FieldOffset(Offset = "0x14")]
		public uint price;

		// Token: 0x04005314 RID: 21268
		[Token(Token = "0x4005314")]
		[FieldOffset(Offset = "0x18")]
		public uint filter;

		// Token: 0x04005315 RID: 21269
		[Token(Token = "0x4005315")]
		[FieldOffset(Offset = "0x1C")]
		public bool bonus;

		// Token: 0x04005316 RID: 21270
		[Token(Token = "0x4005316")]
		[FieldOffset(Offset = "0x20")]
		public uint limitation;

		// Token: 0x04005317 RID: 21271
		[Token(Token = "0x4005317")]
		[FieldOffset(Offset = "0x24")]
		public uint stack;
	}
}
