using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000514 RID: 1300
	[Token(Token = "0x2000514")]
	[ProtoContract]
	public class RoomChangeReq
	{
		// Token: 0x06002072 RID: 8306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002072")]
		[Address(RVA = "0x24A5F38", Offset = "0x24A5F38", VA = "0x7BBCCA5F38")]
		public RoomChangeReq()
		{
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0000DE90 File Offset: 0x0000C090
		// (set) Token: 0x06002074 RID: 8308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11581A8", Offset = "0x11581A8")]
		public ulong room_id
		{
			[Token(Token = "0x6002073")]
			[Address(RVA = "0x24A5FA4", Offset = "0x24A5FA4", VA = "0x7BBCCA5FA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138984", Offset = "0x1138984")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x24A5FAC", Offset = "0x24A5FAC", VA = "0x7BBCCA5FAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138994", Offset = "0x1138994")]
			set
			{
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002076 RID: 8310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11581BC", Offset = "0x11581BC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11581BC", Offset = "0x11581BC")]
		public string room_name
		{
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x24A5FB4", Offset = "0x24A5FB4", VA = "0x7BBCCA5FB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11389A4", Offset = "0x11389A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002076")]
			[Address(RVA = "0x24A5F94", Offset = "0x24A5F94", VA = "0x7BBCCA5F94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11389B4", Offset = "0x11389B4")]
			set
			{
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002078 RID: 8312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115820C", Offset = "0x115820C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x115820C", Offset = "0x115820C")]
		public string code
		{
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x24A5FBC", Offset = "0x24A5FBC", VA = "0x7BBCCA5FBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11389C4", Offset = "0x11389C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x24A5F9C", Offset = "0x24A5F9C", VA = "0x7BBCCA5F9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11389D4", Offset = "0x11389D4")]
			set
			{
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		// (set) Token: 0x0600207A RID: 8314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000530")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115825C", Offset = "0x115825C")]
		public uint map_id
		{
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x24A5FC4", Offset = "0x24A5FC4", VA = "0x7BBCCA5FC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11389E4", Offset = "0x11389E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x24A5FCC", Offset = "0x24A5FCC", VA = "0x7BBCCA5FCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11389F4", Offset = "0x11389F4")]
			set
			{
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		// (set) Token: 0x0600207C RID: 8316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000531")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158270", Offset = "0x1158270")]
		public uint game_mode
		{
			[Token(Token = "0x600207B")]
			[Address(RVA = "0x24A5FD4", Offset = "0x24A5FD4", VA = "0x7BBCCA5FD4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A04", Offset = "0x1138A04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600207C")]
			[Address(RVA = "0x24A5FDC", Offset = "0x24A5FDC", VA = "0x7BBCCA5FDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A14", Offset = "0x1138A14")]
			set
			{
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		// (set) Token: 0x0600207E RID: 8318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000532")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158284", Offset = "0x1158284")]
		public uint max_member_num
		{
			[Token(Token = "0x600207D")]
			[Address(RVA = "0x24A5FE4", Offset = "0x24A5FE4", VA = "0x7BBCCA5FE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A24", Offset = "0x1138A24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600207E")]
			[Address(RVA = "0x24A5FEC", Offset = "0x24A5FEC", VA = "0x7BBCCA5FEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A34", Offset = "0x1138A34")]
			set
			{
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000533")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158298", Offset = "0x1158298")]
		public uint max_spectator_num
		{
			[Token(Token = "0x600207F")]
			[Address(RVA = "0x24A5FF4", Offset = "0x24A5FF4", VA = "0x7BBCCA5FF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A44", Offset = "0x1138A44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002080")]
			[Address(RVA = "0x24A5FFC", Offset = "0x24A5FFC", VA = "0x7BBCCA5FFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A54", Offset = "0x1138A54")]
			set
			{
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0000DF08 File Offset: 0x0000C108
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000534")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11582AC", Offset = "0x11582AC")]
		public bool enable_death_spectate
		{
			[Token(Token = "0x6002081")]
			[Address(RVA = "0x24A6004", Offset = "0x24A6004", VA = "0x7BBCCA6004")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A64", Offset = "0x1138A64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002082")]
			[Address(RVA = "0x24A600C", Offset = "0x24A600C", VA = "0x7BBCCA600C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A74", Offset = "0x1138A74")]
			set
			{
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0000DF20 File Offset: 0x0000C120
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000535")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11582C0", Offset = "0x11582C0")]
		public bool enable_group_icon
		{
			[Token(Token = "0x6002083")]
			[Address(RVA = "0x24A6018", Offset = "0x24A6018", VA = "0x7BBCCA6018")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A84", Offset = "0x1138A84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002084")]
			[Address(RVA = "0x24A6020", Offset = "0x24A6020", VA = "0x7BBCCA6020")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138A94", Offset = "0x1138A94")]
			set
			{
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0000DF38 File Offset: 0x0000C138
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000536")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11582D4", Offset = "0x11582D4")]
		public uint level_visual_style
		{
			[Token(Token = "0x6002085")]
			[Address(RVA = "0x24A602C", Offset = "0x24A602C", VA = "0x7BBCCA602C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138AA4", Offset = "0x1138AA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002086")]
			[Address(RVA = "0x24A6034", Offset = "0x24A6034", VA = "0x7BBCCA6034")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138AB4", Offset = "0x1138AB4")]
			set
			{
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0000DF50 File Offset: 0x0000C150
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000537")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11582E8", Offset = "0x11582E8")]
		public uint room_setting
		{
			[Token(Token = "0x6002087")]
			[Address(RVA = "0x24A603C", Offset = "0x24A603C", VA = "0x7BBCCA603C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138AC4", Offset = "0x1138AC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002088")]
			[Address(RVA = "0x24A6044", Offset = "0x24A6044", VA = "0x7BBCCA6044")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138AD4", Offset = "0x1138AD4")]
			set
			{
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0000DF68 File Offset: 0x0000C168
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000538")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11582FC", Offset = "0x11582FC")]
		public uint room_setting2
		{
			[Token(Token = "0x6002089")]
			[Address(RVA = "0x24A604C", Offset = "0x24A604C", VA = "0x7BBCCA604C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138AE4", Offset = "0x1138AE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600208A")]
			[Address(RVA = "0x24A6054", Offset = "0x24A6054", VA = "0x7BBCCA6054")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138AF4", Offset = "0x1138AF4")]
			set
			{
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0000DF80 File Offset: 0x0000C180
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000539")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158310", Offset = "0x1158310")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x600208B")]
			[Address(RVA = "0x24A605C", Offset = "0x24A605C", VA = "0x7BBCCA605C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B04", Offset = "0x1138B04")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x600208C")]
			[Address(RVA = "0x24A6064", Offset = "0x24A6064", VA = "0x7BBCCA6064")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B14", Offset = "0x1138B14")]
			set
			{
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158324", Offset = "0x1158324")]
		public byte[] cs_advanced_setting
		{
			[Token(Token = "0x600208D")]
			[Address(RVA = "0x24A606C", Offset = "0x24A606C", VA = "0x7BBCCA606C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B24", Offset = "0x1138B24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600208E")]
			[Address(RVA = "0x24A6074", Offset = "0x24A6074", VA = "0x7BBCCA6074")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B34", Offset = "0x1138B34")]
			set
			{
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0000DF98 File Offset: 0x0000C198
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158338", Offset = "0x1158338")]
		public uint werewolves_room_param
		{
			[Token(Token = "0x600208F")]
			[Address(RVA = "0x24A607C", Offset = "0x24A607C", VA = "0x7BBCCA607C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B44", Offset = "0x1138B44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002090")]
			[Address(RVA = "0x24A6084", Offset = "0x24A6084", VA = "0x7BBCCA6084")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B54", Offset = "0x1138B54")]
			set
			{
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115834C", Offset = "0x115834C")]
		public uint werewolves_room_param2
		{
			[Token(Token = "0x6002091")]
			[Address(RVA = "0x24A608C", Offset = "0x24A608C", VA = "0x7BBCCA608C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B64", Offset = "0x1138B64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002092")]
			[Address(RVA = "0x24A6094", Offset = "0x24A6094", VA = "0x7BBCCA6094")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138B74", Offset = "0x1138B74")]
			set
			{
			}
		}

		// Token: 0x04001847 RID: 6215
		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A84", Offset = "0x1103A84")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001848 RID: 6216
		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A94", Offset = "0x1103A94")]
		private string <room_name>k__BackingField;

		// Token: 0x04001849 RID: 6217
		[Token(Token = "0x4001849")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103AA4", Offset = "0x1103AA4")]
		private string <code>k__BackingField;

		// Token: 0x0400184A RID: 6218
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103AB4", Offset = "0x1103AB4")]
		private uint <map_id>k__BackingField;

		// Token: 0x0400184B RID: 6219
		[Token(Token = "0x400184B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103AC4", Offset = "0x1103AC4")]
		private uint <game_mode>k__BackingField;

		// Token: 0x0400184C RID: 6220
		[Token(Token = "0x400184C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103AD4", Offset = "0x1103AD4")]
		private uint <max_member_num>k__BackingField;

		// Token: 0x0400184D RID: 6221
		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103AE4", Offset = "0x1103AE4")]
		private uint <max_spectator_num>k__BackingField;

		// Token: 0x0400184E RID: 6222
		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103AF4", Offset = "0x1103AF4")]
		private bool <enable_death_spectate>k__BackingField;

		// Token: 0x0400184F RID: 6223
		[Token(Token = "0x400184F")]
		[FieldOffset(Offset = "0x39")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B04", Offset = "0x1103B04")]
		private bool <enable_group_icon>k__BackingField;

		// Token: 0x04001850 RID: 6224
		[Token(Token = "0x4001850")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B14", Offset = "0x1103B14")]
		private uint <level_visual_style>k__BackingField;

		// Token: 0x04001851 RID: 6225
		[Token(Token = "0x4001851")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B24", Offset = "0x1103B24")]
		private uint <room_setting>k__BackingField;

		// Token: 0x04001852 RID: 6226
		[Token(Token = "0x4001852")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B34", Offset = "0x1103B34")]
		private uint <room_setting2>k__BackingField;

		// Token: 0x04001853 RID: 6227
		[Token(Token = "0x4001853")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B44", Offset = "0x1103B44")]
		private ERoom.Type <room_type>k__BackingField;

		// Token: 0x04001854 RID: 6228
		[Token(Token = "0x4001854")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B54", Offset = "0x1103B54")]
		private byte[] <cs_advanced_setting>k__BackingField;

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B64", Offset = "0x1103B64")]
		private uint <werewolves_room_param>k__BackingField;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103B74", Offset = "0x1103B74")]
		private uint <werewolves_room_param2>k__BackingField;
	}
}
