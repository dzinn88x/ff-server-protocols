using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000497 RID: 1175
	[Token(Token = "0x2000497")]
	[ProtoContract]
	public class GroupInviteNtf
	{
		// Token: 0x06001D39 RID: 7481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D39")]
		[Address(RVA = "0x24A3774", Offset = "0x24A3774", VA = "0x7BBCCA3774")]
		public GroupInviteNtf()
		{
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001D3A RID: 7482 RVA: 0x0000C780 File Offset: 0x0000A980
		// (set) Token: 0x06001D3B RID: 7483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003BF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155520", Offset = "0x1155520")]
		public ulong group_id
		{
			[Token(Token = "0x6001D3A")]
			[Address(RVA = "0x24A37D8", Offset = "0x24A37D8", VA = "0x7BBCCA37D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135BC4", Offset = "0x1135BC4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D3B")]
			[Address(RVA = "0x24A37E0", Offset = "0x24A37E0", VA = "0x7BBCCA37E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135BD4", Offset = "0x1135BD4")]
			set
			{
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155534", Offset = "0x1155534")]
		public GroupMemberInfo inviter_info
		{
			[Token(Token = "0x6001D3C")]
			[Address(RVA = "0x24A37E8", Offset = "0x24A37E8", VA = "0x7BBCCA37E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135BE4", Offset = "0x1135BE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D3D")]
			[Address(RVA = "0x24A37F0", Offset = "0x24A37F0", VA = "0x7BBCCA37F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135BF4", Offset = "0x1135BF4")]
			set
			{
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155548", Offset = "0x1155548")]
		public uint[] map_ids
		{
			[Token(Token = "0x6001D3E")]
			[Address(RVA = "0x24A37F8", Offset = "0x24A37F8", VA = "0x7BBCCA37F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C04", Offset = "0x1135C04")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D3F")]
			[Address(RVA = "0x24A3800", Offset = "0x24A3800", VA = "0x7BBCCA3800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C14", Offset = "0x1135C14")]
			set
			{
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001D40 RID: 7488 RVA: 0x0000C798 File Offset: 0x0000A998
		// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155584", Offset = "0x1155584")]
		public uint game_mode
		{
			[Token(Token = "0x6001D40")]
			[Address(RVA = "0x24A3808", Offset = "0x24A3808", VA = "0x7BBCCA3808")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C24", Offset = "0x1135C24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D41")]
			[Address(RVA = "0x24A3810", Offset = "0x24A3810", VA = "0x7BBCCA3810")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C34", Offset = "0x1135C34")]
			set
			{
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001D42 RID: 7490 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155598", Offset = "0x1155598")]
		public uint group_mode
		{
			[Token(Token = "0x6001D42")]
			[Address(RVA = "0x24A3818", Offset = "0x24A3818", VA = "0x7BBCCA3818")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C44", Offset = "0x1135C44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D43")]
			[Address(RVA = "0x24A3820", Offset = "0x24A3820", VA = "0x7BBCCA3820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C54", Offset = "0x1135C54")]
			set
			{
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11555AC", Offset = "0x11555AC")]
		public uint match_mode
		{
			[Token(Token = "0x6001D44")]
			[Address(RVA = "0x24A3828", Offset = "0x24A3828", VA = "0x7BBCCA3828")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C64", Offset = "0x1135C64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D45")]
			[Address(RVA = "0x24A3830", Offset = "0x24A3830", VA = "0x7BBCCA3830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C74", Offset = "0x1135C74")]
			set
			{
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003C5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11555C0", Offset = "0x11555C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11555C0", Offset = "0x11555C0")]
		public string secret_code
		{
			[Token(Token = "0x6001D46")]
			[Address(RVA = "0x24A3838", Offset = "0x24A3838", VA = "0x7BBCCA3838")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C84", Offset = "0x1135C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D47")]
			[Address(RVA = "0x24A37D0", Offset = "0x24A37D0", VA = "0x7BBCCA37D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135C94", Offset = "0x1135C94")]
			set
			{
			}
		}

		// Token: 0x040015E4 RID: 5604
		[Token(Token = "0x40015E4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11023A4", Offset = "0x11023A4")]
		private ulong <group_id>k__BackingField;

		// Token: 0x040015E5 RID: 5605
		[Token(Token = "0x40015E5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11023B4", Offset = "0x11023B4")]
		private GroupMemberInfo <inviter_info>k__BackingField;

		// Token: 0x040015E6 RID: 5606
		[Token(Token = "0x40015E6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11023C4", Offset = "0x11023C4")]
		private uint[] <map_ids>k__BackingField;

		// Token: 0x040015E7 RID: 5607
		[Token(Token = "0x40015E7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11023D4", Offset = "0x11023D4")]
		private uint <game_mode>k__BackingField;

		// Token: 0x040015E8 RID: 5608
		[Token(Token = "0x40015E8")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11023E4", Offset = "0x11023E4")]
		private uint <group_mode>k__BackingField;

		// Token: 0x040015E9 RID: 5609
		[Token(Token = "0x40015E9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11023F4", Offset = "0x11023F4")]
		private uint <match_mode>k__BackingField;

		// Token: 0x040015EA RID: 5610
		[Token(Token = "0x40015EA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102404", Offset = "0x1102404")]
		private string <secret_code>k__BackingField;
	}
}
