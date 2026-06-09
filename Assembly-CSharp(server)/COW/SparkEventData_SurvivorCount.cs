using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200131D RID: 4893
	[Token(Token = "0x200131D")]
	internal class SparkEventData_SurvivorCount : SparkEventData_Base
	{
		// Token: 0x06004D7B RID: 19835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D7B")]
		[Address(RVA = "0x1B3BB38", Offset = "0x1B3BB38", VA = "0x7BBC33BB38", Slot = "4")]
		public override string GetEventType()
		{
			return null;
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D7C")]
		[Address(RVA = "0x1B3BB80", Offset = "0x1B3BB80", VA = "0x7BBC33BB80")]
		public SparkEventData_SurvivorCount()
		{
		}

		// Token: 0x04007523 RID: 29987
		[Token(Token = "0x4007523")]
		[FieldOffset(Offset = "0x18")]
		public int survivor_count;
	}
}
