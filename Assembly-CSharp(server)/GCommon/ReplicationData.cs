using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F9B RID: 3995
	[Token(Token = "0x2000F9B")]
	public class ReplicationData
	{
		// Token: 0x06003A2B RID: 14891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A2B")]
		[Address(RVA = "0x295EF40", Offset = "0x295EF40", VA = "0x7BBD15EF40")]
		public ReplicationData()
		{
		}

		// Token: 0x04004BC8 RID: 19400
		[Token(Token = "0x4004BC8")]
		[FieldOffset(Offset = "0x10")]
		public EReplicationInfoGroup GroupID;

		// Token: 0x04004BC9 RID: 19401
		[Token(Token = "0x4004BC9")]
		[FieldOffset(Offset = "0x18")]
		public object Value;
	}
}
