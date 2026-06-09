using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200130E RID: 4878
	[Token(Token = "0x200130E")]
	internal class SparkEventData_DamageTaken : SparkEventData_Base
	{
		// Token: 0x06004D5D RID: 19805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0x1B3B5E8", Offset = "0x1B3B5E8", VA = "0x7BBC33B5E8", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0x1B3B630", Offset = "0x1B3B630", VA = "0x7BBC33B630")]
		public SparkEventData_DamageTaken()
		{
		}

		// Token: 0x04007508 RID: 29960
		[Token(Token = "0x4007508")]
		[FieldOffset(Offset = "0x18")]
		public ulong from_account_id;

		// Token: 0x04007509 RID: 29961
		[Token(Token = "0x4007509")]
		[FieldOffset(Offset = "0x20")]
		public int damage_taken;

		// Token: 0x0400750A RID: 29962
		[Token(Token = "0x400750A")]
		[FieldOffset(Offset = "0x24")]
		public int remaining_hp;

		// Token: 0x0400750B RID: 29963
		[Token(Token = "0x400750B")]
		[FieldOffset(Offset = "0x28")]
		public int weapon_id;
	}
}
