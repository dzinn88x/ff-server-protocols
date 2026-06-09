using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001316 RID: 4886
	[Token(Token = "0x2001316")]
	internal class SparkEventData_LootAirDrop : SparkEventData_Base
	{
		// Token: 0x06004D6D RID: 19821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D6D")]
		[Address(RVA = "0x1B3B958", Offset = "0x1B3B958", VA = "0x7BBC33B958", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D6E")]
		[Address(RVA = "0x1B3B9A0", Offset = "0x1B3B9A0", VA = "0x7BBC33B9A0")]
		public SparkEventData_LootAirDrop()
		{
		}

		// Token: 0x04007519 RID: 29977
		[Token(Token = "0x4007519")]
		[FieldOffset(Offset = "0x18")]
		public uint[] item_ids;
	}
}
