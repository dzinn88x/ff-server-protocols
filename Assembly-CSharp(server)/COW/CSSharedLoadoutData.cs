using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010DB RID: 4315
	[Token(Token = "0x20010DB")]
	public class CSSharedLoadoutData : CSVBaseData, IGetId
	{
		// Token: 0x06004358 RID: 17240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004358")]
		[Address(RVA = "0x14F3960", Offset = "0x14F3960", VA = "0x7BBBCF3960", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x00014B68 File Offset: 0x00012D68
		[Token(Token = "0x6004359")]
		[Address(RVA = "0x14F396C", Offset = "0x14F396C", VA = "0x7BBBCF396C", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435A")]
		[Address(RVA = "0x14F3974", Offset = "0x14F3974", VA = "0x7BBBCF3974", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600435B")]
		[Address(RVA = "0x14F3AC8", Offset = "0x14F3AC8", VA = "0x7BBBCF3AC8")]
		public CSSharedLoadoutData()
		{
		}

		// Token: 0x0400530C RID: 21260
		[Token(Token = "0x400530C")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x0400530D RID: 21261
		[Token(Token = "0x400530D")]
		[FieldOffset(Offset = "0x14")]
		public uint itemType;

		// Token: 0x0400530E RID: 21262
		[Token(Token = "0x400530E")]
		[FieldOffset(Offset = "0x18")]
		public int pageID;

		// Token: 0x0400530F RID: 21263
		[Token(Token = "0x400530F")]
		[FieldOffset(Offset = "0x1C")]
		public bool isSold;

		// Token: 0x04005310 RID: 21264
		[Token(Token = "0x4005310")]
		[FieldOffset(Offset = "0x20")]
		public uint playCardID;

		// Token: 0x04005311 RID: 21265
		[Token(Token = "0x4005311")]
		[FieldOffset(Offset = "0x28")]
		public string playCardSprite;
	}
}
