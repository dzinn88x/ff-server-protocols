using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200131C RID: 4892
	[Token(Token = "0x200131C")]
	internal class SparkEventData_BattlePassLevel : SparkEventData_Base
	{
		// Token: 0x06004D79 RID: 19833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x1B3B548", Offset = "0x1B3B548", VA = "0x7BBC33B548", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7A")]
		[Address(RVA = "0x1B3B590", Offset = "0x1B3B590", VA = "0x7BBC33B590")]
		public SparkEventData_BattlePassLevel()
		{
		}

		// Token: 0x04007521 RID: 29985
		[Token(Token = "0x4007521")]
		[FieldOffset(Offset = "0x18")]
		public uint pass_level;

		// Token: 0x04007522 RID: 29986
		[Token(Token = "0x4007522")]
		[FieldOffset(Offset = "0x1C")]
		public bool is_elite;
	}
}
