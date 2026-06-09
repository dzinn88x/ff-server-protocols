using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000647 RID: 1607
	[Token(Token = "0x2000647")]
	[ProtoContract]
	public class GainedTrainingToken
	{
		// Token: 0x060023B1 RID: 9137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x21BA648", Offset = "0x21BA648", VA = "0x7BBC9BA648")]
		public GainedTrainingToken()
		{
		}

		// Token: 0x04001FC1 RID: 8129
		[Token(Token = "0x4001FC1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11084BC", Offset = "0x11084BC")]
		public uint token_id;

		// Token: 0x04001FC2 RID: 8130
		[Token(Token = "0x4001FC2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11084D0", Offset = "0x11084D0")]
		public uint gained_cnt;

		// Token: 0x04001FC3 RID: 8131
		[Token(Token = "0x4001FC3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11084E4", Offset = "0x11084E4")]
		public int delta_cnt;
	}
}
