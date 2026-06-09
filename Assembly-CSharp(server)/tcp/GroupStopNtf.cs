using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	[ProtoContract]
	public class GroupStopNtf
	{
		// Token: 0x06001DD2 RID: 7634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD2")]
		[Address(RVA = "0x24A410C", Offset = "0x24A410C", VA = "0x7BBCCA410C")]
		public GroupStopNtf()
		{
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000405")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155E30", Offset = "0x1155E30")]
		public GroupMemberInfo stoper_info
		{
			[Token(Token = "0x6001DD3")]
			[Address(RVA = "0x24A4114", Offset = "0x24A4114", VA = "0x7BBCCA4114")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136484", Offset = "0x1136484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DD4")]
			[Address(RVA = "0x24A411C", Offset = "0x24A411C", VA = "0x7BBCCA411C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136494", Offset = "0x1136494")]
			set
			{
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000406")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155E44", Offset = "0x1155E44")]
		public GroupInfo group_info
		{
			[Token(Token = "0x6001DD5")]
			[Address(RVA = "0x24A4124", Offset = "0x24A4124", VA = "0x7BBCCA4124")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11364A4", Offset = "0x11364A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DD6")]
			[Address(RVA = "0x24A412C", Offset = "0x24A412C", VA = "0x7BBCCA412C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11364B4", Offset = "0x11364B4")]
			set
			{
			}
		}

		// Token: 0x0400162A RID: 5674
		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102804", Offset = "0x1102804")]
		private GroupMemberInfo <stoper_info>k__BackingField;

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102814", Offset = "0x1102814")]
		private GroupInfo <group_info>k__BackingField;
	}
}
