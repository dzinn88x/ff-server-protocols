using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200050A RID: 1290
	[Token(Token = "0x200050A")]
	[ProtoContract]
	public class RoomSpectateReq
	{
		// Token: 0x0600202E RID: 8238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x24A6DC0", Offset = "0x24A6DC0", VA = "0x7BBCCA6DC0")]
		public RoomSpectateReq()
		{
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0000DD10 File Offset: 0x0000BF10
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000510")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157E9C", Offset = "0x1157E9C")]
		public ulong room_id
		{
			[Token(Token = "0x600202F")]
			[Address(RVA = "0x24A6E84", Offset = "0x24A6E84", VA = "0x7BBCCA6E84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11385E4", Offset = "0x11385E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002030")]
			[Address(RVA = "0x24A6E8C", Offset = "0x24A6E8C", VA = "0x7BBCCA6E8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11385F4", Offset = "0x11385F4")]
			set
			{
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000511")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157EB0", Offset = "0x1157EB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157EB0", Offset = "0x1157EB0")]
		public string code
		{
			[Token(Token = "0x6002031")]
			[Address(RVA = "0x24A6E94", Offset = "0x24A6E94", VA = "0x7BBCCA6E94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138604", Offset = "0x1138604")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002032")]
			[Address(RVA = "0x24A6E6C", Offset = "0x24A6E6C", VA = "0x7BBCCA6E6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138614", Offset = "0x1138614")]
			set
			{
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x0000DD28 File Offset: 0x0000BF28
		// (set) Token: 0x06002034 RID: 8244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000512")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157F00", Offset = "0x1157F00")]
		public ulong group_id
		{
			[Token(Token = "0x6002033")]
			[Address(RVA = "0x24A6E9C", Offset = "0x24A6E9C", VA = "0x7BBCCA6E9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138624", Offset = "0x1138624")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002034")]
			[Address(RVA = "0x24A6EA4", Offset = "0x24A6EA4", VA = "0x7BBCCA6EA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138634", Offset = "0x1138634")]
			set
			{
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0000DD40 File Offset: 0x0000BF40
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000513")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157F14", Offset = "0x1157F14")]
		public bool is_solo
		{
			[Token(Token = "0x6002035")]
			[Address(RVA = "0x24A6EAC", Offset = "0x24A6EAC", VA = "0x7BBCCA6EAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138644", Offset = "0x1138644")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x24A6EB4", Offset = "0x24A6EB4", VA = "0x7BBCCA6EB4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138654", Offset = "0x1138654")]
			set
			{
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000514")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157F28", Offset = "0x1157F28")]
		public List<JoinRoomPlayerInfo> players
		{
			[Token(Token = "0x6002037")]
			[Address(RVA = "0x24A6EC0", Offset = "0x24A6EC0", VA = "0x7BBCCA6EC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138664", Offset = "0x1138664")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002038")]
			[Address(RVA = "0x24A6E74", Offset = "0x24A6E74", VA = "0x7BBCCA6E74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138674", Offset = "0x1138674")]
			private set
			{
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000515")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157F3C", Offset = "0x1157F3C")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6002039")]
			[Address(RVA = "0x24A6EC8", Offset = "0x24A6EC8", VA = "0x7BBCCA6EC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138684", Offset = "0x1138684")]
			get
			{
				return null;
			}
			[Token(Token = "0x600203A")]
			[Address(RVA = "0x24A6E7C", Offset = "0x24A6E7C", VA = "0x7BBCCA6E7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138694", Offset = "0x1138694")]
			private set
			{
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000516")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157F50", Offset = "0x1157F50")]
		public uint[] available_maps
		{
			[Token(Token = "0x600203B")]
			[Address(RVA = "0x24A6ED0", Offset = "0x24A6ED0", VA = "0x7BBCCA6ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11386A4", Offset = "0x11386A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600203C")]
			[Address(RVA = "0x24A6ED8", Offset = "0x24A6ED8", VA = "0x7BBCCA6ED8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11386B4", Offset = "0x11386B4")]
			set
			{
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x0000DD58 File Offset: 0x0000BF58
		// (set) Token: 0x0600203E RID: 8254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000517")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157F8C", Offset = "0x1157F8C")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x600203D")]
			[Address(RVA = "0x24A6EE0", Offset = "0x24A6EE0", VA = "0x7BBCCA6EE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11386C4", Offset = "0x11386C4")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x600203E")]
			[Address(RVA = "0x24A6EE8", Offset = "0x24A6EE8", VA = "0x7BBCCA6EE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11386D4", Offset = "0x11386D4")]
			set
			{
			}
		}

		// Token: 0x0400182A RID: 6186
		[Token(Token = "0x400182A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11038B4", Offset = "0x11038B4")]
		private ulong <room_id>k__BackingField;

		// Token: 0x0400182B RID: 6187
		[Token(Token = "0x400182B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11038C4", Offset = "0x11038C4")]
		private string <code>k__BackingField;

		// Token: 0x0400182C RID: 6188
		[Token(Token = "0x400182C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11038D4", Offset = "0x11038D4")]
		private ulong <group_id>k__BackingField;

		// Token: 0x0400182D RID: 6189
		[Token(Token = "0x400182D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11038E4", Offset = "0x11038E4")]
		private bool <is_solo>k__BackingField;

		// Token: 0x0400182E RID: 6190
		[Token(Token = "0x400182E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11038F4", Offset = "0x11038F4")]
		private List<JoinRoomPlayerInfo> <players>k__BackingField;

		// Token: 0x0400182F RID: 6191
		[Token(Token = "0x400182F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103904", Offset = "0x1103904")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;

		// Token: 0x04001830 RID: 6192
		[Token(Token = "0x4001830")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103914", Offset = "0x1103914")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x04001831 RID: 6193
		[Token(Token = "0x4001831")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103924", Offset = "0x1103924")]
		private ERoom.Type <room_type>k__BackingField;
	}
}
