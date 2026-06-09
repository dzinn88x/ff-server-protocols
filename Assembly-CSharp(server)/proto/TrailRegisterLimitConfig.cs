using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF3 RID: 2803
	[Token(Token = "0x2000AF3")]
	[ProtoContract]
	public class TrailRegisterLimitConfig
	{
		// Token: 0x060027FB RID: 10235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x24A1110", Offset = "0x24A1110", VA = "0x7BBCCA1110")]
		public TrailRegisterLimitConfig()
		{
		}

		// Token: 0x040034D3 RID: 13523
		[Token(Token = "0x40034D3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129540", Offset = "0x1129540")]
		public bool is_open;
	}
}
