using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000768 RID: 1896
	[Token(Token = "0x2000768")]
	[ProtoContract]
	public class CSChooseLoadoutReq
	{
		// Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x21B0678", Offset = "0x21B0678", VA = "0x7BBC9B0678")]
		public CSChooseLoadoutReq()
		{
		}

		// Token: 0x04002521 RID: 9505
		[Token(Token = "0x4002521")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D750", Offset = "0x110D750")]
		public uint[] loadouts;

		// Token: 0x04002522 RID: 9506
		[Token(Token = "0x4002522")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D78C", Offset = "0x110D78C")]
		public ulong group_id;

		// Token: 0x04002523 RID: 9507
		[Token(Token = "0x4002523")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D7A0", Offset = "0x110D7A0")]
		public ulong room_id;
	}
}
