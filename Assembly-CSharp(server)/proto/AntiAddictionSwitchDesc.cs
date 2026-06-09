using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE9 RID: 2793
	[Token(Token = "0x2000AE9")]
	[ProtoContract]
	public class AntiAddictionSwitchDesc
	{
		// Token: 0x060027F1 RID: 10225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F1")]
		[Address(RVA = "0x21AF1CC", Offset = "0x21AF1CC", VA = "0x7BBC9AF1CC")]
		public AntiAddictionSwitchDesc()
		{
		}

		// Token: 0x0400349F RID: 13471
		[Token(Token = "0x400349F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128CF8", Offset = "0x1128CF8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128CF8", Offset = "0x1128CF8")]
		public string country;

		// Token: 0x040034A0 RID: 13472
		[Token(Token = "0x40034A0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128D48", Offset = "0x1128D48")]
		public bool function_switch;
	}
}
