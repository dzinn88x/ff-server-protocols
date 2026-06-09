using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007DE RID: 2014
	[Token(Token = "0x20007DE")]
	[ProtoContract]
	public class CSDismissClanReq
	{
		// Token: 0x060024ED RID: 9453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x21B0F58", Offset = "0x21B0F58", VA = "0x7BBC9B0F58")]
		public CSDismissClanReq()
		{
		}

		// Token: 0x04002670 RID: 9840
		[Token(Token = "0x4002670")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FD20", Offset = "0x110FD20")]
		public ulong clan_id;
	}
}
