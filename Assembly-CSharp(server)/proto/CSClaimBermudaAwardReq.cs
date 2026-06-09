using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200097D RID: 2429
	[Token(Token = "0x200097D")]
	[ProtoContract]
	public class CSClaimBermudaAwardReq
	{
		// Token: 0x0600268B RID: 9867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x21B0780", Offset = "0x21B0780", VA = "0x7BBC9B0780")]
		public CSClaimBermudaAwardReq()
		{
		}

		// Token: 0x04002C21 RID: 11297
		[Token(Token = "0x4002C21")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119A78", Offset = "0x1119A78")]
		public uint group_id;

		// Token: 0x04002C22 RID: 11298
		[Token(Token = "0x4002C22")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119A8C", Offset = "0x1119A8C")]
		public uint id;
	}
}
