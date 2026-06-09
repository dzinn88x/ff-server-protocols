using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000512 RID: 1298
	[Token(Token = "0x2000512")]
	[ProtoContract]
	public class RoomKickNtf
	{
		// Token: 0x06002068 RID: 8296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002068")]
		[Address(RVA = "0x24A697C", Offset = "0x24A697C", VA = "0x7BBCCA697C")]
		public RoomKickNtf()
		{
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600206A RID: 8298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000529")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158158", Offset = "0x1158158")]
		public RoomPlayerInfo kick_player_info
		{
			[Token(Token = "0x6002069")]
			[Address(RVA = "0x24A6984", Offset = "0x24A6984", VA = "0x7BBCCA6984")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138904", Offset = "0x1138904")]
			get
			{
				return null;
			}
			[Token(Token = "0x600206A")]
			[Address(RVA = "0x24A698C", Offset = "0x24A698C", VA = "0x7BBCCA698C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138914", Offset = "0x1138914")]
			set
			{
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600206C RID: 8300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700052A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115816C", Offset = "0x115816C")]
		public RoomInfo room_info
		{
			[Token(Token = "0x600206B")]
			[Address(RVA = "0x24A6994", Offset = "0x24A6994", VA = "0x7BBCCA6994")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138924", Offset = "0x1138924")]
			get
			{
				return null;
			}
			[Token(Token = "0x600206C")]
			[Address(RVA = "0x24A699C", Offset = "0x24A699C", VA = "0x7BBCCA699C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138934", Offset = "0x1138934")]
			set
			{
			}
		}

		// Token: 0x04001843 RID: 6211
		[Token(Token = "0x4001843")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A44", Offset = "0x1103A44")]
		private RoomPlayerInfo <kick_player_info>k__BackingField;

		// Token: 0x04001844 RID: 6212
		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A54", Offset = "0x1103A54")]
		private RoomInfo <room_info>k__BackingField;
	}
}
