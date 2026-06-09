using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	[ProtoContract]
	public class MatchmakingStartNtf
	{
		// Token: 0x06001F67 RID: 8039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x24A532C", Offset = "0x24A532C", VA = "0x7BBCCA532C")]
		public MatchmakingStartNtf()
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157488", Offset = "0x1157488")]
		public uint[] map_ids
		{
			[Token(Token = "0x6001F68")]
			[Address(RVA = "0x24A5334", Offset = "0x24A5334", VA = "0x7BBCCA5334")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137AC4", Offset = "0x1137AC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F69")]
			[Address(RVA = "0x24A533C", Offset = "0x24A533C", VA = "0x7BBCCA533C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137AD4", Offset = "0x1137AD4")]
			set
			{
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x0000D710 File Offset: 0x0000B910
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11574C4", Offset = "0x11574C4")]
		public uint game_mode
		{
			[Token(Token = "0x6001F6A")]
			[Address(RVA = "0x24A5344", Offset = "0x24A5344", VA = "0x7BBCCA5344")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137AE4", Offset = "0x1137AE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F6B")]
			[Address(RVA = "0x24A534C", Offset = "0x24A534C", VA = "0x7BBCCA534C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137AF4", Offset = "0x1137AF4")]
			set
			{
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0000D728 File Offset: 0x0000B928
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11574D8", Offset = "0x11574D8")]
		public uint difficulty
		{
			[Token(Token = "0x6001F6C")]
			[Address(RVA = "0x24A5354", Offset = "0x24A5354", VA = "0x7BBCCA5354")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B04", Offset = "0x1137B04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F6D")]
			[Address(RVA = "0x24A535C", Offset = "0x24A535C", VA = "0x7BBCCA535C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B14", Offset = "0x1137B14")]
			set
			{
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x0000D740 File Offset: 0x0000B940
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11574EC", Offset = "0x11574EC")]
		public uint match_mode
		{
			[Token(Token = "0x6001F6E")]
			[Address(RVA = "0x24A5364", Offset = "0x24A5364", VA = "0x7BBCCA5364")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B24", Offset = "0x1137B24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F6F")]
			[Address(RVA = "0x24A536C", Offset = "0x24A536C", VA = "0x7BBCCA536C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B34", Offset = "0x1137B34")]
			set
			{
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x0000D758 File Offset: 0x0000B958
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157500", Offset = "0x1157500")]
		public uint avg_wait_time_sec
		{
			[Token(Token = "0x6001F70")]
			[Address(RVA = "0x24A5374", Offset = "0x24A5374", VA = "0x7BBCCA5374")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B44", Offset = "0x1137B44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F71")]
			[Address(RVA = "0x24A537C", Offset = "0x24A537C", VA = "0x7BBCCA537C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137B54", Offset = "0x1137B54")]
			set
			{
			}
		}

		// Token: 0x04001736 RID: 5942
		[Token(Token = "0x4001736")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103324", Offset = "0x1103324")]
		private uint[] <map_ids>k__BackingField;

		// Token: 0x04001737 RID: 5943
		[Token(Token = "0x4001737")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103334", Offset = "0x1103334")]
		private uint <game_mode>k__BackingField;

		// Token: 0x04001738 RID: 5944
		[Token(Token = "0x4001738")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103344", Offset = "0x1103344")]
		private uint <difficulty>k__BackingField;

		// Token: 0x04001739 RID: 5945
		[Token(Token = "0x4001739")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103354", Offset = "0x1103354")]
		private uint <match_mode>k__BackingField;

		// Token: 0x0400173A RID: 5946
		[Token(Token = "0x400173A")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103364", Offset = "0x1103364")]
		private uint <avg_wait_time_sec>k__BackingField;
	}
}
