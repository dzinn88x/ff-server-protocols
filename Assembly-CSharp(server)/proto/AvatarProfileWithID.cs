using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005FA RID: 1530
	[Token(Token = "0x20005FA")]
	[ProtoContract]
	public class AvatarProfileWithID
	{
		// Token: 0x0600237A RID: 9082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x21AF5A0", Offset = "0x21AF5A0", VA = "0x7BBC9AF5A0")]
		public AvatarProfileWithID()
		{
		}

		// Token: 0x04001E8C RID: 7820
		[Token(Token = "0x4001E8C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106EA0", Offset = "0x1106EA0")]
		public ulong account_id;

		// Token: 0x04001E8D RID: 7821
		[Token(Token = "0x4001E8D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106EB4", Offset = "0x1106EB4")]
		public AvatarProfile avatar_profile;
	}
}
