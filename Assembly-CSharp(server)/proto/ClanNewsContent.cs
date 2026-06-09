using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000629 RID: 1577
	[Token(Token = "0x2000629")]
	[ProtoContract]
	public class ClanNewsContent
	{
		// Token: 0x0600239A RID: 9114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x21B8950", Offset = "0x21B8950", VA = "0x7BBC9B8950")]
		public ClanNewsContent()
		{
		}

		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107F30", Offset = "0x1107F30")]
		public ulong account_id;

		// Token: 0x04001F67 RID: 8039
		[Token(Token = "0x4001F67")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107F44", Offset = "0x1107F44")]
		public uint member_type;

		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107F58", Offset = "0x1107F58")]
		public uint level;
	}
}
