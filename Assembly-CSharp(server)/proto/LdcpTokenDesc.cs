using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B17 RID: 2839
	[Token(Token = "0x2000B17")]
	[ProtoContract]
	public class LdcpTokenDesc
	{
		// Token: 0x0600281F RID: 10271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281F")]
		[Address(RVA = "0x21BB92C", Offset = "0x21BB92C", VA = "0x7BBC9BB92C")]
		public LdcpTokenDesc()
		{
		}

		// Token: 0x040035E5 RID: 13797
		[Token(Token = "0x40035E5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BC00", Offset = "0x112BC00")]
		public uint token_num;

		// Token: 0x040035E6 RID: 13798
		[Token(Token = "0x40035E6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BC14", Offset = "0x112BC14")]
		public uint efficiency;
	}
}
