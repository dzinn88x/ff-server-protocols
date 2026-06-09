using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200062A RID: 1578
	[Token(Token = "0x200062A")]
	[ProtoContract]
	public class ClanNews
	{
		// Token: 0x0600239B RID: 9115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x21B8948", Offset = "0x21B8948", VA = "0x7BBC9B8948")]
		public ClanNews()
		{
		}

		// Token: 0x04001F69 RID: 8041
		[Token(Token = "0x4001F69")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107F6C", Offset = "0x1107F6C")]
		public EClan.NewsType type;

		// Token: 0x04001F6A RID: 8042
		[Token(Token = "0x4001F6A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107F80", Offset = "0x1107F80")]
		public ClanNewsContent content;

		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107F94", Offset = "0x1107F94")]
		public ulong update_time;
	}
}
