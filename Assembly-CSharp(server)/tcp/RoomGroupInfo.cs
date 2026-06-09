using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200051F RID: 1311
	[Token(Token = "0x200051F")]
	[ProtoContract]
	public class RoomGroupInfo
	{
		// Token: 0x06002133 RID: 8499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002133")]
		[Address(RVA = "0x24A6360", Offset = "0x24A6360", VA = "0x7BBCCA6360")]
		public RoomGroupInfo()
		{
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0000E610 File Offset: 0x0000C810
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000588")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11589F0", Offset = "0x11589F0")]
		public ulong id
		{
			[Token(Token = "0x6002134")]
			[Address(RVA = "0x24A6408", Offset = "0x24A6408", VA = "0x7BBCCA6408")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11394E4", Offset = "0x11394E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002135")]
			[Address(RVA = "0x24A6410", Offset = "0x24A6410", VA = "0x7BBCCA6410")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11394F4", Offset = "0x11394F4")]
			set
			{
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000589")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158A04", Offset = "0x1158A04")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1158A04", Offset = "0x1158A04")]
		public string name
		{
			[Token(Token = "0x6002136")]
			[Address(RVA = "0x24A6418", Offset = "0x24A6418", VA = "0x7BBCCA6418")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139504", Offset = "0x1139504")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002137")]
			[Address(RVA = "0x24A63F0", Offset = "0x24A63F0", VA = "0x7BBCCA63F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139514", Offset = "0x1139514")]
			set
			{
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002139 RID: 8505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158A54", Offset = "0x1158A54")]
		public List<RoomPlayerInfo> members
		{
			[Token(Token = "0x6002138")]
			[Address(RVA = "0x24A6420", Offset = "0x24A6420", VA = "0x7BBCCA6420")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139524", Offset = "0x1139524")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002139")]
			[Address(RVA = "0x24A63F8", Offset = "0x24A63F8", VA = "0x7BBCCA63F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139534", Offset = "0x1139534")]
			private set
			{
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600213B RID: 8507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158A68", Offset = "0x1158A68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1158A68", Offset = "0x1158A68")]
		public string abbr_name
		{
			[Token(Token = "0x600213A")]
			[Address(RVA = "0x24A6428", Offset = "0x24A6428", VA = "0x7BBCCA6428")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139544", Offset = "0x1139544")]
			get
			{
				return null;
			}
			[Token(Token = "0x600213B")]
			[Address(RVA = "0x24A6400", Offset = "0x24A6400", VA = "0x7BBCCA6400")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139554", Offset = "0x1139554")]
			set
			{
			}
		}

		// Token: 0x040018A2 RID: 6306
		[Token(Token = "0x40018A2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104034", Offset = "0x1104034")]
		private ulong <id>k__BackingField;

		// Token: 0x040018A3 RID: 6307
		[Token(Token = "0x40018A3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104044", Offset = "0x1104044")]
		private string <name>k__BackingField;

		// Token: 0x040018A4 RID: 6308
		[Token(Token = "0x40018A4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104054", Offset = "0x1104054")]
		private List<RoomPlayerInfo> <members>k__BackingField;

		// Token: 0x040018A5 RID: 6309
		[Token(Token = "0x40018A5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104064", Offset = "0x1104064")]
		private string <abbr_name>k__BackingField;
	}
}
