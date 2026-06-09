using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B55 RID: 2901
	[Token(Token = "0x2000B55")]
	[ProtoContract]
	public class CupBlocklistDesc
	{
		// Token: 0x0600285D RID: 10333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285D")]
		[Address(RVA = "0x21B9108", Offset = "0x21B9108", VA = "0x7BBC9B9108")]
		public CupBlocklistDesc()
		{
		}

		// Token: 0x04003740 RID: 14144
		[Token(Token = "0x4003740")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E6E4", Offset = "0x112E6E4")]
		public uint cup_type;

		// Token: 0x04003741 RID: 14145
		[Token(Token = "0x4003741")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E6F8", Offset = "0x112E6F8")]
		public uint cup_id;

		// Token: 0x04003742 RID: 14146
		[Token(Token = "0x4003742")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E70C", Offset = "0x112E70C")]
		public ulong[] account_ids;
	}
}
