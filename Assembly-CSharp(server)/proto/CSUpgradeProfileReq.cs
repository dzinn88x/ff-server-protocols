using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000813 RID: 2067
	[Token(Token = "0x2000813")]
	[ProtoContract]
	public class CSUpgradeProfileReq
	{
		// Token: 0x06002522 RID: 9506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002522")]
		[Address(RVA = "0x21B7C98", Offset = "0x21B7C98", VA = "0x7BBC9B7C98")]
		public CSUpgradeProfileReq()
		{
		}

		// Token: 0x04002710 RID: 10000
		[Token(Token = "0x4002710")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110CE8", Offset = "0x1110CE8")]
		public uint avatar_id;

		// Token: 0x04002711 RID: 10001
		[Token(Token = "0x4002711")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110CFC", Offset = "0x1110CFC")]
		public uint level_card_id;
	}
}
