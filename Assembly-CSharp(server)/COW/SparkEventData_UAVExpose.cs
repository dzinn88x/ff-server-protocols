using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001318 RID: 4888
	[Token(Token = "0x2001318")]
	internal class SparkEventData_UAVExpose : SparkEventData_Base
	{
		// Token: 0x06004D71 RID: 19825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D71")]
		[Address(RVA = "0x1B3BB88", Offset = "0x1B3BB88", VA = "0x7BBC33BB88", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D72")]
		[Address(RVA = "0x1B3BBD0", Offset = "0x1B3BBD0", VA = "0x7BBC33BBD0")]
		public SparkEventData_UAVExpose()
		{
		}

		// Token: 0x0400751B RID: 29979
		[Token(Token = "0x400751B")]
		[FieldOffset(Offset = "0x18")]
		public ulong[] account_ids;
	}
}
