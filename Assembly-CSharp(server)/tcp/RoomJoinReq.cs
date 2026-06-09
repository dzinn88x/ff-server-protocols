using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	[ProtoContract]
	public class RoomJoinReq
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x24A6808", Offset = "0x24A6808", VA = "0x7BBCCA6808")]
		public RoomJoinReq()
		{
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0000DC98 File Offset: 0x0000BE98
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000505")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157CE4", Offset = "0x1157CE4")]
		public ulong room_id
		{
			[Token(Token = "0x6002018")]
			[Address(RVA = "0x24A68F0", Offset = "0x24A68F0", VA = "0x7BBCCA68F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138484", Offset = "0x1138484")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002019")]
			[Address(RVA = "0x24A68F8", Offset = "0x24A68F8", VA = "0x7BBCCA68F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138494", Offset = "0x1138494")]
			set
			{
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000506")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157CF8", Offset = "0x1157CF8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157CF8", Offset = "0x1157CF8")]
		public string code
		{
			[Token(Token = "0x600201A")]
			[Address(RVA = "0x24A6900", Offset = "0x24A6900", VA = "0x7BBCCA6900")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11384A4", Offset = "0x11384A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600201B")]
			[Address(RVA = "0x24A68C8", Offset = "0x24A68C8", VA = "0x7BBCCA68C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11384B4", Offset = "0x11384B4")]
			set
			{
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000507")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157D48", Offset = "0x1157D48")]
		public ulong group_id
		{
			[Token(Token = "0x600201C")]
			[Address(RVA = "0x24A6908", Offset = "0x24A6908", VA = "0x7BBCCA6908")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11384C4", Offset = "0x11384C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600201D")]
			[Address(RVA = "0x24A6910", Offset = "0x24A6910", VA = "0x7BBCCA6910")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11384D4", Offset = "0x11384D4")]
			set
			{
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000508")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157D5C", Offset = "0x1157D5C")]
		public bool is_solo
		{
			[Token(Token = "0x600201E")]
			[Address(RVA = "0x24A6918", Offset = "0x24A6918", VA = "0x7BBCCA6918")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11384E4", Offset = "0x11384E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600201F")]
			[Address(RVA = "0x24A6920", Offset = "0x24A6920", VA = "0x7BBCCA6920")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11384F4", Offset = "0x11384F4")]
			set
			{
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000509")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157D70", Offset = "0x1157D70")]
		public List<JoinRoomPlayerInfo> players
		{
			[Token(Token = "0x6002020")]
			[Address(RVA = "0x24A692C", Offset = "0x24A692C", VA = "0x7BBCCA692C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138504", Offset = "0x1138504")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002021")]
			[Address(RVA = "0x24A68D0", Offset = "0x24A68D0", VA = "0x7BBCCA68D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138514", Offset = "0x1138514")]
			private set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157D84", Offset = "0x1157D84")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157D84", Offset = "0x1157D84")]
		public string group_name
		{
			[Token(Token = "0x6002022")]
			[Address(RVA = "0x24A6934", Offset = "0x24A6934", VA = "0x7BBCCA6934")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138524", Offset = "0x1138524")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002023")]
			[Address(RVA = "0x24A68D8", Offset = "0x24A68D8", VA = "0x7BBCCA68D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138534", Offset = "0x1138534")]
			set
			{
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157DD4", Offset = "0x1157DD4")]
		public ulong inviter_account_id
		{
			[Token(Token = "0x6002024")]
			[Address(RVA = "0x24A693C", Offset = "0x24A693C", VA = "0x7BBCCA693C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138544", Offset = "0x1138544")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002025")]
			[Address(RVA = "0x24A6944", Offset = "0x24A6944", VA = "0x7BBCCA6944")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138554", Offset = "0x1138554")]
			set
			{
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157DE8", Offset = "0x1157DE8")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6002026")]
			[Address(RVA = "0x24A694C", Offset = "0x24A694C", VA = "0x7BBCCA694C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138564", Offset = "0x1138564")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002027")]
			[Address(RVA = "0x24A68E0", Offset = "0x24A68E0", VA = "0x7BBCCA68E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138574", Offset = "0x1138574")]
			private set
			{
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002029 RID: 8233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157DFC", Offset = "0x1157DFC")]
		public uint[] available_maps
		{
			[Token(Token = "0x6002028")]
			[Address(RVA = "0x24A6954", Offset = "0x24A6954", VA = "0x7BBCCA6954")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138584", Offset = "0x1138584")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002029")]
			[Address(RVA = "0x24A695C", Offset = "0x24A695C", VA = "0x7BBCCA695C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138594", Offset = "0x1138594")]
			set
			{
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157E38", Offset = "0x1157E38")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x600202A")]
			[Address(RVA = "0x24A6964", Offset = "0x24A6964", VA = "0x7BBCCA6964")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11385A4", Offset = "0x11385A4")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x600202B")]
			[Address(RVA = "0x24A696C", Offset = "0x24A696C", VA = "0x7BBCCA696C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11385B4", Offset = "0x11385B4")]
			set
			{
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050F")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157E4C", Offset = "0x1157E4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157E4C", Offset = "0x1157E4C")]
		public string group_abbr_name
		{
			[Token(Token = "0x600202C")]
			[Address(RVA = "0x24A6974", Offset = "0x24A6974", VA = "0x7BBCCA6974")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11385C4", Offset = "0x11385C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600202D")]
			[Address(RVA = "0x24A68E8", Offset = "0x24A68E8", VA = "0x7BBCCA68E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11385D4", Offset = "0x11385D4")]
			set
			{
			}
		}

		// Token: 0x0400181F RID: 6175
		[Token(Token = "0x400181F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103804", Offset = "0x1103804")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001820 RID: 6176
		[Token(Token = "0x4001820")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103814", Offset = "0x1103814")]
		private string <code>k__BackingField;

		// Token: 0x04001821 RID: 6177
		[Token(Token = "0x4001821")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103824", Offset = "0x1103824")]
		private ulong <group_id>k__BackingField;

		// Token: 0x04001822 RID: 6178
		[Token(Token = "0x4001822")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103834", Offset = "0x1103834")]
		private bool <is_solo>k__BackingField;

		// Token: 0x04001823 RID: 6179
		[Token(Token = "0x4001823")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103844", Offset = "0x1103844")]
		private List<JoinRoomPlayerInfo> <players>k__BackingField;

		// Token: 0x04001824 RID: 6180
		[Token(Token = "0x4001824")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103854", Offset = "0x1103854")]
		private string <group_name>k__BackingField;

		// Token: 0x04001825 RID: 6181
		[Token(Token = "0x4001825")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103864", Offset = "0x1103864")]
		private ulong <inviter_account_id>k__BackingField;

		// Token: 0x04001826 RID: 6182
		[Token(Token = "0x4001826")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103874", Offset = "0x1103874")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;

		// Token: 0x04001827 RID: 6183
		[Token(Token = "0x4001827")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103884", Offset = "0x1103884")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103894", Offset = "0x1103894")]
		private ERoom.Type <room_type>k__BackingField;

		// Token: 0x04001829 RID: 6185
		[Token(Token = "0x4001829")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11038A4", Offset = "0x11038A4")]
		private string <group_abbr_name>k__BackingField;
	}
}
