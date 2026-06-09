using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200050E RID: 1294
	[Token(Token = "0x200050E")]
	[ProtoContract]
	public class RoomJoinNtf
	{
		// Token: 0x06002052 RID: 8274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x24A6774", Offset = "0x24A6774", VA = "0x7BBCCA6774")]
		public RoomJoinNtf()
		{
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002054 RID: 8276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000520")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11580A4", Offset = "0x11580A4")]
		public List<RoomPlayerInfo> join_player_list
		{
			[Token(Token = "0x6002053")]
			[Address(RVA = "0x24A67F0", Offset = "0x24A67F0", VA = "0x7BBCCA67F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11387E4", Offset = "0x11387E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002054")]
			[Address(RVA = "0x24A67E8", Offset = "0x24A67E8", VA = "0x7BBCCA67E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11387F4", Offset = "0x11387F4")]
			private set
			{
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002056 RID: 8278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000521")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11580B8", Offset = "0x11580B8")]
		public RoomInfo room_info
		{
			[Token(Token = "0x6002055")]
			[Address(RVA = "0x24A67F8", Offset = "0x24A67F8", VA = "0x7BBCCA67F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138804", Offset = "0x1138804")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002056")]
			[Address(RVA = "0x24A6800", Offset = "0x24A6800", VA = "0x7BBCCA6800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138814", Offset = "0x1138814")]
			set
			{
			}
		}

		// Token: 0x0400183A RID: 6202
		[Token(Token = "0x400183A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11039B4", Offset = "0x11039B4")]
		private List<RoomPlayerInfo> <join_player_list>k__BackingField;

		// Token: 0x0400183B RID: 6203
		[Token(Token = "0x400183B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11039C4", Offset = "0x11039C4")]
		private RoomInfo <room_info>k__BackingField;
	}
}
