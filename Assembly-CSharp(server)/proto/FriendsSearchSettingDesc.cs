using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ABD RID: 2749
	[Token(Token = "0x2000ABD")]
	[ProtoContract]
	public class FriendsSearchSettingDesc
	{
		// Token: 0x060027C7 RID: 10183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x21BA430", Offset = "0x21BA430", VA = "0x7BBC9BA430")]
		public FriendsSearchSettingDesc()
		{
		}

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11272E0", Offset = "0x11272E0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11272E0", Offset = "0x11272E0")]
		public string region;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127330", Offset = "0x1127330")]
		public uint friends_pool_num;
	}
}
