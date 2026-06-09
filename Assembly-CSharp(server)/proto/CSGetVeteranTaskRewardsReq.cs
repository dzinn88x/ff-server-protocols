using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000947 RID: 2375
	[Token(Token = "0x2000947")]
	[ProtoContract]
	public class CSGetVeteranTaskRewardsReq
	{
		// Token: 0x06002655 RID: 9813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x21B6280", Offset = "0x21B6280", VA = "0x7BBC9B6280")]
		public CSGetVeteranTaskRewardsReq()
		{
		}

		// Token: 0x04002BB6 RID: 11190
		[Token(Token = "0x4002BB6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119078", Offset = "0x1119078")]
		public uint[] task_ids;
	}
}
