using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001113 RID: 4371
	[Token(Token = "0x2001113")]
	public class ItemRareOverriteData : CSVBaseData, IGetId
	{
		// Token: 0x06004470 RID: 17520 RVA: 0x00015000 File Offset: 0x00013200
		[Token(Token = "0x6004470")]
		[Address(RVA = "0x13F4158", Offset = "0x13F4158", VA = "0x7BBBBF4158", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004471")]
		[Address(RVA = "0x13F4160", Offset = "0x13F4160", VA = "0x7BBBBF4160", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004472")]
		[Address(RVA = "0x13F416C", Offset = "0x13F416C", VA = "0x7BBBBF416C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004473")]
		[Address(RVA = "0x13F4224", Offset = "0x13F4224", VA = "0x7BBBBF4224")]
		public ItemRareOverriteData()
		{
		}

		// Token: 0x0400546A RID: 21610
		[Token(Token = "0x400546A")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x0400546B RID: 21611
		[Token(Token = "0x400546B")]
		[FieldOffset(Offset = "0x14")]
		public uint Quality;
	}
}
