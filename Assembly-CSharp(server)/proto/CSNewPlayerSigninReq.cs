using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007AE RID: 1966
	[Token(Token = "0x20007AE")]
	[ProtoContract]
	public class CSNewPlayerSigninReq
	{
		// Token: 0x060024BD RID: 9405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x21B6C00", Offset = "0x21B6C00", VA = "0x7BBC9B6C00")]
		public CSNewPlayerSigninReq()
		{
		}

		// Token: 0x040025DC RID: 9692
		[Token(Token = "0x40025DC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E95C", Offset = "0x110E95C")]
		public uint reward_id;

		// Token: 0x040025DD RID: 9693
		[Token(Token = "0x40025DD")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E970", Offset = "0x110E970")]
		public uint level;
	}
}
