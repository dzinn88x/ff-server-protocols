using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	[ProtoContract]
	public class LoadoutInfo
	{
		// Token: 0x06002199 RID: 8601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x24A47B4", Offset = "0x24A47B4", VA = "0x7BBCCA47B4")]
		public LoadoutInfo()
		{
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x0600219A RID: 8602 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		// (set) Token: 0x0600219B RID: 8603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158EB4", Offset = "0x1158EB4")]
		public uint loadout_id
		{
			[Token(Token = "0x600219A")]
			[Address(RVA = "0x24A47BC", Offset = "0x24A47BC", VA = "0x7BBCCA47BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A24", Offset = "0x1139A24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600219B")]
			[Address(RVA = "0x24A47C4", Offset = "0x24A47C4", VA = "0x7BBCCA47C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A34", Offset = "0x1139A34")]
			set
			{
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158EC8", Offset = "0x1158EC8")]
		public uint loadout_num
		{
			[Token(Token = "0x600219C")]
			[Address(RVA = "0x24A47CC", Offset = "0x24A47CC", VA = "0x7BBCCA47CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A44", Offset = "0x1139A44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600219D")]
			[Address(RVA = "0x24A47D4", Offset = "0x24A47D4", VA = "0x7BBCCA47D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A54", Offset = "0x1139A54")]
			set
			{
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x0000E910 File Offset: 0x0000CB10
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158EDC", Offset = "0x1158EDC")]
		public bool is_free_play
		{
			[Token(Token = "0x600219E")]
			[Address(RVA = "0x24A47DC", Offset = "0x24A47DC", VA = "0x7BBCCA47DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A64", Offset = "0x1139A64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600219F")]
			[Address(RVA = "0x24A47E4", Offset = "0x24A47E4", VA = "0x7BBCCA47E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A74", Offset = "0x1139A74")]
			set
			{
			}
		}

		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11042D4", Offset = "0x11042D4")]
		private uint <loadout_id>k__BackingField;

		// Token: 0x04001938 RID: 6456
		[Token(Token = "0x4001938")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11042E4", Offset = "0x11042E4")]
		private uint <loadout_num>k__BackingField;

		// Token: 0x04001939 RID: 6457
		[Token(Token = "0x4001939")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11042F4", Offset = "0x11042F4")]
		private bool <is_free_play>k__BackingField;
	}
}
