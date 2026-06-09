using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200087C RID: 2172
	[Token(Token = "0x200087C")]
	[ProtoContract]
	public class CSLoginDescReq
	{
		// Token: 0x0600258A RID: 9610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600258A")]
		[Address(RVA = "0x21B67B0", Offset = "0x21B67B0", VA = "0x7BBC9B67B0")]
		public CSLoginDescReq()
		{
		}

		// Token: 0x0400289F RID: 10399
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111359C", Offset = "0x111359C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111359C", Offset = "0x111359C")]
		public string language;

		// Token: 0x040028A0 RID: 10400
		[Token(Token = "0x40028A0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11135EC", Offset = "0x11135EC")]
		public uint platform;
	}
}
