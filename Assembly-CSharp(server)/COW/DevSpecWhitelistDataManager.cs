using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020012ED RID: 4845
	[Token(Token = "0x20012ED")]
	public class DevSpecWhitelistDataManager : SingletonModule<DevSpecWhitelistDataManager>
	{
		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06004CA9 RID: 19625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000855")]
		public DevSpecWhitelistData MatchingDevSpecWhitelistData
		{
			[Token(Token = "0x6004CA9")]
			[Address(RVA = "0x1605518", Offset = "0x1605518", VA = "0x7BBBE05518")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x1605520", Offset = "0x1605520", VA = "0x7BBBE05520", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0x16058B4", Offset = "0x16058B4", VA = "0x7BBBE058B4", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004CAC RID: 19628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAC")]
		[Address(RVA = "0x16058BC", Offset = "0x16058BC", VA = "0x7BBBE058BC")]
		public DevSpecWhitelistDataManager()
		{
		}

		// Token: 0x04007445 RID: 29765
		[Token(Token = "0x4007445")]
		[FieldOffset(Offset = "0x18")]
		private DevSpecWhitelistData m_matchingDevSpecWhitelistData;

		// Token: 0x020012EE RID: 4846
		[Token(Token = "0x20012EE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB148", Offset = "0x10EB148")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004CAE RID: 19630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CAE")]
			[Address(RVA = "0x1605990", Offset = "0x1605990", VA = "0x7BBBE05990")]
			public <>c()
			{
			}

			// Token: 0x06004CAF RID: 19631 RVA: 0x00016F68 File Offset: 0x00015168
			[Token(Token = "0x6004CAF")]
			[Address(RVA = "0x1605998", Offset = "0x1605998", VA = "0x7BBBE05998")]
			internal int <OnInit>b__3_0(DevSpecWhitelistData a, DevSpecWhitelistData b)
			{
				return 0;
			}

			// Token: 0x04007446 RID: 29766
			[Token(Token = "0x4007446")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DevSpecWhitelistDataManager.<>c <>9;

			// Token: 0x04007447 RID: 29767
			[Token(Token = "0x4007447")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<DevSpecWhitelistData> <>9__3_0;
		}
	}
}
