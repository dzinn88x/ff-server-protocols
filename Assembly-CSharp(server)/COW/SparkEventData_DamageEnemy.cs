using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200130D RID: 4877
	[Token(Token = "0x200130D")]
	internal class SparkEventData_DamageEnemy : SparkEventData_Base
	{
		// Token: 0x06004D5B RID: 19803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D5B")]
		[Address(RVA = "0x1B3B598", Offset = "0x1B3B598", VA = "0x7BBC33B598", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D5C RID: 19804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0x1B3B5E0", Offset = "0x1B3B5E0", VA = "0x7BBC33B5E0")]
		public SparkEventData_DamageEnemy()
		{
		}

		// Token: 0x04007505 RID: 29957
		[Token(Token = "0x4007505")]
		[FieldOffset(Offset = "0x18")]
		public ulong account_id;

		// Token: 0x04007506 RID: 29958
		[Token(Token = "0x4007506")]
		[FieldOffset(Offset = "0x20")]
		public int damage_dealt;

		// Token: 0x04007507 RID: 29959
		[Token(Token = "0x4007507")]
		[FieldOffset(Offset = "0x24")]
		public int weapon_id;
	}
}
