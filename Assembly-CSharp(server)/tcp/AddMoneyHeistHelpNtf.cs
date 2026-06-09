using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	[ProtoContract]
	public class AddMoneyHeistHelpNtf
	{
		// Token: 0x06001EC4 RID: 7876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x24A23E8", Offset = "0x24A23E8", VA = "0x7BBCCA23E8")]
		public AddMoneyHeistHelpNtf()
		{
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x0000D290 File Offset: 0x0000B490
		// (set) Token: 0x06001EC6 RID: 7878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000470")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156C04", Offset = "0x1156C04")]
		public ulong helper_id
		{
			[Token(Token = "0x6001EC5")]
			[Address(RVA = "0x24A244C", Offset = "0x24A244C", VA = "0x7BBCCA244C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11371E4", Offset = "0x11371E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001EC6")]
			[Address(RVA = "0x24A2454", Offset = "0x24A2454", VA = "0x7BBCCA2454")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11371F4", Offset = "0x11371F4")]
			set
			{
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000471")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156C18", Offset = "0x1156C18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1156C18", Offset = "0x1156C18")]
		public string helper_name
		{
			[Token(Token = "0x6001EC7")]
			[Address(RVA = "0x24A245C", Offset = "0x24A245C", VA = "0x7BBCCA245C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137204", Offset = "0x1137204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EC8")]
			[Address(RVA = "0x24A2444", Offset = "0x24A2444", VA = "0x7BBCCA2444")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137214", Offset = "0x1137214")]
			set
			{
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		// (set) Token: 0x06001ECA RID: 7882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000472")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156C68", Offset = "0x1156C68")]
		public uint deposit
		{
			[Token(Token = "0x6001EC9")]
			[Address(RVA = "0x24A2464", Offset = "0x24A2464", VA = "0x7BBCCA2464")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137224", Offset = "0x1137224")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001ECA")]
			[Address(RVA = "0x24A246C", Offset = "0x24A246C", VA = "0x7BBCCA246C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137234", Offset = "0x1137234")]
			set
			{
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001ECB RID: 7883 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		// (set) Token: 0x06001ECC RID: 7884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000473")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156C7C", Offset = "0x1156C7C")]
		public uint current_speed_from_friend
		{
			[Token(Token = "0x6001ECB")]
			[Address(RVA = "0x24A2474", Offset = "0x24A2474", VA = "0x7BBCCA2474")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137244", Offset = "0x1137244")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001ECC")]
			[Address(RVA = "0x24A247C", Offset = "0x24A247C", VA = "0x7BBCCA247C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137254", Offset = "0x1137254")]
			set
			{
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001ECD RID: 7885 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		// (set) Token: 0x06001ECE RID: 7886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000474")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156C90", Offset = "0x1156C90")]
		public uint speed_change_time
		{
			[Token(Token = "0x6001ECD")]
			[Address(RVA = "0x24A2484", Offset = "0x24A2484", VA = "0x7BBCCA2484")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137264", Offset = "0x1137264")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001ECE")]
			[Address(RVA = "0x24A248C", Offset = "0x24A248C", VA = "0x7BBCCA248C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137274", Offset = "0x1137274")]
			set
			{
			}
		}

		// Token: 0x040016AF RID: 5807
		[Token(Token = "0x40016AF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102EB4", Offset = "0x1102EB4")]
		private ulong <helper_id>k__BackingField;

		// Token: 0x040016B0 RID: 5808
		[Token(Token = "0x40016B0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102EC4", Offset = "0x1102EC4")]
		private string <helper_name>k__BackingField;

		// Token: 0x040016B1 RID: 5809
		[Token(Token = "0x40016B1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102ED4", Offset = "0x1102ED4")]
		private uint <deposit>k__BackingField;

		// Token: 0x040016B2 RID: 5810
		[Token(Token = "0x40016B2")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102EE4", Offset = "0x1102EE4")]
		private uint <current_speed_from_friend>k__BackingField;

		// Token: 0x040016B3 RID: 5811
		[Token(Token = "0x40016B3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102EF4", Offset = "0x1102EF4")]
		private uint <speed_change_time>k__BackingField;
	}
}
