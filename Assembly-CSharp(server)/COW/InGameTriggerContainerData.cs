using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001110 RID: 4368
	[Token(Token = "0x2001110")]
	public class InGameTriggerContainerData : CSVBaseData
	{
		// Token: 0x06004466 RID: 17510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004466")]
		[Address(RVA = "0x185CF9C", Offset = "0x185CF9C", VA = "0x7BBC05CF9C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004467")]
		[Address(RVA = "0x185CFA8", Offset = "0x185CFA8", VA = "0x7BBC05CFA8", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004468")]
		[Address(RVA = "0x185D0C8", Offset = "0x185D0C8", VA = "0x7BBC05D0C8")]
		public InGameTriggerContainerData()
		{
		}

		// Token: 0x04005459 RID: 21593
		[Token(Token = "0x4005459")]
		[FieldOffset(Offset = "0x10")]
		public uint TriggerType;

		// Token: 0x0400545A RID: 21594
		[Token(Token = "0x400545A")]
		[FieldOffset(Offset = "0x18")]
		public string TriggerName;

		// Token: 0x0400545B RID: 21595
		[Token(Token = "0x400545B")]
		[FieldOffset(Offset = "0x20")]
		public ResourceID TriggerIcon;
	}
}
