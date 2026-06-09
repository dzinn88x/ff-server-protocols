using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011AA RID: 4522
	[Token(Token = "0x20011AA")]
	public class WereWolvesQuickChatData : CSVBaseData, IGetId
	{
		// Token: 0x06004656 RID: 18006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004656")]
		[Address(RVA = "0x23DF2FC", Offset = "0x23DF2FC", VA = "0x7BBCBDF2FC", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x6004657")]
		[Address(RVA = "0x23DF308", Offset = "0x23DF308", VA = "0x7BBCBDF308", Slot = "9")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004658")]
		[Address(RVA = "0x23DF310", Offset = "0x23DF310", VA = "0x7BBCBDF310", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004659")]
		[Address(RVA = "0x23DF414", Offset = "0x23DF414", VA = "0x7BBCBDF414")]
		public string GetChatString({QAb\u0082~u playerId)
		{
			return null;
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600465A")]
		[Address(RVA = "0x23DF694", Offset = "0x23DF694", VA = "0x7BBCBDF694")]
		public WereWolvesQuickChatData()
		{
		}

		// Token: 0x040057A5 RID: 22437
		[Token(Token = "0x40057A5")]
		[FieldOffset(Offset = "0x10")]
		public uint Id;

		// Token: 0x040057A6 RID: 22438
		[Token(Token = "0x40057A6")]
		[FieldOffset(Offset = "0x18")]
		public string ChatVis;

		// Token: 0x040057A7 RID: 22439
		[Token(Token = "0x40057A7")]
		[FieldOffset(Offset = "0x20")]
		public string ChatFormat;

		// Token: 0x040057A8 RID: 22440
		[Token(Token = "0x40057A8")]
		[FieldOffset(Offset = "0x28")]
		public bool HasTarget;
	}
}
