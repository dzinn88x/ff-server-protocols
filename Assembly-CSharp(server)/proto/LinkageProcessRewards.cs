using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000938 RID: 2360
	[Token(Token = "0x2000938")]
	[ProtoContract]
	public class LinkageProcessRewards
	{
		// Token: 0x06002646 RID: 9798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002646")]
		[Address(RVA = "0x21BBC38", Offset = "0x21BBC38", VA = "0x7BBC9BBC38")]
		public LinkageProcessRewards()
		{
		}

		// Token: 0x04002B97 RID: 11159
		[Token(Token = "0x4002B97")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118D94", Offset = "0x1118D94")]
		public uint process_id;

		// Token: 0x04002B98 RID: 11160
		[Token(Token = "0x4002B98")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118DA8", Offset = "0x1118DA8")]
		public EPProcess_Status status;

		// Token: 0x04002B99 RID: 11161
		[Token(Token = "0x4002B99")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118DBC", Offset = "0x1118DBC")]
		public ulong target_value;
	}
}
