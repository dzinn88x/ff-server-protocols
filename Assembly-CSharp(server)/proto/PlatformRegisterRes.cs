using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000613 RID: 1555
	[Token(Token = "0x2000613")]
	[ProtoContract]
	public class PlatformRegisterRes
	{
		// Token: 0x0600238E RID: 9102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x249F5E4", Offset = "0x249F5E4", VA = "0x7BBCC9F5E4")]
		public PlatformRegisterRes()
		{
		}

		// Token: 0x04001EFB RID: 7931
		[Token(Token = "0x4001EFB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107698", Offset = "0x1107698")]
		public bool success;

		// Token: 0x04001EFC RID: 7932
		[Token(Token = "0x4001EFC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11076AC", Offset = "0x11076AC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11076AC", Offset = "0x11076AC")]
		public string reason;

		// Token: 0x04001EFD RID: 7933
		[Token(Token = "0x4001EFD")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11076FC", Offset = "0x11076FC")]
		public ulong account_id;
	}
}
