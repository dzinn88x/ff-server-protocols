using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000837 RID: 2103
	[Token(Token = "0x2000837")]
	[ProtoContract]
	public class CSConfirmSpecialRelationReq
	{
		// Token: 0x0600254C RID: 9548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254C")]
		[Address(RVA = "0x21B0C88", Offset = "0x21B0C88", VA = "0x7BBC9B0C88")]
		public CSConfirmSpecialRelationReq()
		{
		}

		// Token: 0x04002761 RID: 10081
		[Token(Token = "0x4002761")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11114A4", Offset = "0x11114A4")]
		public ulong friend_id;

		// Token: 0x04002762 RID: 10082
		[Token(Token = "0x4002762")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11114B8", Offset = "0x11114B8")]
		public EFriend.RelationType relation_type;

		// Token: 0x04002763 RID: 10083
		[Token(Token = "0x4002763")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11114CC", Offset = "0x11114CC")]
		public bool is_create;
	}
}
