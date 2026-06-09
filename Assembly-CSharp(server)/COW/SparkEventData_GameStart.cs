using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001309 RID: 4873
	[Token(Token = "0x2001309")]
	internal class SparkEventData_GameStart : SparkEventData_Base
	{
		// Token: 0x06004D53 RID: 19795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D53")]
		[Address(RVA = "0x1B3B7C8", Offset = "0x1B3B7C8", VA = "0x7BBC33B7C8", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D54")]
		[Address(RVA = "0x1B3B810", Offset = "0x1B3B810", VA = "0x7BBC33B810")]
		public SparkEventData_GameStart()
		{
		}

		// Token: 0x040074FE RID: 29950
		[Token(Token = "0x40074FE")]
		[FieldOffset(Offset = "0x18")]
		public uint group_mode;

		// Token: 0x040074FF RID: 29951
		[Token(Token = "0x40074FF")]
		[FieldOffset(Offset = "0x1C")]
		public uint game_mode;

		// Token: 0x04007500 RID: 29952
		[Token(Token = "0x4007500")]
		[FieldOffset(Offset = "0x20")]
		public uint match_mode;

		// Token: 0x04007501 RID: 29953
		[Token(Token = "0x4007501")]
		[FieldOffset(Offset = "0x24")]
		public uint map_id;
	}
}
