using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	[ProtoContract]
	public class ActivityUpdateInfo
	{
		// Token: 0x06001C08 RID: 7176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x24A22C8", Offset = "0x24A22C8", VA = "0x7BBCCA22C8")]
		public ActivityUpdateInfo()
		{
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x0000BE68 File Offset: 0x0000A068
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700033F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154580", Offset = "0x1154580")]
		public uint id
		{
			[Token(Token = "0x6001C09")]
			[Address(RVA = "0x24A232C", Offset = "0x24A232C", VA = "0x7BBCCA232C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134BC4", Offset = "0x1134BC4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x24A2334", Offset = "0x24A2334", VA = "0x7BBCCA2334")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134BD4", Offset = "0x1134BD4")]
			set
			{
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x0000BE80 File Offset: 0x0000A080
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000340")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154594", Offset = "0x1154594")]
		public uint data
		{
			[Token(Token = "0x6001C0B")]
			[Address(RVA = "0x24A233C", Offset = "0x24A233C", VA = "0x7BBCCA233C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134BE4", Offset = "0x1134BE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0x24A2344", Offset = "0x24A2344", VA = "0x7BBCCA2344")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134BF4", Offset = "0x1134BF4")]
			set
			{
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x0000BE98 File Offset: 0x0000A098
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000341")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11545A8", Offset = "0x11545A8")]
		public uint state
		{
			[Token(Token = "0x6001C0D")]
			[Address(RVA = "0x24A234C", Offset = "0x24A234C", VA = "0x7BBCCA234C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134C04", Offset = "0x1134C04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0x24A2354", Offset = "0x24A2354", VA = "0x7BBCCA2354")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134C14", Offset = "0x1134C14")]
			set
			{
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000342")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11545BC", Offset = "0x11545BC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11545BC", Offset = "0x11545BC")]
		public string context
		{
			[Token(Token = "0x6001C0F")]
			[Address(RVA = "0x24A235C", Offset = "0x24A235C", VA = "0x7BBCCA235C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134C24", Offset = "0x1134C24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C10")]
			[Address(RVA = "0x24A2324", Offset = "0x24A2324", VA = "0x7BBCCA2324")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134C34", Offset = "0x1134C34")]
			set
			{
			}
		}

		// Token: 0x04001463 RID: 5219
		[Token(Token = "0x4001463")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101BA4", Offset = "0x1101BA4")]
		private uint <id>k__BackingField;

		// Token: 0x04001464 RID: 5220
		[Token(Token = "0x4001464")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101BB4", Offset = "0x1101BB4")]
		private uint <data>k__BackingField;

		// Token: 0x04001465 RID: 5221
		[Token(Token = "0x4001465")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101BC4", Offset = "0x1101BC4")]
		private uint <state>k__BackingField;

		// Token: 0x04001466 RID: 5222
		[Token(Token = "0x4001466")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101BD4", Offset = "0x1101BD4")]
		private string <context>k__BackingField;
	}
}
