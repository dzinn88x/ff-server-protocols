using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000963 RID: 2403
	[Token(Token = "0x2000963")]
	[ProtoContract]
	public class CSAddMoneyHeistHelpReq
	{
		// Token: 0x06002671 RID: 9841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x21B02DC", Offset = "0x21B02DC", VA = "0x7BBC9B02DC")]
		public CSAddMoneyHeistHelpReq()
		{
		}

		// Token: 0x04002BEA RID: 11242
		[Token(Token = "0x4002BEA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119550", Offset = "0x1119550")]
		public ulong be_helped_id;
	}
}
