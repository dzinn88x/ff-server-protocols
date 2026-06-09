using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006DB RID: 1755
	[Token(Token = "0x20006DB")]
	[ProtoContract]
	public class CSRegisterRes
	{
		// Token: 0x060023E9 RID: 9193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x21B7358", Offset = "0x21B7358", VA = "0x7BBC9B7358")]
		public CSRegisterRes()
		{
		}

		// Token: 0x0400228A RID: 8842
		[Token(Token = "0x400228A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109664", Offset = "0x1109664")]
		public bool success;

		// Token: 0x0400228B RID: 8843
		[Token(Token = "0x400228B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1109678", Offset = "0x1109678")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1109678", Offset = "0x1109678")]
		public string reason;
	}
}
