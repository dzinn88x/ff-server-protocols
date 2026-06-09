using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010F9 RID: 4345
	[Token(Token = "0x20010F9")]
	public class EventTriggerData : CSVBaseData
	{
		// Token: 0x060043D7 RID: 17367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043D7")]
		[Address(RVA = "0x1B94EA0", Offset = "0x1B94EA0", VA = "0x7BBC394EA0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D8")]
		[Address(RVA = "0x1B94EAC", Offset = "0x1B94EAC", VA = "0x7BBC394EAC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043D9")]
		[Address(RVA = "0x1B95018", Offset = "0x1B95018", VA = "0x7BBC395018")]
		public EventTriggerData()
		{
		}

		// Token: 0x040053E1 RID: 21473
		[Token(Token = "0x40053E1")]
		[FieldOffset(Offset = "0x10")]
		public uint ID;

		// Token: 0x040053E2 RID: 21474
		[Token(Token = "0x40053E2")]
		[FieldOffset(Offset = "0x14")]
		public uint BehaviorType1;

		// Token: 0x040053E3 RID: 21475
		[Token(Token = "0x40053E3")]
		[FieldOffset(Offset = "0x18")]
		public uint value1;

		// Token: 0x040053E4 RID: 21476
		[Token(Token = "0x40053E4")]
		[FieldOffset(Offset = "0x1C")]
		public uint BehaviorType2;

		// Token: 0x040053E5 RID: 21477
		[Token(Token = "0x40053E5")]
		[FieldOffset(Offset = "0x20")]
		public uint value2;

		// Token: 0x040053E6 RID: 21478
		[Token(Token = "0x40053E6")]
		[FieldOffset(Offset = "0x24")]
		public uint BehaviorType3;

		// Token: 0x040053E7 RID: 21479
		[Token(Token = "0x40053E7")]
		[FieldOffset(Offset = "0x28")]
		public uint value3;
	}
}
