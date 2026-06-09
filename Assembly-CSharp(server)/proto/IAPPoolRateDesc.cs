using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA2 RID: 2722
	[Token(Token = "0x2000AA2")]
	[ProtoContract]
	public class IAPPoolRateDesc
	{
		// Token: 0x060027AC RID: 10156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x21BB3B8", Offset = "0x21BB3B8", VA = "0x7BBC9BB3B8")]
		public IAPPoolRateDesc()
		{
		}

		// Token: 0x040032F7 RID: 13047
		[Token(Token = "0x40032F7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125C38", Offset = "0x1125C38")]
		public uint bundle_pool_id;

		// Token: 0x040032F8 RID: 13048
		[Token(Token = "0x40032F8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125C4C", Offset = "0x1125C4C")]
		public uint store_id;

		// Token: 0x040032F9 RID: 13049
		[Token(Token = "0x40032F9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125C60", Offset = "0x1125C60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125C60", Offset = "0x1125C60")]
		public string store_name;

		// Token: 0x040032FA RID: 13050
		[Token(Token = "0x40032FA")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125CB0", Offset = "0x1125CB0")]
		public float discount;

		// Token: 0x040032FB RID: 13051
		[Token(Token = "0x40032FB")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125CC4", Offset = "0x1125CC4")]
		public uint weight;

		// Token: 0x040032FC RID: 13052
		[Token(Token = "0x40032FC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125CD8", Offset = "0x1125CD8")]
		public bool is_default;

		// Token: 0x040032FD RID: 13053
		[Token(Token = "0x40032FD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125CEC", Offset = "0x1125CEC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125CEC", Offset = "0x1125CEC")]
		public string title;
	}
}
