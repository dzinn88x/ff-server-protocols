using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000507 RID: 1287
	[Token(Token = "0x2000507")]
	[ProtoContract]
	public class RoomListRes
	{
		// Token: 0x06001FDD RID: 8157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FDD")]
		[Address(RVA = "0x24A6AC0", Offset = "0x24A6AC0", VA = "0x7BBCCA6AC0")]
		public RoomListRes()
		{
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDF RID: 8159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157A14", Offset = "0x1157A14")]
		public List<RoomBasicInfo> room_list
		{
			[Token(Token = "0x6001FDE")]
			[Address(RVA = "0x24A6B3C", Offset = "0x24A6B3C", VA = "0x7BBCCA6B3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138104", Offset = "0x1138104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDF")]
			[Address(RVA = "0x24A6B34", Offset = "0x24A6B34", VA = "0x7BBCCA6B34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138114", Offset = "0x1138114")]
			private set
			{
			}
		}

		// Token: 0x04001803 RID: 6147
		[Token(Token = "0x4001803")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103644", Offset = "0x1103644")]
		private List<RoomBasicInfo> <room_list>k__BackingField;
	}
}
