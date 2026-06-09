using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001098 RID: 4248
	[Token(Token = "0x2001098")]
	public class AssistantTriggerInfoData : CSVBaseData
	{
		// Token: 0x06004191 RID: 16785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004191")]
		[Address(RVA = "0x155256C", Offset = "0x155256C", VA = "0x7BBBD5256C", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004192")]
		[Address(RVA = "0x1552578", Offset = "0x1552578", VA = "0x7BBBD52578", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004193")]
		[Address(RVA = "0x1552678", Offset = "0x1552678", VA = "0x7BBBD52678")]
		public AssistantTriggerInfoData()
		{
		}

		// Token: 0x040050D3 RID: 20691
		[Token(Token = "0x40050D3")]
		[FieldOffset(Offset = "0x10")]
		public uint AssistantID;

		// Token: 0x040050D4 RID: 20692
		[Token(Token = "0x40050D4")]
		[FieldOffset(Offset = "0x14")]
		public float CoolDown;

		// Token: 0x040050D5 RID: 20693
		[Token(Token = "0x40050D5")]
		[FieldOffset(Offset = "0x18")]
		public uint BroadcastType;

		// Token: 0x040050D6 RID: 20694
		[Token(Token = "0x40050D6")]
		[FieldOffset(Offset = "0x1C")]
		public uint Priority;
	}
}
