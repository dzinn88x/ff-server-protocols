using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF1 RID: 2801
	[Token(Token = "0x2000AF1")]
	[ProtoContract]
	public class ClientVersionDesc
	{
		// Token: 0x060027F9 RID: 10233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x21B8D80", Offset = "0x21B8D80", VA = "0x7BBC9B8D80")]
		public ClientVersionDesc()
		{
		}

		// Token: 0x040034D0 RID: 13520
		[Token(Token = "0x40034D0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112948C", Offset = "0x112948C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112948C", Offset = "0x112948C")]
		public string client_version;
	}
}
