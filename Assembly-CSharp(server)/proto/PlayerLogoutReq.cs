using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005DA RID: 1498
	[Token(Token = "0x20005DA")]
	[ProtoContract]
	public class PlayerLogoutReq
	{
		// Token: 0x0600235A RID: 9050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235A")]
		[Address(RVA = "0x249F6CC", Offset = "0x249F6CC", VA = "0x7BBCC9F6CC")]
		public PlayerLogoutReq()
		{
		}

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11053E8", Offset = "0x11053E8")]
		public ulong account_id;

		// Token: 0x04001DC1 RID: 7617
		[Token(Token = "0x4001DC1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11053FC", Offset = "0x11053FC")]
		public ulong conn_id;
	}
}
