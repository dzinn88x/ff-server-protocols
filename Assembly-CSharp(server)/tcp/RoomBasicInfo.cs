using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	[ProtoContract]
	public class RoomBasicInfo
	{
		// Token: 0x060020D3 RID: 8403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x24A5CD4", Offset = "0x24A5CD4", VA = "0x7BBCCA5CD4")]
		public RoomBasicInfo()
		{
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x0000E238 File Offset: 0x0000C438
		// (set) Token: 0x060020D5 RID: 8405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000559")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158590", Offset = "0x1158590")]
		public ulong id
		{
			[Token(Token = "0x60020D4")]
			[Address(RVA = "0x24A5D38", Offset = "0x24A5D38", VA = "0x7BBCCA5D38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F04", Offset = "0x1138F04")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020D5")]
			[Address(RVA = "0x24A5D40", Offset = "0x24A5D40", VA = "0x7BBCCA5D40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F14", Offset = "0x1138F14")]
			set
			{
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x060020D6 RID: 8406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020D7 RID: 8407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11585A4", Offset = "0x11585A4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11585A4", Offset = "0x11585A4")]
		public string name
		{
			[Token(Token = "0x60020D6")]
			[Address(RVA = "0x24A5D48", Offset = "0x24A5D48", VA = "0x7BBCCA5D48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F24", Offset = "0x1138F24")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020D7")]
			[Address(RVA = "0x24A5D30", Offset = "0x24A5D30", VA = "0x7BBCCA5D30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F34", Offset = "0x1138F34")]
			set
			{
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x0000E250 File Offset: 0x0000C450
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11585F4", Offset = "0x11585F4")]
		public uint map_id
		{
			[Token(Token = "0x60020D8")]
			[Address(RVA = "0x24A5D50", Offset = "0x24A5D50", VA = "0x7BBCCA5D50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F44", Offset = "0x1138F44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020D9")]
			[Address(RVA = "0x24A5D58", Offset = "0x24A5D58", VA = "0x7BBCCA5D58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F54", Offset = "0x1138F54")]
			set
			{
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x0000E268 File Offset: 0x0000C468
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158608", Offset = "0x1158608")]
		public uint game_mode
		{
			[Token(Token = "0x60020DA")]
			[Address(RVA = "0x24A5D60", Offset = "0x24A5D60", VA = "0x7BBCCA5D60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F64", Offset = "0x1138F64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020DB")]
			[Address(RVA = "0x24A5D68", Offset = "0x24A5D68", VA = "0x7BBCCA5D68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F74", Offset = "0x1138F74")]
			set
			{
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x0000E280 File Offset: 0x0000C480
		// (set) Token: 0x060020DD RID: 8413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115861C", Offset = "0x115861C")]
		public uint group_mode
		{
			[Token(Token = "0x60020DC")]
			[Address(RVA = "0x24A5D70", Offset = "0x24A5D70", VA = "0x7BBCCA5D70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F84", Offset = "0x1138F84")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020DD")]
			[Address(RVA = "0x24A5D78", Offset = "0x24A5D78", VA = "0x7BBCCA5D78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138F94", Offset = "0x1138F94")]
			set
			{
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x0000E298 File Offset: 0x0000C498
		// (set) Token: 0x060020DF RID: 8415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158630", Offset = "0x1158630")]
		public uint cur_member_num
		{
			[Token(Token = "0x60020DE")]
			[Address(RVA = "0x24A5D80", Offset = "0x24A5D80", VA = "0x7BBCCA5D80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138FA4", Offset = "0x1138FA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020DF")]
			[Address(RVA = "0x24A5D88", Offset = "0x24A5D88", VA = "0x7BBCCA5D88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138FB4", Offset = "0x1138FB4")]
			set
			{
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700055F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158644", Offset = "0x1158644")]
		public uint max_member_num
		{
			[Token(Token = "0x60020E0")]
			[Address(RVA = "0x24A5D90", Offset = "0x24A5D90", VA = "0x7BBCCA5D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138FC4", Offset = "0x1138FC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020E1")]
			[Address(RVA = "0x24A5D98", Offset = "0x24A5D98", VA = "0x7BBCCA5D98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138FD4", Offset = "0x1138FD4")]
			set
			{
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000560")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158658", Offset = "0x1158658")]
		public uint cur_spectator_num
		{
			[Token(Token = "0x60020E2")]
			[Address(RVA = "0x24A5DA0", Offset = "0x24A5DA0", VA = "0x7BBCCA5DA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138FE4", Offset = "0x1138FE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020E3")]
			[Address(RVA = "0x24A5DA8", Offset = "0x24A5DA8", VA = "0x7BBCCA5DA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138FF4", Offset = "0x1138FF4")]
			set
			{
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000561")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115866C", Offset = "0x115866C")]
		public uint max_spectator_num
		{
			[Token(Token = "0x60020E4")]
			[Address(RVA = "0x24A5DB0", Offset = "0x24A5DB0", VA = "0x7BBCCA5DB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139004", Offset = "0x1139004")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020E5")]
			[Address(RVA = "0x24A5DB8", Offset = "0x24A5DB8", VA = "0x7BBCCA5DB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139014", Offset = "0x1139014")]
			set
			{
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000562")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158680", Offset = "0x1158680")]
		public uint state
		{
			[Token(Token = "0x60020E6")]
			[Address(RVA = "0x24A5DC0", Offset = "0x24A5DC0", VA = "0x7BBCCA5DC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139024", Offset = "0x1139024")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020E7")]
			[Address(RVA = "0x24A5DC8", Offset = "0x24A5DC8", VA = "0x7BBCCA5DC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139034", Offset = "0x1139034")]
			set
			{
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x0000E310 File Offset: 0x0000C510
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000563")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158694", Offset = "0x1158694")]
		public bool need_code
		{
			[Token(Token = "0x60020E8")]
			[Address(RVA = "0x24A5DD0", Offset = "0x24A5DD0", VA = "0x7BBCCA5DD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139044", Offset = "0x1139044")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020E9")]
			[Address(RVA = "0x24A5DD8", Offset = "0x24A5DD8", VA = "0x7BBCCA5DD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139054", Offset = "0x1139054")]
			set
			{
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x0000E328 File Offset: 0x0000C528
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000564")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11586A8", Offset = "0x11586A8")]
		public uint banner
		{
			[Token(Token = "0x60020EA")]
			[Address(RVA = "0x24A5DE4", Offset = "0x24A5DE4", VA = "0x7BBCCA5DE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139064", Offset = "0x1139064")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020EB")]
			[Address(RVA = "0x24A5DEC", Offset = "0x24A5DEC", VA = "0x7BBCCA5DEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139074", Offset = "0x1139074")]
			set
			{
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x0000E340 File Offset: 0x0000C540
		// (set) Token: 0x060020ED RID: 8429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000565")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11586BC", Offset = "0x11586BC")]
		public uint color
		{
			[Token(Token = "0x60020EC")]
			[Address(RVA = "0x24A5DF4", Offset = "0x24A5DF4", VA = "0x7BBCCA5DF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139084", Offset = "0x1139084")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020ED")]
			[Address(RVA = "0x24A5DFC", Offset = "0x24A5DFC", VA = "0x7BBCCA5DFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139094", Offset = "0x1139094")]
			set
			{
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x0000E358 File Offset: 0x0000C558
		// (set) Token: 0x060020EF RID: 8431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000566")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11586D0", Offset = "0x11586D0")]
		public uint icon
		{
			[Token(Token = "0x60020EE")]
			[Address(RVA = "0x24A5E04", Offset = "0x24A5E04", VA = "0x7BBCCA5E04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11390A4", Offset = "0x11390A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020EF")]
			[Address(RVA = "0x24A5E0C", Offset = "0x24A5E0C", VA = "0x7BBCCA5E0C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11390B4", Offset = "0x11390B4")]
			set
			{
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x060020F0 RID: 8432 RVA: 0x0000E370 File Offset: 0x0000C570
		// (set) Token: 0x060020F1 RID: 8433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000567")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11586E4", Offset = "0x11586E4")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x60020F0")]
			[Address(RVA = "0x24A5E14", Offset = "0x24A5E14", VA = "0x7BBCCA5E14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11390C4", Offset = "0x11390C4")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x60020F1")]
			[Address(RVA = "0x24A5E1C", Offset = "0x24A5E1C", VA = "0x7BBCCA5E1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11390D4", Offset = "0x11390D4")]
			set
			{
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060020F2 RID: 8434 RVA: 0x0000E388 File Offset: 0x0000C588
		// (set) Token: 0x060020F3 RID: 8435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000568")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11586F8", Offset = "0x11586F8")]
		public uint level_visual_style
		{
			[Token(Token = "0x60020F2")]
			[Address(RVA = "0x24A5E24", Offset = "0x24A5E24", VA = "0x7BBCCA5E24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11390E4", Offset = "0x11390E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020F3")]
			[Address(RVA = "0x24A5E2C", Offset = "0x24A5E2C", VA = "0x7BBCCA5E2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11390F4", Offset = "0x11390F4")]
			set
			{
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		// (set) Token: 0x060020F5 RID: 8437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000569")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115870C", Offset = "0x115870C")]
		public bool enable_emulator_check
		{
			[Token(Token = "0x60020F4")]
			[Address(RVA = "0x24A5E34", Offset = "0x24A5E34", VA = "0x7BBCCA5E34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139104", Offset = "0x1139104")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020F5")]
			[Address(RVA = "0x24A5E3C", Offset = "0x24A5E3C", VA = "0x7BBCCA5E3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139114", Offset = "0x1139114")]
			set
			{
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		// (set) Token: 0x060020F7 RID: 8439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158720", Offset = "0x1158720")]
		public uint owner_role
		{
			[Token(Token = "0x60020F6")]
			[Address(RVA = "0x24A5E48", Offset = "0x24A5E48", VA = "0x7BBCCA5E48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139124", Offset = "0x1139124")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020F7")]
			[Address(RVA = "0x24A5E50", Offset = "0x24A5E50", VA = "0x7BBCCA5E50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139134", Offset = "0x1139134")]
			set
			{
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158734", Offset = "0x1158734")]
		public bool is_cs_advanced
		{
			[Token(Token = "0x60020F8")]
			[Address(RVA = "0x24A5E58", Offset = "0x24A5E58", VA = "0x7BBCCA5E58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139144", Offset = "0x1139144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020F9")]
			[Address(RVA = "0x24A5E60", Offset = "0x24A5E60", VA = "0x7BBCCA5E60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139154", Offset = "0x1139154")]
			set
			{
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158748", Offset = "0x1158748")]
		public uint language
		{
			[Token(Token = "0x60020FA")]
			[Address(RVA = "0x24A5E6C", Offset = "0x24A5E6C", VA = "0x7BBCCA5E6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139164", Offset = "0x1139164")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020FB")]
			[Address(RVA = "0x24A5E74", Offset = "0x24A5E74", VA = "0x7BBCCA5E74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139174", Offset = "0x1139174")]
			set
			{
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0000E400 File Offset: 0x0000C600
		// (set) Token: 0x060020FD RID: 8445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115875C", Offset = "0x115875C")]
		public bool contestant_role_check
		{
			[Token(Token = "0x60020FC")]
			[Address(RVA = "0x24A5E7C", Offset = "0x24A5E7C", VA = "0x7BBCCA5E7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139184", Offset = "0x1139184")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020FD")]
			[Address(RVA = "0x24A5E84", Offset = "0x24A5E84", VA = "0x7BBCCA5E84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139194", Offset = "0x1139194")]
			set
			{
			}
		}

		// Token: 0x04001873 RID: 6259
		[Token(Token = "0x4001873")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D44", Offset = "0x1103D44")]
		private ulong <id>k__BackingField;

		// Token: 0x04001874 RID: 6260
		[Token(Token = "0x4001874")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D54", Offset = "0x1103D54")]
		private string <name>k__BackingField;

		// Token: 0x04001875 RID: 6261
		[Token(Token = "0x4001875")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D64", Offset = "0x1103D64")]
		private uint <map_id>k__BackingField;

		// Token: 0x04001876 RID: 6262
		[Token(Token = "0x4001876")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D74", Offset = "0x1103D74")]
		private uint <game_mode>k__BackingField;

		// Token: 0x04001877 RID: 6263
		[Token(Token = "0x4001877")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D84", Offset = "0x1103D84")]
		private uint <group_mode>k__BackingField;

		// Token: 0x04001878 RID: 6264
		[Token(Token = "0x4001878")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D94", Offset = "0x1103D94")]
		private uint <cur_member_num>k__BackingField;

		// Token: 0x04001879 RID: 6265
		[Token(Token = "0x4001879")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103DA4", Offset = "0x1103DA4")]
		private uint <max_member_num>k__BackingField;

		// Token: 0x0400187A RID: 6266
		[Token(Token = "0x400187A")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103DB4", Offset = "0x1103DB4")]
		private uint <cur_spectator_num>k__BackingField;

		// Token: 0x0400187B RID: 6267
		[Token(Token = "0x400187B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103DC4", Offset = "0x1103DC4")]
		private uint <max_spectator_num>k__BackingField;

		// Token: 0x0400187C RID: 6268
		[Token(Token = "0x400187C")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103DD4", Offset = "0x1103DD4")]
		private uint <state>k__BackingField;

		// Token: 0x0400187D RID: 6269
		[Token(Token = "0x400187D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103DE4", Offset = "0x1103DE4")]
		private bool <need_code>k__BackingField;

		// Token: 0x0400187E RID: 6270
		[Token(Token = "0x400187E")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103DF4", Offset = "0x1103DF4")]
		private uint <banner>k__BackingField;

		// Token: 0x0400187F RID: 6271
		[Token(Token = "0x400187F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E04", Offset = "0x1103E04")]
		private uint <color>k__BackingField;

		// Token: 0x04001880 RID: 6272
		[Token(Token = "0x4001880")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E14", Offset = "0x1103E14")]
		private uint <icon>k__BackingField;

		// Token: 0x04001881 RID: 6273
		[Token(Token = "0x4001881")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E24", Offset = "0x1103E24")]
		private ERoom.Type <room_type>k__BackingField;

		// Token: 0x04001882 RID: 6274
		[Token(Token = "0x4001882")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E34", Offset = "0x1103E34")]
		private uint <level_visual_style>k__BackingField;

		// Token: 0x04001883 RID: 6275
		[Token(Token = "0x4001883")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E44", Offset = "0x1103E44")]
		private bool <enable_emulator_check>k__BackingField;

		// Token: 0x04001884 RID: 6276
		[Token(Token = "0x4001884")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E54", Offset = "0x1103E54")]
		private uint <owner_role>k__BackingField;

		// Token: 0x04001885 RID: 6277
		[Token(Token = "0x4001885")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E64", Offset = "0x1103E64")]
		private bool <is_cs_advanced>k__BackingField;

		// Token: 0x04001886 RID: 6278
		[Token(Token = "0x4001886")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E74", Offset = "0x1103E74")]
		private uint <language>k__BackingField;

		// Token: 0x04001887 RID: 6279
		[Token(Token = "0x4001887")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E84", Offset = "0x1103E84")]
		private bool <contestant_role_check>k__BackingField;
	}
}
