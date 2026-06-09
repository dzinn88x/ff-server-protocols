using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200051E RID: 1310
	[Token(Token = "0x200051E")]
	[ProtoContract]
	public class RoomInfo
	{
		// Token: 0x060020FE RID: 8446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x24A6458", Offset = "0x24A6458", VA = "0x7BBCCA6458")]
		public RoomInfo()
		{
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x060020FF RID: 8447 RVA: 0x0000E418 File Offset: 0x0000C618
		// (set) Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158770", Offset = "0x1158770")]
		public ulong id
		{
			[Token(Token = "0x60020FF")]
			[Address(RVA = "0x24A6528", Offset = "0x24A6528", VA = "0x7BBCCA6528")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11391A4", Offset = "0x11391A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002100")]
			[Address(RVA = "0x24A6530", Offset = "0x24A6530", VA = "0x7BBCCA6530")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11391B4", Offset = "0x11391B4")]
			set
			{
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002102 RID: 8450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056F")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1158784", Offset = "0x1158784")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158784", Offset = "0x1158784")]
		public string name
		{
			[Token(Token = "0x6002101")]
			[Address(RVA = "0x24A6538", Offset = "0x24A6538", VA = "0x7BBCCA6538")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11391C4", Offset = "0x11391C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002102")]
			[Address(RVA = "0x24A6508", Offset = "0x24A6508", VA = "0x7BBCCA6508")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11391D4", Offset = "0x11391D4")]
			set
			{
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06002103 RID: 8451 RVA: 0x0000E430 File Offset: 0x0000C630
		// (set) Token: 0x06002104 RID: 8452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000570")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11587D4", Offset = "0x11587D4")]
		public ulong owner
		{
			[Token(Token = "0x6002103")]
			[Address(RVA = "0x24A6540", Offset = "0x24A6540", VA = "0x7BBCCA6540")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11391E4", Offset = "0x11391E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002104")]
			[Address(RVA = "0x24A6548", Offset = "0x24A6548", VA = "0x7BBCCA6548")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11391F4", Offset = "0x11391F4")]
			set
			{
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x0000E448 File Offset: 0x0000C648
		// (set) Token: 0x06002106 RID: 8454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000571")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11587E8", Offset = "0x11587E8")]
		public uint map_id
		{
			[Token(Token = "0x6002105")]
			[Address(RVA = "0x24A6550", Offset = "0x24A6550", VA = "0x7BBCCA6550")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139204", Offset = "0x1139204")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002106")]
			[Address(RVA = "0x24A6558", Offset = "0x24A6558", VA = "0x7BBCCA6558")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139214", Offset = "0x1139214")]
			set
			{
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x0000E460 File Offset: 0x0000C660
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000572")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11587FC", Offset = "0x11587FC")]
		public uint game_mode
		{
			[Token(Token = "0x6002107")]
			[Address(RVA = "0x24A6560", Offset = "0x24A6560", VA = "0x7BBCCA6560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139224", Offset = "0x1139224")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002108")]
			[Address(RVA = "0x24A6568", Offset = "0x24A6568", VA = "0x7BBCCA6568")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139234", Offset = "0x1139234")]
			set
			{
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x0000E478 File Offset: 0x0000C678
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000573")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158810", Offset = "0x1158810")]
		public uint group_mode
		{
			[Token(Token = "0x6002109")]
			[Address(RVA = "0x24A6570", Offset = "0x24A6570", VA = "0x7BBCCA6570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139244", Offset = "0x1139244")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600210A")]
			[Address(RVA = "0x24A6578", Offset = "0x24A6578", VA = "0x7BBCCA6578")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139254", Offset = "0x1139254")]
			set
			{
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x0000E490 File Offset: 0x0000C690
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000574")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158824", Offset = "0x1158824")]
		public uint max_member_num
		{
			[Token(Token = "0x600210B")]
			[Address(RVA = "0x24A6580", Offset = "0x24A6580", VA = "0x7BBCCA6580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139264", Offset = "0x1139264")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600210C")]
			[Address(RVA = "0x24A6588", Offset = "0x24A6588", VA = "0x7BBCCA6588")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139274", Offset = "0x1139274")]
			set
			{
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x0000E4A8 File Offset: 0x0000C6A8
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000575")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158838", Offset = "0x1158838")]
		public uint max_spectator_num
		{
			[Token(Token = "0x600210D")]
			[Address(RVA = "0x24A6590", Offset = "0x24A6590", VA = "0x7BBCCA6590")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139284", Offset = "0x1139284")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600210E")]
			[Address(RVA = "0x24A6598", Offset = "0x24A6598", VA = "0x7BBCCA6598")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139294", Offset = "0x1139294")]
			set
			{
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x0000E4C0 File Offset: 0x0000C6C0
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000576")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115884C", Offset = "0x115884C")]
		public uint state
		{
			[Token(Token = "0x600210F")]
			[Address(RVA = "0x24A65A0", Offset = "0x24A65A0", VA = "0x7BBCCA65A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11392A4", Offset = "0x11392A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002110")]
			[Address(RVA = "0x24A65A8", Offset = "0x24A65A8", VA = "0x7BBCCA65A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11392B4", Offset = "0x11392B4")]
			set
			{
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000577")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158860", Offset = "0x1158860")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1158860", Offset = "0x1158860")]
		public string code
		{
			[Token(Token = "0x6002111")]
			[Address(RVA = "0x24A65B0", Offset = "0x24A65B0", VA = "0x7BBCCA65B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11392C4", Offset = "0x11392C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002112")]
			[Address(RVA = "0x24A6510", Offset = "0x24A6510", VA = "0x7BBCCA6510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11392D4", Offset = "0x11392D4")]
			set
			{
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000578")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11588B0", Offset = "0x11588B0")]
		public List<RoomGroupInfo> groups
		{
			[Token(Token = "0x6002113")]
			[Address(RVA = "0x24A65B8", Offset = "0x24A65B8", VA = "0x7BBCCA65B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11392E4", Offset = "0x11392E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002114")]
			[Address(RVA = "0x24A6518", Offset = "0x24A6518", VA = "0x7BBCCA6518")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11392F4", Offset = "0x11392F4")]
			private set
			{
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000579")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11588C4", Offset = "0x11588C4")]
		public List<RoomPlayerInfo> spectators
		{
			[Token(Token = "0x6002115")]
			[Address(RVA = "0x24A65C0", Offset = "0x24A65C0", VA = "0x7BBCCA65C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139304", Offset = "0x1139304")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002116")]
			[Address(RVA = "0x24A6520", Offset = "0x24A6520", VA = "0x7BBCCA6520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139314", Offset = "0x1139314")]
			private set
			{
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x0000E4D8 File Offset: 0x0000C6D8
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11588D8", Offset = "0x11588D8")]
		public bool enable_death_spectate
		{
			[Token(Token = "0x6002117")]
			[Address(RVA = "0x24A65C8", Offset = "0x24A65C8", VA = "0x7BBCCA65C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139324", Offset = "0x1139324")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002118")]
			[Address(RVA = "0x24A65D0", Offset = "0x24A65D0", VA = "0x7BBCCA65D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139334", Offset = "0x1139334")]
			set
			{
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		// (set) Token: 0x0600211A RID: 8474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11588EC", Offset = "0x11588EC")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x6002119")]
			[Address(RVA = "0x24A65DC", Offset = "0x24A65DC", VA = "0x7BBCCA65DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139344", Offset = "0x1139344")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x600211A")]
			[Address(RVA = "0x24A65E4", Offset = "0x24A65E4", VA = "0x7BBCCA65E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139354", Offset = "0x1139354")]
			set
			{
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x0000E508 File Offset: 0x0000C708
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158900", Offset = "0x1158900")]
		public bool enable_group_icon
		{
			[Token(Token = "0x600211B")]
			[Address(RVA = "0x24A65EC", Offset = "0x24A65EC", VA = "0x7BBCCA65EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139364", Offset = "0x1139364")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600211C")]
			[Address(RVA = "0x24A65F4", Offset = "0x24A65F4", VA = "0x7BBCCA65F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139374", Offset = "0x1139374")]
			set
			{
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x0000E520 File Offset: 0x0000C720
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158914", Offset = "0x1158914")]
		public uint match_times
		{
			[Token(Token = "0x600211D")]
			[Address(RVA = "0x24A6600", Offset = "0x24A6600", VA = "0x7BBCCA6600")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139384", Offset = "0x1139384")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600211E")]
			[Address(RVA = "0x24A6608", Offset = "0x24A6608", VA = "0x7BBCCA6608")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139394", Offset = "0x1139394")]
			set
			{
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x0000E538 File Offset: 0x0000C738
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158928", Offset = "0x1158928")]
		public uint level_visual_style
		{
			[Token(Token = "0x600211F")]
			[Address(RVA = "0x24A6610", Offset = "0x24A6610", VA = "0x7BBCCA6610")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11393A4", Offset = "0x11393A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002120")]
			[Address(RVA = "0x24A6618", Offset = "0x24A6618", VA = "0x7BBCCA6618")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11393B4", Offset = "0x11393B4")]
			set
			{
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x0000E550 File Offset: 0x0000C750
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115893C", Offset = "0x115893C")]
		public uint room_setting
		{
			[Token(Token = "0x6002121")]
			[Address(RVA = "0x24A6620", Offset = "0x24A6620", VA = "0x7BBCCA6620")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11393C4", Offset = "0x11393C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002122")]
			[Address(RVA = "0x24A6628", Offset = "0x24A6628", VA = "0x7BBCCA6628")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11393D4", Offset = "0x11393D4")]
			set
			{
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x0000E568 File Offset: 0x0000C768
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000580")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158950", Offset = "0x1158950")]
		public uint room_setting2
		{
			[Token(Token = "0x6002123")]
			[Address(RVA = "0x24A6630", Offset = "0x24A6630", VA = "0x7BBCCA6630")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11393E4", Offset = "0x11393E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002124")]
			[Address(RVA = "0x24A6638", Offset = "0x24A6638", VA = "0x7BBCCA6638")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11393F4", Offset = "0x11393F4")]
			set
			{
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x0000E580 File Offset: 0x0000C780
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000581")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158964", Offset = "0x1158964")]
		public bool enable_emulator_check
		{
			[Token(Token = "0x6002125")]
			[Address(RVA = "0x24A6640", Offset = "0x24A6640", VA = "0x7BBCCA6640")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139404", Offset = "0x1139404")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002126")]
			[Address(RVA = "0x24A6648", Offset = "0x24A6648", VA = "0x7BBCCA6648")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139414", Offset = "0x1139414")]
			set
			{
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x0000E598 File Offset: 0x0000C798
		// (set) Token: 0x06002128 RID: 8488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000582")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158978", Offset = "0x1158978")]
		public bool is_cs_advanced
		{
			[Token(Token = "0x6002127")]
			[Address(RVA = "0x24A6654", Offset = "0x24A6654", VA = "0x7BBCCA6654")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139424", Offset = "0x1139424")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002128")]
			[Address(RVA = "0x24A665C", Offset = "0x24A665C", VA = "0x7BBCCA665C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139434", Offset = "0x1139434")]
			set
			{
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000583")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115898C", Offset = "0x115898C")]
		public byte[] cs_advanced_setting
		{
			[Token(Token = "0x6002129")]
			[Address(RVA = "0x24A6668", Offset = "0x24A6668", VA = "0x7BBCCA6668")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139444", Offset = "0x1139444")]
			get
			{
				return null;
			}
			[Token(Token = "0x600212A")]
			[Address(RVA = "0x24A6670", Offset = "0x24A6670", VA = "0x7BBCCA6670")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139454", Offset = "0x1139454")]
			set
			{
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000584")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11589A0", Offset = "0x11589A0")]
		public uint werewolves_room_param
		{
			[Token(Token = "0x600212B")]
			[Address(RVA = "0x24A6678", Offset = "0x24A6678", VA = "0x7BBCCA6678")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139464", Offset = "0x1139464")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600212C")]
			[Address(RVA = "0x24A6680", Offset = "0x24A6680", VA = "0x7BBCCA6680")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139474", Offset = "0x1139474")]
			set
			{
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000585")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11589B4", Offset = "0x11589B4")]
		public uint werewolves_room_param2
		{
			[Token(Token = "0x600212D")]
			[Address(RVA = "0x24A6688", Offset = "0x24A6688", VA = "0x7BBCCA6688")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139484", Offset = "0x1139484")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600212E")]
			[Address(RVA = "0x24A6690", Offset = "0x24A6690", VA = "0x7BBCCA6690")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139494", Offset = "0x1139494")]
			set
			{
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000586")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11589C8", Offset = "0x11589C8")]
		public uint language
		{
			[Token(Token = "0x600212F")]
			[Address(RVA = "0x24A6698", Offset = "0x24A6698", VA = "0x7BBCCA6698")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11394A4", Offset = "0x11394A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002130")]
			[Address(RVA = "0x24A66A0", Offset = "0x24A66A0", VA = "0x7BBCCA66A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11394B4", Offset = "0x11394B4")]
			set
			{
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000587")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11589DC", Offset = "0x11589DC")]
		public bool contestant_role_check
		{
			[Token(Token = "0x6002131")]
			[Address(RVA = "0x24A66A8", Offset = "0x24A66A8", VA = "0x7BBCCA66A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11394C4", Offset = "0x11394C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002132")]
			[Address(RVA = "0x24A66B0", Offset = "0x24A66B0", VA = "0x7BBCCA66B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11394D4", Offset = "0x11394D4")]
			set
			{
			}
		}

		// Token: 0x04001888 RID: 6280
		[Token(Token = "0x4001888")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103E94", Offset = "0x1103E94")]
		private ulong <id>k__BackingField;

		// Token: 0x04001889 RID: 6281
		[Token(Token = "0x4001889")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103EA4", Offset = "0x1103EA4")]
		private string <name>k__BackingField;

		// Token: 0x0400188A RID: 6282
		[Token(Token = "0x400188A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103EB4", Offset = "0x1103EB4")]
		private ulong <owner>k__BackingField;

		// Token: 0x0400188B RID: 6283
		[Token(Token = "0x400188B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103EC4", Offset = "0x1103EC4")]
		private uint <map_id>k__BackingField;

		// Token: 0x0400188C RID: 6284
		[Token(Token = "0x400188C")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103ED4", Offset = "0x1103ED4")]
		private uint <game_mode>k__BackingField;

		// Token: 0x0400188D RID: 6285
		[Token(Token = "0x400188D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103EE4", Offset = "0x1103EE4")]
		private uint <group_mode>k__BackingField;

		// Token: 0x0400188E RID: 6286
		[Token(Token = "0x400188E")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103EF4", Offset = "0x1103EF4")]
		private uint <max_member_num>k__BackingField;

		// Token: 0x0400188F RID: 6287
		[Token(Token = "0x400188F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F04", Offset = "0x1103F04")]
		private uint <max_spectator_num>k__BackingField;

		// Token: 0x04001890 RID: 6288
		[Token(Token = "0x4001890")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F14", Offset = "0x1103F14")]
		private uint <state>k__BackingField;

		// Token: 0x04001891 RID: 6289
		[Token(Token = "0x4001891")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F24", Offset = "0x1103F24")]
		private string <code>k__BackingField;

		// Token: 0x04001892 RID: 6290
		[Token(Token = "0x4001892")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F34", Offset = "0x1103F34")]
		private List<RoomGroupInfo> <groups>k__BackingField;

		// Token: 0x04001893 RID: 6291
		[Token(Token = "0x4001893")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F44", Offset = "0x1103F44")]
		private List<RoomPlayerInfo> <spectators>k__BackingField;

		// Token: 0x04001894 RID: 6292
		[Token(Token = "0x4001894")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F54", Offset = "0x1103F54")]
		private bool <enable_death_spectate>k__BackingField;

		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F64", Offset = "0x1103F64")]
		private ERoom.Type <room_type>k__BackingField;

		// Token: 0x04001896 RID: 6294
		[Token(Token = "0x4001896")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F74", Offset = "0x1103F74")]
		private bool <enable_group_icon>k__BackingField;

		// Token: 0x04001897 RID: 6295
		[Token(Token = "0x4001897")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F84", Offset = "0x1103F84")]
		private uint <match_times>k__BackingField;

		// Token: 0x04001898 RID: 6296
		[Token(Token = "0x4001898")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103F94", Offset = "0x1103F94")]
		private uint <level_visual_style>k__BackingField;

		// Token: 0x04001899 RID: 6297
		[Token(Token = "0x4001899")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103FA4", Offset = "0x1103FA4")]
		private uint <room_setting>k__BackingField;

		// Token: 0x0400189A RID: 6298
		[Token(Token = "0x400189A")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103FB4", Offset = "0x1103FB4")]
		private uint <room_setting2>k__BackingField;

		// Token: 0x0400189B RID: 6299
		[Token(Token = "0x400189B")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103FC4", Offset = "0x1103FC4")]
		private bool <enable_emulator_check>k__BackingField;

		// Token: 0x0400189C RID: 6300
		[Token(Token = "0x400189C")]
		[FieldOffset(Offset = "0x75")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103FD4", Offset = "0x1103FD4")]
		private bool <is_cs_advanced>k__BackingField;

		// Token: 0x0400189D RID: 6301
		[Token(Token = "0x400189D")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103FE4", Offset = "0x1103FE4")]
		private byte[] <cs_advanced_setting>k__BackingField;

		// Token: 0x0400189E RID: 6302
		[Token(Token = "0x400189E")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103FF4", Offset = "0x1103FF4")]
		private uint <werewolves_room_param>k__BackingField;

		// Token: 0x0400189F RID: 6303
		[Token(Token = "0x400189F")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104004", Offset = "0x1104004")]
		private uint <werewolves_room_param2>k__BackingField;

		// Token: 0x040018A0 RID: 6304
		[Token(Token = "0x40018A0")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104014", Offset = "0x1104014")]
		private uint <language>k__BackingField;

		// Token: 0x040018A1 RID: 6305
		[Token(Token = "0x40018A1")]
		[FieldOffset(Offset = "0x8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104024", Offset = "0x1104024")]
		private bool <contestant_role_check>k__BackingField;
	}
}
