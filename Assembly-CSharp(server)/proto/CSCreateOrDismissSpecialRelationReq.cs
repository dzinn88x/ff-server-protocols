using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000836 RID: 2102
	[Token(Token = "0x2000836")]
	[ProtoContract]
	public class CSCreateOrDismissSpecialRelationReq
	{
		// Token: 0x0600254B RID: 9547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254B")]
		[Address(RVA = "0x21B0D5C", Offset = "0x21B0D5C", VA = "0x7BBC9B0D5C")]
		public CSCreateOrDismissSpecialRelationReq()
		{
		}

		// Token: 0x0400275E RID: 10078
		[Token(Token = "0x400275E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111468", Offset = "0x1111468")]
		public ulong friend_id;

		// Token: 0x0400275F RID: 10079
		[Token(Token = "0x400275F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111147C", Offset = "0x111147C")]
		public EFriend.RelationType relation_type;

		// Token: 0x04002760 RID: 10080
		[Token(Token = "0x4002760")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111490", Offset = "0x1111490")]
		public bool is_create;
	}
}
