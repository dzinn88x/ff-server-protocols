using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	[ProtoContract]
	public class RoomChangeAvailableMapsNtf
	{
		// Token: 0x06002167 RID: 8551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002167")]
		[Address(RVA = "0x24A5EC8", Offset = "0x24A5EC8", VA = "0x7BBCCA5EC8")]
		public RoomChangeAvailableMapsNtf()
		{
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158CD4", Offset = "0x1158CD4")]
		public ulong account_id
		{
			[Token(Token = "0x6002168")]
			[Address(RVA = "0x24A5ED0", Offset = "0x24A5ED0", VA = "0x7BBCCA5ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11397E4", Offset = "0x11397E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002169")]
			[Address(RVA = "0x24A5ED8", Offset = "0x24A5ED8", VA = "0x7BBCCA5ED8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11397F4", Offset = "0x11397F4")]
			set
			{
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158CE8", Offset = "0x1158CE8")]
		public uint[] available_maps
		{
			[Token(Token = "0x600216A")]
			[Address(RVA = "0x24A5EE0", Offset = "0x24A5EE0", VA = "0x7BBCCA5EE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139804", Offset = "0x1139804")]
			get
			{
				return null;
			}
			[Token(Token = "0x600216B")]
			[Address(RVA = "0x24A5EE8", Offset = "0x24A5EE8", VA = "0x7BBCCA5EE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139814", Offset = "0x1139814")]
			set
			{
			}
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158D24", Offset = "0x1158D24")]
		public ulong room_id
		{
			[Token(Token = "0x600216C")]
			[Address(RVA = "0x24A5EF0", Offset = "0x24A5EF0", VA = "0x7BBCCA5EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139824", Offset = "0x1139824")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600216D")]
			[Address(RVA = "0x24A5EF8", Offset = "0x24A5EF8", VA = "0x7BBCCA5EF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139834", Offset = "0x1139834")]
			set
			{
			}
		}

		// Token: 0x040018BA RID: 6330
		[Token(Token = "0x40018BA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11041B4", Offset = "0x11041B4")]
		private ulong <account_id>k__BackingField;

		// Token: 0x040018BB RID: 6331
		[Token(Token = "0x40018BB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11041C4", Offset = "0x11041C4")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x040018BC RID: 6332
		[Token(Token = "0x40018BC")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11041D4", Offset = "0x11041D4")]
		private ulong <room_id>k__BackingField;
	}
}
