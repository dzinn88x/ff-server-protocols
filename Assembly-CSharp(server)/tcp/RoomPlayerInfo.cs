using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x2000520")]
	[ProtoContract]
	public class RoomPlayerInfo
	{
		// Token: 0x0600213C RID: 8508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600213C")]
		[Address(RVA = "0x24A6BAC", Offset = "0x24A6BAC", VA = "0x7BBCCA6BAC")]
		public RoomPlayerInfo()
		{
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x0000E628 File Offset: 0x0000C828
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158AB8", Offset = "0x1158AB8")]
		public ulong group_id
		{
			[Token(Token = "0x600213D")]
			[Address(RVA = "0x24A6C10", Offset = "0x24A6C10", VA = "0x7BBCCA6C10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139564", Offset = "0x1139564")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600213E")]
			[Address(RVA = "0x24A6C18", Offset = "0x24A6C18", VA = "0x7BBCCA6C18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139574", Offset = "0x1139574")]
			set
			{
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x0000E640 File Offset: 0x0000C840
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158ACC", Offset = "0x1158ACC")]
		public ulong account_id
		{
			[Token(Token = "0x600213F")]
			[Address(RVA = "0x24A6C20", Offset = "0x24A6C20", VA = "0x7BBCCA6C20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139584", Offset = "0x1139584")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002140")]
			[Address(RVA = "0x24A6C28", Offset = "0x24A6C28", VA = "0x7BBCCA6C28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139594", Offset = "0x1139594")]
			set
			{
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158AE0", Offset = "0x1158AE0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1158AE0", Offset = "0x1158AE0")]
		public string nickname
		{
			[Token(Token = "0x6002141")]
			[Address(RVA = "0x24A6C30", Offset = "0x24A6C30", VA = "0x7BBCCA6C30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11395A4", Offset = "0x11395A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002142")]
			[Address(RVA = "0x24A6C08", Offset = "0x24A6C08", VA = "0x7BBCCA6C08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11395B4", Offset = "0x11395B4")]
			set
			{
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x0000E658 File Offset: 0x0000C858
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158B30", Offset = "0x1158B30")]
		public uint emulator_score
		{
			[Token(Token = "0x6002143")]
			[Address(RVA = "0x24A6C38", Offset = "0x24A6C38", VA = "0x7BBCCA6C38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11395C4", Offset = "0x11395C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002144")]
			[Address(RVA = "0x24A6C40", Offset = "0x24A6C40", VA = "0x7BBCCA6C40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11395D4", Offset = "0x11395D4")]
			set
			{
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x0000E670 File Offset: 0x0000C870
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000590")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158B44", Offset = "0x1158B44")]
		public uint head_pic
		{
			[Token(Token = "0x6002145")]
			[Address(RVA = "0x24A6C48", Offset = "0x24A6C48", VA = "0x7BBCCA6C48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11395E4", Offset = "0x11395E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002146")]
			[Address(RVA = "0x24A6C50", Offset = "0x24A6C50", VA = "0x7BBCCA6C50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11395F4", Offset = "0x11395F4")]
			set
			{
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x0000E688 File Offset: 0x0000C888
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000591")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158B58", Offset = "0x1158B58")]
		public bool ready
		{
			[Token(Token = "0x6002147")]
			[Address(RVA = "0x24A6C58", Offset = "0x24A6C58", VA = "0x7BBCCA6C58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139604", Offset = "0x1139604")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002148")]
			[Address(RVA = "0x24A6C60", Offset = "0x24A6C60", VA = "0x7BBCCA6C60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139614", Offset = "0x1139614")]
			set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000592")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158B6C", Offset = "0x1158B6C")]
		public uint banner_id
		{
			[Token(Token = "0x6002149")]
			[Address(RVA = "0x24A6C6C", Offset = "0x24A6C6C", VA = "0x7BBCCA6C6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139624", Offset = "0x1139624")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600214A")]
			[Address(RVA = "0x24A6C74", Offset = "0x24A6C74", VA = "0x7BBCCA6C74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139634", Offset = "0x1139634")]
			set
			{
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000593")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158B80", Offset = "0x1158B80")]
		public uint role
		{
			[Token(Token = "0x600214B")]
			[Address(RVA = "0x24A6C7C", Offset = "0x24A6C7C", VA = "0x7BBCCA6C7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139644", Offset = "0x1139644")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600214C")]
			[Address(RVA = "0x24A6C84", Offset = "0x24A6C84", VA = "0x7BBCCA6C84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139654", Offset = "0x1139654")]
			set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000594")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158B94", Offset = "0x1158B94")]
		public uint[] available_maps
		{
			[Token(Token = "0x600214D")]
			[Address(RVA = "0x24A6C8C", Offset = "0x24A6C8C", VA = "0x7BBCCA6C8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139664", Offset = "0x1139664")]
			get
			{
				return null;
			}
			[Token(Token = "0x600214E")]
			[Address(RVA = "0x24A6C94", Offset = "0x24A6C94", VA = "0x7BBCCA6C94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139674", Offset = "0x1139674")]
			set
			{
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000595")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158BD0", Offset = "0x1158BD0")]
		public uint pin_id
		{
			[Token(Token = "0x600214F")]
			[Address(RVA = "0x24A6C9C", Offset = "0x24A6C9C", VA = "0x7BBCCA6C9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139684", Offset = "0x1139684")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002150")]
			[Address(RVA = "0x24A6CA4", Offset = "0x24A6CA4", VA = "0x7BBCCA6CA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139694", Offset = "0x1139694")]
			set
			{
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000596")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158BE4", Offset = "0x1158BE4")]
		public uint using_version
		{
			[Token(Token = "0x6002151")]
			[Address(RVA = "0x24A6CAC", Offset = "0x24A6CAC", VA = "0x7BBCCA6CAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11396A4", Offset = "0x11396A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002152")]
			[Address(RVA = "0x24A6CB4", Offset = "0x24A6CB4", VA = "0x7BBCCA6CB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11396B4", Offset = "0x11396B4")]
			set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x0000E700 File Offset: 0x0000C900
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000597")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158BF8", Offset = "0x1158BF8")]
		public uint rank
		{
			[Token(Token = "0x6002153")]
			[Address(RVA = "0x24A6CBC", Offset = "0x24A6CBC", VA = "0x7BBCCA6CBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11396C4", Offset = "0x11396C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002154")]
			[Address(RVA = "0x24A6CC4", Offset = "0x24A6CC4", VA = "0x7BBCCA6CC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11396D4", Offset = "0x11396D4")]
			set
			{
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x0000E718 File Offset: 0x0000C918
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000598")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158C0C", Offset = "0x1158C0C")]
		public uint ranking_points
		{
			[Token(Token = "0x6002155")]
			[Address(RVA = "0x24A6CCC", Offset = "0x24A6CCC", VA = "0x7BBCCA6CCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11396E4", Offset = "0x11396E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002156")]
			[Address(RVA = "0x24A6CD4", Offset = "0x24A6CD4", VA = "0x7BBCCA6CD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11396F4", Offset = "0x11396F4")]
			set
			{
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x0000E730 File Offset: 0x0000C930
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000599")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158C20", Offset = "0x1158C20")]
		public uint cs_rank
		{
			[Token(Token = "0x6002157")]
			[Address(RVA = "0x24A6CDC", Offset = "0x24A6CDC", VA = "0x7BBCCA6CDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139704", Offset = "0x1139704")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002158")]
			[Address(RVA = "0x24A6CE4", Offset = "0x24A6CE4", VA = "0x7BBCCA6CE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139714", Offset = "0x1139714")]
			set
			{
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x0000E748 File Offset: 0x0000C948
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158C34", Offset = "0x1158C34")]
		public uint cs_ranking_points
		{
			[Token(Token = "0x6002159")]
			[Address(RVA = "0x24A6CEC", Offset = "0x24A6CEC", VA = "0x7BBCCA6CEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139724", Offset = "0x1139724")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600215A")]
			[Address(RVA = "0x24A6CF4", Offset = "0x24A6CF4", VA = "0x7BBCCA6CF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139734", Offset = "0x1139734")]
			set
			{
			}
		}

		// Token: 0x040018A6 RID: 6310
		[Token(Token = "0x40018A6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104074", Offset = "0x1104074")]
		private ulong <group_id>k__BackingField;

		// Token: 0x040018A7 RID: 6311
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104084", Offset = "0x1104084")]
		private ulong <account_id>k__BackingField;

		// Token: 0x040018A8 RID: 6312
		[Token(Token = "0x40018A8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104094", Offset = "0x1104094")]
		private string <nickname>k__BackingField;

		// Token: 0x040018A9 RID: 6313
		[Token(Token = "0x40018A9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11040A4", Offset = "0x11040A4")]
		private uint <emulator_score>k__BackingField;

		// Token: 0x040018AA RID: 6314
		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11040B4", Offset = "0x11040B4")]
		private uint <head_pic>k__BackingField;

		// Token: 0x040018AB RID: 6315
		[Token(Token = "0x40018AB")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11040C4", Offset = "0x11040C4")]
		private bool <ready>k__BackingField;

		// Token: 0x040018AC RID: 6316
		[Token(Token = "0x40018AC")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11040D4", Offset = "0x11040D4")]
		private uint <banner_id>k__BackingField;

		// Token: 0x040018AD RID: 6317
		[Token(Token = "0x40018AD")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11040E4", Offset = "0x11040E4")]
		private uint <role>k__BackingField;

		// Token: 0x040018AE RID: 6318
		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11040F4", Offset = "0x11040F4")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104104", Offset = "0x1104104")]
		private uint <pin_id>k__BackingField;

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104114", Offset = "0x1104114")]
		private uint <using_version>k__BackingField;

		// Token: 0x040018B1 RID: 6321
		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104124", Offset = "0x1104124")]
		private uint <rank>k__BackingField;

		// Token: 0x040018B2 RID: 6322
		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104134", Offset = "0x1104134")]
		private uint <ranking_points>k__BackingField;

		// Token: 0x040018B3 RID: 6323
		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104144", Offset = "0x1104144")]
		private uint <cs_rank>k__BackingField;

		// Token: 0x040018B4 RID: 6324
		[Token(Token = "0x40018B4")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104154", Offset = "0x1104154")]
		private uint <cs_ranking_points>k__BackingField;
	}
}
