using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000839 RID: 2105
	[Token(Token = "0x2000839")]
	[ProtoContract]
	public class CSCallbackDismissReq
	{
		// Token: 0x0600254E RID: 9550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600254E")]
		[Address(RVA = "0x21B04F4", Offset = "0x21B04F4", VA = "0x7BBC9B04F4")]
		public CSCallbackDismissReq()
		{
		}

		// Token: 0x04002767 RID: 10087
		[Token(Token = "0x4002767")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111151C", Offset = "0x111151C")]
		public ulong friend_id;

		// Token: 0x04002768 RID: 10088
		[Token(Token = "0x4002768")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111530", Offset = "0x1111530")]
		public EFriend.RelationType relation_type;
	}
}
