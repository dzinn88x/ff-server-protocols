using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001307 RID: 4871
	[Token(Token = "0x2001307")]
	internal abstract class SparkEventData_Base
	{
		// Token: 0x06004D4F RID: 19791
		[Token(Token = "0x6004D4F")]
		public abstract string GetEventType();

		// Token: 0x06004D50 RID: 19792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D50")]
		[Address(RVA = "0x1B3B540", Offset = "0x1B3B540", VA = "0x7BBC33B540")]
		protected SparkEventData_Base()
		{
		}

		// Token: 0x040074FA RID: 29946
		[Token(Token = "0x40074FA")]
		[FieldOffset(Offset = "0x10")]
		public ulong match_id;
	}
}
