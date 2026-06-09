using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A35 RID: 2613
	[Token(Token = "0x2000A35")]
	[ProtoContract]
	public class NewPlayerABTestDesc
	{
		// Token: 0x0600273F RID: 10047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273F")]
		[Address(RVA = "0x249E8FC", Offset = "0x249E8FC", VA = "0x7BBCC9E8FC")]
		public NewPlayerABTestDesc()
		{
		}

		// Token: 0x04002FAA RID: 12202
		[Token(Token = "0x4002FAA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FDD8", Offset = "0x111FDD8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111FDD8", Offset = "0x111FDD8")]
		public string region;

		// Token: 0x04002FAB RID: 12203
		[Token(Token = "0x4002FAB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FE28", Offset = "0x111FE28")]
		public bool ab_test_switch;

		// Token: 0x04002FAC RID: 12204
		[Token(Token = "0x4002FAC")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FE3C", Offset = "0x111FE3C")]
		public uint probability;
	}
}
