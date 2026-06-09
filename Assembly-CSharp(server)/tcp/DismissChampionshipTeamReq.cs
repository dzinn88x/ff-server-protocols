using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200045B RID: 1115
	[Token(Token = "0x200045B")]
	[ProtoContract]
	public class DismissChampionshipTeamReq
	{
		// Token: 0x06001C59 RID: 7257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C59")]
		[Address(RVA = "0x24A2BC8", Offset = "0x24A2BC8", VA = "0x7BBCCA2BC8")]
		public DismissChampionshipTeamReq()
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000360")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11549B8", Offset = "0x11549B8")]
		public ulong team_id
		{
			[Token(Token = "0x6001C5A")]
			[Address(RVA = "0x24A2C2C", Offset = "0x24A2C2C", VA = "0x7BBCCA2C2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134FE4", Offset = "0x1134FE4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C5B")]
			[Address(RVA = "0x24A2C34", Offset = "0x24A2C34", VA = "0x7BBCCA2C34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134FF4", Offset = "0x1134FF4")]
			set
			{
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000361")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11549CC", Offset = "0x11549CC")]
		public ulong dismisser_id
		{
			[Token(Token = "0x6001C5C")]
			[Address(RVA = "0x24A2C3C", Offset = "0x24A2C3C", VA = "0x7BBCCA2C3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135004", Offset = "0x1135004")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C5D")]
			[Address(RVA = "0x24A2C44", Offset = "0x24A2C44", VA = "0x7BBCCA2C44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135014", Offset = "0x1135014")]
			set
			{
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000362")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11549E0", Offset = "0x11549E0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11549E0", Offset = "0x11549E0")]
		public string team_name
		{
			[Token(Token = "0x6001C5E")]
			[Address(RVA = "0x24A2C4C", Offset = "0x24A2C4C", VA = "0x7BBCCA2C4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135024", Offset = "0x1135024")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C5F")]
			[Address(RVA = "0x24A2C24", Offset = "0x24A2C24", VA = "0x7BBCCA2C24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135034", Offset = "0x1135034")]
			set
			{
			}
		}

		// Token: 0x040014A3 RID: 5283
		[Token(Token = "0x40014A3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101DB4", Offset = "0x1101DB4")]
		private ulong <team_id>k__BackingField;

		// Token: 0x040014A4 RID: 5284
		[Token(Token = "0x40014A4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101DC4", Offset = "0x1101DC4")]
		private ulong <dismisser_id>k__BackingField;

		// Token: 0x040014A5 RID: 5285
		[Token(Token = "0x40014A5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101DD4", Offset = "0x1101DD4")]
		private string <team_name>k__BackingField;
	}
}
