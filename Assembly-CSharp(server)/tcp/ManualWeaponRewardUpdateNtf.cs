using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	[ProtoContract]
	public class ManualWeaponRewardUpdateNtf
	{
		// Token: 0x06001EEB RID: 7915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0x24A4890", Offset = "0x24A4890", VA = "0x7BBCCA4890")]
		public ManualWeaponRewardUpdateNtf()
		{
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EED RID: 7917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700047F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156D6C", Offset = "0x1156D6C")]
		public List<ManualWeaponRewardUpdateInfo> weapons
		{
			[Token(Token = "0x6001EEC")]
			[Address(RVA = "0x24A490C", Offset = "0x24A490C", VA = "0x7BBCCA490C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11373C4", Offset = "0x11373C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EED")]
			[Address(RVA = "0x24A4904", Offset = "0x24A4904", VA = "0x7BBCCA4904")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11373D4", Offset = "0x11373D4")]
			private set
			{
			}
		}

		// Token: 0x040016CE RID: 5838
		[Token(Token = "0x40016CE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102FA4", Offset = "0x1102FA4")]
		private List<ManualWeaponRewardUpdateInfo> <weapons>k__BackingField;
	}
}
