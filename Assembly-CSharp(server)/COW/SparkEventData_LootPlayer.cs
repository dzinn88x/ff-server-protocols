using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001317 RID: 4887
	[Token(Token = "0x2001317")]
	internal class SparkEventData_LootPlayer : SparkEventData_Base
	{
		// Token: 0x06004D6F RID: 19823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6F")]
		[Address(RVA = "0x1B3B9A8", Offset = "0x1B3B9A8", VA = "0x7BBC33B9A8", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D70")]
		[Address(RVA = "0x1B3B9F0", Offset = "0x1B3B9F0", VA = "0x7BBC33B9F0")]
		public SparkEventData_LootPlayer()
		{
		}

		// Token: 0x0400751A RID: 29978
		[Token(Token = "0x400751A")]
		[FieldOffset(Offset = "0x18")]
		public uint[] item_ids;
	}
}
