using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200113D RID: 4413
	[Token(Token = "0x200113D")]
	public class MailContentData : CSVBaseData
	{
		// Token: 0x060044EB RID: 17643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EB")]
		[Address(RVA = "0x1A55AA4", Offset = "0x1A55AA4", VA = "0x7BBC255AA4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060044EC RID: 17644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EC")]
		[Address(RVA = "0x1A55B98", Offset = "0x1A55B98", VA = "0x7BBC255B98", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060044ED RID: 17645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0x1A55BA4", Offset = "0x1A55BA4", VA = "0x7BBC255BA4")]
		public MailContentData()
		{
		}

		// Token: 0x0400550D RID: 21773
		[Token(Token = "0x400550D")]
		[FieldOffset(Offset = "0x10")]
		public int ID;

		// Token: 0x0400550E RID: 21774
		[Token(Token = "0x400550E")]
		[FieldOffset(Offset = "0x18")]
		public string Title;

		// Token: 0x0400550F RID: 21775
		[Token(Token = "0x400550F")]
		[FieldOffset(Offset = "0x20")]
		public string Content;
	}
}
