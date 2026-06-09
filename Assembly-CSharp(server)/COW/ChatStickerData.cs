using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010BB RID: 4283
	[Token(Token = "0x20010BB")]
	public class ChatStickerData : CSVBaseData
	{
		// Token: 0x060042CD RID: 17101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x14F5D88", Offset = "0x14F5D88", VA = "0x7BBBCF5D88", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x14F5DFC", Offset = "0x14F5DFC", VA = "0x7BBBCF5DFC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x00014970 File Offset: 0x00012B70
		[Token(Token = "0x60042CF")]
		[Address(RVA = "0x14F60EC", Offset = "0x14F60EC", VA = "0x7BBBCF60EC")]
		public static bool IsThisASticker(string strMsg)
		{
			return default(bool);
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D0")]
		[Address(RVA = "0x14F62AC", Offset = "0x14F62AC", VA = "0x7BBBCF62AC")]
		public static ChatStickerData IsThisASticker(string strMsg, out bool isSticker, out uint itemid)
		{
			return null;
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D1")]
		[Address(RVA = "0x14F5FCC", Offset = "0x14F5FCC", VA = "0x7BBBCF5FCC")]
		public static List<ChatStickerData> GetChatStickerDatas(uint itemID)
		{
			return null;
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D2")]
		[Address(RVA = "0x14F64A8", Offset = "0x14F64A8", VA = "0x7BBBCF64A8")]
		public ChatStickerData()
		{
		}

		// Token: 0x040051F1 RID: 20977
		[Token(Token = "0x40051F1")]
		[FieldOffset(Offset = "0x10")]
		public uint ItemID;

		// Token: 0x040051F2 RID: 20978
		[Token(Token = "0x40051F2")]
		[FieldOffset(Offset = "0x14")]
		public uint StickerID;

		// Token: 0x040051F3 RID: 20979
		[Token(Token = "0x40051F3")]
		[FieldOffset(Offset = "0x18")]
		public ResourceID ResourceName;

		// Token: 0x040051F4 RID: 20980
		[Token(Token = "0x40051F4")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<uint, List<ChatStickerData>> m_StickerSpriteDic;
	}
}
