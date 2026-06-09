using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F9E RID: 3998
	[Token(Token = "0x2000F9E")]
	public class PRIDataPool : ReplicationDataPool
	{
		// Token: 0x06003A37 RID: 14903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A37")]
		[Address(RVA = "0x246D5D0", Offset = "0x246D5D0", VA = "0x7BBCC6D5D0")]
		public PRIDataPool(ReplicationEntity owner, uint repID, int maxVarCount)
		{
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x00012048 File Offset: 0x00010248
		[Token(Token = "0x6003A38")]
		[Address(RVA = "0x246D610", Offset = "0x246D610", VA = "0x7BBCC6D610")]
		public uint GetReplicationID()
		{
			return 0U;
		}

		// Token: 0x04004BCD RID: 19405
		[Token(Token = "0x4004BCD")]
		[FieldOffset(Offset = "0x28")]
		protected ReplicationEntity m_Owner;

		// Token: 0x04004BCE RID: 19406
		[Token(Token = "0x4004BCE")]
		[FieldOffset(Offset = "0x30")]
		protected uint m_ReplicationID;
	}
}
