using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001184 RID: 4484
	[Token(Token = "0x2001184")]
	public class RoomCreateCSShopData : CSVBaseData
	{
		// Token: 0x060045C4 RID: 17860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0x1B2EB34", Offset = "0x1B2EB34", VA = "0x7BBC32EB34", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x1B2EB40", Offset = "0x1B2EB40", VA = "0x7BBC32EB40", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x1B2ED44", Offset = "0x1B2ED44", VA = "0x7BBC32ED44")]
		public RoomCreateCSShopData()
		{
		}

		// Token: 0x040056CD RID: 22221
		[Token(Token = "0x40056CD")]
		[FieldOffset(Offset = "0x10")]
		public uint Index;

		// Token: 0x040056CE RID: 22222
		[Token(Token = "0x40056CE")]
		[FieldOffset(Offset = "0x14")]
		public uint ItemId;

		// Token: 0x040056CF RID: 22223
		[Token(Token = "0x40056CF")]
		[FieldOffset(Offset = "0x18")]
		public int Price;

		// Token: 0x040056D0 RID: 22224
		[Token(Token = "0x40056D0")]
		[FieldOffset(Offset = "0x1C")]
		public uint TypeTab;

		// Token: 0x040056D1 RID: 22225
		[Token(Token = "0x40056D1")]
		[FieldOffset(Offset = "0x20")]
		public bool IsOpen;

		// Token: 0x040056D2 RID: 22226
		[Token(Token = "0x40056D2")]
		[FieldOffset(Offset = "0x21")]
		public bool Selected;
	}
}
