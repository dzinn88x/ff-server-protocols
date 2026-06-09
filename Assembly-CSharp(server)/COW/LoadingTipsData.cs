using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200112D RID: 4397
	[Token(Token = "0x200112D")]
	public class LoadingTipsData : CSVBaseData
	{
		// Token: 0x060044BB RID: 17595 RVA: 0x000150A8 File Offset: 0x000132A8
		[Token(Token = "0x60044BB")]
		[Address(RVA = "0x14060D0", Offset = "0x14060D0", VA = "0x7BBBC060D0")]
		public uint GetId()
		{
			return 0U;
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044BC")]
		[Address(RVA = "0x14060D8", Offset = "0x14060D8", VA = "0x7BBBC060D8", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BD")]
		[Address(RVA = "0x14060E4", Offset = "0x14060E4", VA = "0x7BBBC060E4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044BE RID: 17598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BE")]
		[Address(RVA = "0x1406208", Offset = "0x1406208", VA = "0x7BBBC06208")]
		public LoadingTipsData()
		{
		}

		// Token: 0x040054E8 RID: 21736
		[Token(Token = "0x40054E8")]
		[FieldOffset(Offset = "0x10")]
		public uint iID;

		// Token: 0x040054E9 RID: 21737
		[Token(Token = "0x40054E9")]
		[FieldOffset(Offset = "0x14")]
		public uint minLevel;

		// Token: 0x040054EA RID: 21738
		[Token(Token = "0x40054EA")]
		[FieldOffset(Offset = "0x18")]
		public uint maxLevel;

		// Token: 0x040054EB RID: 21739
		[Token(Token = "0x40054EB")]
		[FieldOffset(Offset = "0x1C")]
		public uint modeId;

		// Token: 0x040054EC RID: 21740
		[Token(Token = "0x40054EC")]
		[FieldOffset(Offset = "0x20")]
		public string tipsContent;
	}
}
