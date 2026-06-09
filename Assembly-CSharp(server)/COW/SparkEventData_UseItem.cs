using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001319 RID: 4889
	[Token(Token = "0x2001319")]
	internal class SparkEventData_UseItem : SparkEventData_Base
	{
		// Token: 0x06004D73 RID: 19827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D73")]
		[Address(RVA = "0x1B3BBD8", Offset = "0x1B3BBD8", VA = "0x7BBC33BBD8", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D74")]
		[Address(RVA = "0x1B3BC20", Offset = "0x1B3BC20", VA = "0x7BBC33BC20")]
		public SparkEventData_UseItem()
		{
		}

		// Token: 0x0400751C RID: 29980
		[Token(Token = "0x400751C")]
		[FieldOffset(Offset = "0x18")]
		public uint item_id;
	}
}
