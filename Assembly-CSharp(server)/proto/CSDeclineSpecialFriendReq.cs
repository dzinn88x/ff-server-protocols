using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000838 RID: 2104
	[Token(Token = "0x2000838")]
	[ProtoContract]
	public class CSDeclineSpecialFriendReq
	{
		// Token: 0x0600254D RID: 9549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254D")]
		[Address(RVA = "0x21B0EDC", Offset = "0x21B0EDC", VA = "0x7BBC9B0EDC")]
		public CSDeclineSpecialFriendReq()
		{
		}

		// Token: 0x04002764 RID: 10084
		[Token(Token = "0x4002764")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11114E0", Offset = "0x11114E0")]
		public ulong friend_id;

		// Token: 0x04002765 RID: 10085
		[Token(Token = "0x4002765")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11114F4", Offset = "0x11114F4")]
		public EFriend.RelationType relation_type;

		// Token: 0x04002766 RID: 10086
		[Token(Token = "0x4002766")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111508", Offset = "0x1111508")]
		public bool is_create;
	}
}
