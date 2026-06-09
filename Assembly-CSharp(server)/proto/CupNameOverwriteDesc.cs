using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B53 RID: 2899
	[Token(Token = "0x2000B53")]
	[ProtoContract]
	public class CupNameOverwriteDesc
	{
		// Token: 0x0600285B RID: 10331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x21B91E4", Offset = "0x21B91E4", VA = "0x7BBC9B91E4")]
		public CupNameOverwriteDesc()
		{
		}

		// Token: 0x04003732 RID: 14130
		[Token(Token = "0x4003732")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E4B4", Offset = "0x112E4B4")]
		public uint cup_type;

		// Token: 0x04003733 RID: 14131
		[Token(Token = "0x4003733")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E4C8", Offset = "0x112E4C8")]
		public uint cup_id;

		// Token: 0x04003734 RID: 14132
		[Token(Token = "0x4003734")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E4DC", Offset = "0x112E4DC")]
		public uint name_type;

		// Token: 0x04003735 RID: 14133
		[Token(Token = "0x4003735")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E4F0", Offset = "0x112E4F0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E4F0", Offset = "0x112E4F0")]
		public string language;

		// Token: 0x04003736 RID: 14134
		[Token(Token = "0x4003736")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E540", Offset = "0x112E540")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E540", Offset = "0x112E540")]
		public string content;
	}
}
