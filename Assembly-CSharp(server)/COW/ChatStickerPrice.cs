using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010BC RID: 4284
	[Token(Token = "0x20010BC")]
	public class ChatStickerPrice : CSVBaseData
	{
		// Token: 0x060042D4 RID: 17108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D4")]
		[Address(RVA = "0x14F6584", Offset = "0x14F6584", VA = "0x7BBBCF6584", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D5")]
		[Address(RVA = "0x14F6590", Offset = "0x14F6590", VA = "0x7BBBCF6590", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D6")]
		[Address(RVA = "0x14F66A0", Offset = "0x14F66A0", VA = "0x7BBBCF66A0")]
		public static List<ChatStickerPrice> GetChatStickerPrices()
		{
			return null;
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x14F689C", Offset = "0x14F689C", VA = "0x7BBBCF689C")]
		public ChatStickerPrice()
		{
		}

		// Token: 0x040051F5 RID: 20981
		[Token(Token = "0x40051F5")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040051F6 RID: 20982
		[Token(Token = "0x40051F6")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x040051F7 RID: 20983
		[Token(Token = "0x40051F7")]
		[FieldOffset(Offset = "0x20")]
		public uint GemsPrice;

		// Token: 0x040051F8 RID: 20984
		[Token(Token = "0x40051F8")]
		[FieldOffset(Offset = "0x24")]
		public uint CoinsPrice;

		// Token: 0x040051F9 RID: 20985
		[Token(Token = "0x40051F9")]
		[FieldOffset(Offset = "0x28")]
		public ResourceID Icon;
	}
}
