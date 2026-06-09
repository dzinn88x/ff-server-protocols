using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x2000508")]
	[ProtoContract]
	public class RoomCreateReq
	{
		// Token: 0x06001FE0 RID: 8160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x24A60DC", Offset = "0x24A60DC", VA = "0x7BBCCA60DC")]
		public RoomCreateReq()
		{
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x0000DA88 File Offset: 0x0000BC88
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157A28", Offset = "0x1157A28")]
		public uint map_id
		{
			[Token(Token = "0x6001FE1")]
			[Address(RVA = "0x24A6178", Offset = "0x24A6178", VA = "0x7BBCCA6178")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138124", Offset = "0x1138124")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FE2")]
			[Address(RVA = "0x24A6180", Offset = "0x24A6180", VA = "0x7BBCCA6180")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138134", Offset = "0x1138134")]
			set
			{
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157A3C", Offset = "0x1157A3C")]
		public uint game_mode
		{
			[Token(Token = "0x6001FE3")]
			[Address(RVA = "0x24A6188", Offset = "0x24A6188", VA = "0x7BBCCA6188")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138144", Offset = "0x1138144")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FE4")]
			[Address(RVA = "0x24A6190", Offset = "0x24A6190", VA = "0x7BBCCA6190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138154", Offset = "0x1138154")]
			set
			{
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157A50", Offset = "0x1157A50")]
		public uint group_mode
		{
			[Token(Token = "0x6001FE5")]
			[Address(RVA = "0x24A6198", Offset = "0x24A6198", VA = "0x7BBCCA6198")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138164", Offset = "0x1138164")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FE6")]
			[Address(RVA = "0x24A61A0", Offset = "0x24A61A0", VA = "0x7BBCCA61A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138174", Offset = "0x1138174")]
			set
			{
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004ED")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157A64", Offset = "0x1157A64")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157A64", Offset = "0x1157A64")]
		public string room_name
		{
			[Token(Token = "0x6001FE7")]
			[Address(RVA = "0x24A61A8", Offset = "0x24A61A8", VA = "0x7BBCCA61A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138184", Offset = "0x1138184")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE8")]
			[Address(RVA = "0x24A6160", Offset = "0x24A6160", VA = "0x7BBCCA6160")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138194", Offset = "0x1138194")]
			set
			{
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EE")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157AB4", Offset = "0x1157AB4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157AB4", Offset = "0x1157AB4")]
		public string code
		{
			[Token(Token = "0x6001FE9")]
			[Address(RVA = "0x24A61B0", Offset = "0x24A61B0", VA = "0x7BBCCA61B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11381A4", Offset = "0x11381A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FEA")]
			[Address(RVA = "0x24A6168", Offset = "0x24A6168", VA = "0x7BBCCA6168")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11381B4", Offset = "0x11381B4")]
			set
			{
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0000DAD0 File Offset: 0x0000BCD0
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004EF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157B04", Offset = "0x1157B04")]
		public uint max_member_num
		{
			[Token(Token = "0x6001FEB")]
			[Address(RVA = "0x24A61B8", Offset = "0x24A61B8", VA = "0x7BBCCA61B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11381C4", Offset = "0x11381C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FEC")]
			[Address(RVA = "0x24A61C0", Offset = "0x24A61C0", VA = "0x7BBCCA61C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11381D4", Offset = "0x11381D4")]
			set
			{
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157B18", Offset = "0x1157B18")]
		public uint max_spectator_num
		{
			[Token(Token = "0x6001FED")]
			[Address(RVA = "0x24A61C8", Offset = "0x24A61C8", VA = "0x7BBCCA61C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11381E4", Offset = "0x11381E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FEE")]
			[Address(RVA = "0x24A61D0", Offset = "0x24A61D0", VA = "0x7BBCCA61D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11381F4", Offset = "0x11381F4")]
			set
			{
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x0000DB00 File Offset: 0x0000BD00
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157B2C", Offset = "0x1157B2C")]
		public bool enable_death_spectate
		{
			[Token(Token = "0x6001FEF")]
			[Address(RVA = "0x24A61D8", Offset = "0x24A61D8", VA = "0x7BBCCA61D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138204", Offset = "0x1138204")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FF0")]
			[Address(RVA = "0x24A61E0", Offset = "0x24A61E0", VA = "0x7BBCCA61E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138214", Offset = "0x1138214")]
			set
			{
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0000DB18 File Offset: 0x0000BD18
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157B40", Offset = "0x1157B40")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x6001FF1")]
			[Address(RVA = "0x24A61EC", Offset = "0x24A61EC", VA = "0x7BBCCA61EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138224", Offset = "0x1138224")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x6001FF2")]
			[Address(RVA = "0x24A61F4", Offset = "0x24A61F4", VA = "0x7BBCCA61F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138234", Offset = "0x1138234")]
			set
			{
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0000DB30 File Offset: 0x0000BD30
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157B54", Offset = "0x1157B54")]
		public ulong group_id
		{
			[Token(Token = "0x6001FF3")]
			[Address(RVA = "0x24A61FC", Offset = "0x24A61FC", VA = "0x7BBCCA61FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138244", Offset = "0x1138244")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001FF4")]
			[Address(RVA = "0x24A6204", Offset = "0x24A6204", VA = "0x7BBCCA6204")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138254", Offset = "0x1138254")]
			set
			{
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0000DB48 File Offset: 0x0000BD48
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157B68", Offset = "0x1157B68")]
		public bool enable_group_icon
		{
			[Token(Token = "0x6001FF5")]
			[Address(RVA = "0x24A620C", Offset = "0x24A620C", VA = "0x7BBCCA620C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138264", Offset = "0x1138264")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FF6")]
			[Address(RVA = "0x24A6214", Offset = "0x24A6214", VA = "0x7BBCCA6214")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138274", Offset = "0x1138274")]
			set
			{
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x0000DB60 File Offset: 0x0000BD60
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157B7C", Offset = "0x1157B7C")]
		public uint level_visual_style
		{
			[Token(Token = "0x6001FF7")]
			[Address(RVA = "0x24A6220", Offset = "0x24A6220", VA = "0x7BBCCA6220")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138284", Offset = "0x1138284")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FF8")]
			[Address(RVA = "0x24A6228", Offset = "0x24A6228", VA = "0x7BBCCA6228")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138294", Offset = "0x1138294")]
			set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x0000DB78 File Offset: 0x0000BD78
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157B90", Offset = "0x1157B90")]
		public ulong room_id
		{
			[Token(Token = "0x6001FF9")]
			[Address(RVA = "0x24A6230", Offset = "0x24A6230", VA = "0x7BBCCA6230")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11382A4", Offset = "0x11382A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001FFA")]
			[Address(RVA = "0x24A6238", Offset = "0x24A6238", VA = "0x7BBCCA6238")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11382B4", Offset = "0x11382B4")]
			set
			{
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0000DB90 File Offset: 0x0000BD90
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157BA4", Offset = "0x1157BA4")]
		public uint room_setting
		{
			[Token(Token = "0x6001FFB")]
			[Address(RVA = "0x24A6240", Offset = "0x24A6240", VA = "0x7BBCCA6240")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11382C4", Offset = "0x11382C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001FFC")]
			[Address(RVA = "0x24A6248", Offset = "0x24A6248", VA = "0x7BBCCA6248")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11382D4", Offset = "0x11382D4")]
			set
			{
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157BB8", Offset = "0x1157BB8")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6001FFD")]
			[Address(RVA = "0x24A6250", Offset = "0x24A6250", VA = "0x7BBCCA6250")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11382E4", Offset = "0x11382E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FFE")]
			[Address(RVA = "0x24A6170", Offset = "0x24A6170", VA = "0x7BBCCA6170")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11382F4", Offset = "0x11382F4")]
			private set
			{
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157BCC", Offset = "0x1157BCC")]
		public uint[] available_maps
		{
			[Token(Token = "0x6001FFF")]
			[Address(RVA = "0x24A6258", Offset = "0x24A6258", VA = "0x7BBCCA6258")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138304", Offset = "0x1138304")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002000")]
			[Address(RVA = "0x24A6260", Offset = "0x24A6260", VA = "0x7BBCCA6260")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138314", Offset = "0x1138314")]
			set
			{
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157C08", Offset = "0x1157C08")]
		public ulong reopen_id
		{
			[Token(Token = "0x6002001")]
			[Address(RVA = "0x24A6268", Offset = "0x24A6268", VA = "0x7BBCCA6268")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138324", Offset = "0x1138324")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002002")]
			[Address(RVA = "0x24A6270", Offset = "0x24A6270", VA = "0x7BBCCA6270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138334", Offset = "0x1138334")]
			set
			{
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157C1C", Offset = "0x1157C1C")]
		public uint room_setting2
		{
			[Token(Token = "0x6002003")]
			[Address(RVA = "0x24A6278", Offset = "0x24A6278", VA = "0x7BBCCA6278")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138344", Offset = "0x1138344")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002004")]
			[Address(RVA = "0x24A6280", Offset = "0x24A6280", VA = "0x7BBCCA6280")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138354", Offset = "0x1138354")]
			set
			{
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157C30", Offset = "0x1157C30")]
		public bool enable_emulator_check
		{
			[Token(Token = "0x6002005")]
			[Address(RVA = "0x24A6288", Offset = "0x24A6288", VA = "0x7BBCCA6288")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138364", Offset = "0x1138364")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002006")]
			[Address(RVA = "0x24A6290", Offset = "0x24A6290", VA = "0x7BBCCA6290")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138374", Offset = "0x1138374")]
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157C44", Offset = "0x1157C44")]
		public uint creater_role
		{
			[Token(Token = "0x6002007")]
			[Address(RVA = "0x24A629C", Offset = "0x24A629C", VA = "0x7BBCCA629C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138384", Offset = "0x1138384")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002008")]
			[Address(RVA = "0x24A62A4", Offset = "0x24A62A4", VA = "0x7BBCCA62A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138394", Offset = "0x1138394")]
			set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0000DC08 File Offset: 0x0000BE08
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157C58", Offset = "0x1157C58")]
		public bool is_cs_advanced
		{
			[Token(Token = "0x6002009")]
			[Address(RVA = "0x24A62AC", Offset = "0x24A62AC", VA = "0x7BBCCA62AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11383A4", Offset = "0x11383A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600200A")]
			[Address(RVA = "0x24A62B4", Offset = "0x24A62B4", VA = "0x7BBCCA62B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11383B4", Offset = "0x11383B4")]
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157C6C", Offset = "0x1157C6C")]
		public byte[] cs_advanced_setting
		{
			[Token(Token = "0x600200B")]
			[Address(RVA = "0x24A62C0", Offset = "0x24A62C0", VA = "0x7BBCCA62C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11383C4", Offset = "0x11383C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600200C")]
			[Address(RVA = "0x24A62C8", Offset = "0x24A62C8", VA = "0x7BBCCA62C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11383D4", Offset = "0x11383D4")]
			set
			{
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600200D RID: 8205 RVA: 0x0000DC20 File Offset: 0x0000BE20
		// (set) Token: 0x0600200E RID: 8206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000500")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157C80", Offset = "0x1157C80")]
		public uint werewolves_room_param
		{
			[Token(Token = "0x600200D")]
			[Address(RVA = "0x24A62D0", Offset = "0x24A62D0", VA = "0x7BBCCA62D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11383E4", Offset = "0x11383E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600200E")]
			[Address(RVA = "0x24A62D8", Offset = "0x24A62D8", VA = "0x7BBCCA62D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11383F4", Offset = "0x11383F4")]
			set
			{
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600200F RID: 8207 RVA: 0x0000DC38 File Offset: 0x0000BE38
		// (set) Token: 0x06002010 RID: 8208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000501")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157C94", Offset = "0x1157C94")]
		public uint werewolves_room_param2
		{
			[Token(Token = "0x600200F")]
			[Address(RVA = "0x24A62E0", Offset = "0x24A62E0", VA = "0x7BBCCA62E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138404", Offset = "0x1138404")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002010")]
			[Address(RVA = "0x24A62E8", Offset = "0x24A62E8", VA = "0x7BBCCA62E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138414", Offset = "0x1138414")]
			set
			{
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0000DC50 File Offset: 0x0000BE50
		// (set) Token: 0x06002012 RID: 8210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000502")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157CA8", Offset = "0x1157CA8")]
		public uint language
		{
			[Token(Token = "0x6002011")]
			[Address(RVA = "0x24A62F0", Offset = "0x24A62F0", VA = "0x7BBCCA62F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138424", Offset = "0x1138424")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002012")]
			[Address(RVA = "0x24A62F8", Offset = "0x24A62F8", VA = "0x7BBCCA62F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138434", Offset = "0x1138434")]
			set
			{
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x0000DC68 File Offset: 0x0000BE68
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000503")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157CBC", Offset = "0x1157CBC")]
		public bool contestant_role_check
		{
			[Token(Token = "0x6002013")]
			[Address(RVA = "0x24A6300", Offset = "0x24A6300", VA = "0x7BBCCA6300")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138444", Offset = "0x1138444")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002014")]
			[Address(RVA = "0x24A6308", Offset = "0x24A6308", VA = "0x7BBCCA6308")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138454", Offset = "0x1138454")]
			set
			{
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x0000DC80 File Offset: 0x0000BE80
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000504")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157CD0", Offset = "0x1157CD0")]
		public bool room_data_inherit
		{
			[Token(Token = "0x6002015")]
			[Address(RVA = "0x24A6314", Offset = "0x24A6314", VA = "0x7BBCCA6314")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138464", Offset = "0x1138464")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002016")]
			[Address(RVA = "0x24A631C", Offset = "0x24A631C", VA = "0x7BBCCA631C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138474", Offset = "0x1138474")]
			set
			{
			}
		}

		// Token: 0x04001804 RID: 6148
		[Token(Token = "0x4001804")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103654", Offset = "0x1103654")]
		private uint <map_id>k__BackingField;

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103664", Offset = "0x1103664")]
		private uint <game_mode>k__BackingField;

		// Token: 0x04001806 RID: 6150
		[Token(Token = "0x4001806")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103674", Offset = "0x1103674")]
		private uint <group_mode>k__BackingField;

		// Token: 0x04001807 RID: 6151
		[Token(Token = "0x4001807")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103684", Offset = "0x1103684")]
		private string <room_name>k__BackingField;

		// Token: 0x04001808 RID: 6152
		[Token(Token = "0x4001808")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103694", Offset = "0x1103694")]
		private string <code>k__BackingField;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11036A4", Offset = "0x11036A4")]
		private uint <max_member_num>k__BackingField;

		// Token: 0x0400180A RID: 6154
		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11036B4", Offset = "0x11036B4")]
		private uint <max_spectator_num>k__BackingField;

		// Token: 0x0400180B RID: 6155
		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11036C4", Offset = "0x11036C4")]
		private bool <enable_death_spectate>k__BackingField;

		// Token: 0x0400180C RID: 6156
		[Token(Token = "0x400180C")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11036D4", Offset = "0x11036D4")]
		private ERoom.Type <room_type>k__BackingField;

		// Token: 0x0400180D RID: 6157
		[Token(Token = "0x400180D")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11036E4", Offset = "0x11036E4")]
		private ulong <group_id>k__BackingField;

		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11036F4", Offset = "0x11036F4")]
		private bool <enable_group_icon>k__BackingField;

		// Token: 0x0400180F RID: 6159
		[Token(Token = "0x400180F")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103704", Offset = "0x1103704")]
		private uint <level_visual_style>k__BackingField;

		// Token: 0x04001810 RID: 6160
		[Token(Token = "0x4001810")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103714", Offset = "0x1103714")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001811 RID: 6161
		[Token(Token = "0x4001811")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103724", Offset = "0x1103724")]
		private uint <room_setting>k__BackingField;

		// Token: 0x04001812 RID: 6162
		[Token(Token = "0x4001812")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103734", Offset = "0x1103734")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;

		// Token: 0x04001813 RID: 6163
		[Token(Token = "0x4001813")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103744", Offset = "0x1103744")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x04001814 RID: 6164
		[Token(Token = "0x4001814")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103754", Offset = "0x1103754")]
		private ulong <reopen_id>k__BackingField;

		// Token: 0x04001815 RID: 6165
		[Token(Token = "0x4001815")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103764", Offset = "0x1103764")]
		private uint <room_setting2>k__BackingField;

		// Token: 0x04001816 RID: 6166
		[Token(Token = "0x4001816")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103774", Offset = "0x1103774")]
		private bool <enable_emulator_check>k__BackingField;

		// Token: 0x04001817 RID: 6167
		[Token(Token = "0x4001817")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103784", Offset = "0x1103784")]
		private uint <creater_role>k__BackingField;

		// Token: 0x04001818 RID: 6168
		[Token(Token = "0x4001818")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103794", Offset = "0x1103794")]
		private bool <is_cs_advanced>k__BackingField;

		// Token: 0x04001819 RID: 6169
		[Token(Token = "0x4001819")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11037A4", Offset = "0x11037A4")]
		private byte[] <cs_advanced_setting>k__BackingField;

		// Token: 0x0400181A RID: 6170
		[Token(Token = "0x400181A")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11037B4", Offset = "0x11037B4")]
		private uint <werewolves_room_param>k__BackingField;

		// Token: 0x0400181B RID: 6171
		[Token(Token = "0x400181B")]
		[FieldOffset(Offset = "0x94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11037C4", Offset = "0x11037C4")]
		private uint <werewolves_room_param2>k__BackingField;

		// Token: 0x0400181C RID: 6172
		[Token(Token = "0x400181C")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11037D4", Offset = "0x11037D4")]
		private uint <language>k__BackingField;

		// Token: 0x0400181D RID: 6173
		[Token(Token = "0x400181D")]
		[FieldOffset(Offset = "0x9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11037E4", Offset = "0x11037E4")]
		private bool <contestant_role_check>k__BackingField;

		// Token: 0x0400181E RID: 6174
		[Token(Token = "0x400181E")]
		[FieldOffset(Offset = "0x9D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11037F4", Offset = "0x11037F4")]
		private bool <room_data_inherit>k__BackingField;
	}
}
