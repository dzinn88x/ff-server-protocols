using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006DA RID: 1754
	[Token(Token = "0x20006DA")]
	[ProtoContract]
	public class CSRegisterReq
	{
		// Token: 0x060023E8 RID: 9192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x21B72F8", Offset = "0x21B72F8", VA = "0x7BBC9B72F8")]
		public CSRegisterReq()
		{
		}

		// Token: 0x04002286 RID: 8838
		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109560", Offset = "0x1109560")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109560", Offset = "0x1109560")]
		public string device_id;

		// Token: 0x04002287 RID: 8839
		[Token(Token = "0x4002287")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11095B0", Offset = "0x11095B0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11095B0", Offset = "0x11095B0")]
		public string nickname;

		// Token: 0x04002288 RID: 8840
		[Token(Token = "0x4002288")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109600", Offset = "0x1109600")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109600", Offset = "0x1109600")]
		public string region;

		// Token: 0x04002289 RID: 8841
		[Token(Token = "0x4002289")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109650", Offset = "0x1109650")]
		public uint avatar_id;
	}
}
