using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F12 RID: 7954
	[Token(Token = "0x2001F12")]
	public class UIModelLiveTv : UIBaseModel
	{
		// Token: 0x0600AEC1 RID: 44737 RVA: 0x00030870 File Offset: 0x0002EA70
		[Token(Token = "0x600AEC1")]
		[Address(RVA = "0x1641190", Offset = "0x1641190", VA = "0x7BBBE41190", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600AEC2 RID: 44738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC2")]
		[Address(RVA = "0x1641198", Offset = "0x1641198", VA = "0x7BBBE41198")]
		public void ProcessTabDesc(CSGetLiveDescRes live_desc)
		{
		}

		// Token: 0x0600AEC3 RID: 44739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEC3")]
		[Address(RVA = "0x164130C", Offset = "0x164130C", VA = "0x7BBBE4130C")]
		public string GetLiveBubbleText()
		{
			return null;
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEC4")]
		[Address(RVA = "0x1641580", Offset = "0x1641580", VA = "0x7BBBE41580")]
		public string LiveTVURL()
		{
			return null;
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEC5")]
		[Address(RVA = "0x164171C", Offset = "0x164171C", VA = "0x7BBBE4171C")]
		public string BooyahTVURL()
		{
			return null;
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEC6")]
		[Address(RVA = "0x16418B8", Offset = "0x16418B8", VA = "0x7BBBE418B8")]
		public string LiveTabName()
		{
			return null;
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AEC7")]
		[Address(RVA = "0x16419F4", Offset = "0x16419F4", VA = "0x7BBBE419F4")]
		public string BooyahTabName()
		{
			return null;
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEC8")]
		[Address(RVA = "0x1641B30", Offset = "0x1641B30", VA = "0x7BBBE41B30")]
		public UIModelLiveTv()
		{
		}

		// Token: 0x0400B2D1 RID: 45777
		[Token(Token = "0x400B2D1")]
		[FieldOffset(Offset = "0x18")]
		private List<LiveDesc> m_TabDesc;

		// Token: 0x02001F13 RID: 7955
		[Token(Token = "0x2001F13")]
		private enum LiveType
		{
			// Token: 0x0400B2D3 RID: 45779
			[Token(Token = "0x400B2D3")]
			LiveTV = 1,
			// Token: 0x0400B2D4 RID: 45780
			[Token(Token = "0x400B2D4")]
			BooyahTV
		}

		// Token: 0x02001F14 RID: 7956
		[Token(Token = "0x2001F14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE34", Offset = "0x10FCE34")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AECA RID: 44746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AECA")]
			[Address(RVA = "0x1641C24", Offset = "0x1641C24", VA = "0x7BBBE41C24")]
			public <>c()
			{
			}

			// Token: 0x0600AECB RID: 44747 RVA: 0x00030888 File Offset: 0x0002EA88
			[Token(Token = "0x600AECB")]
			[Address(RVA = "0x1641C2C", Offset = "0x1641C2C", VA = "0x7BBBE41C2C")]
			internal bool <GetLiveBubbleText>b__4_0(LiveDesc x)
			{
				return default(bool);
			}

			// Token: 0x0600AECC RID: 44748 RVA: 0x000308A0 File Offset: 0x0002EAA0
			[Token(Token = "0x600AECC")]
			[Address(RVA = "0x1641C60", Offset = "0x1641C60", VA = "0x7BBBE41C60")]
			internal bool <LiveTVURL>b__5_0(LiveDesc x)
			{
				return default(bool);
			}

			// Token: 0x0600AECD RID: 44749 RVA: 0x000308B8 File Offset: 0x0002EAB8
			[Token(Token = "0x600AECD")]
			[Address(RVA = "0x1641C94", Offset = "0x1641C94", VA = "0x7BBBE41C94")]
			internal bool <BooyahTVURL>b__6_0(LiveDesc x)
			{
				return default(bool);
			}

			// Token: 0x0600AECE RID: 44750 RVA: 0x000308D0 File Offset: 0x0002EAD0
			[Token(Token = "0x600AECE")]
			[Address(RVA = "0x1641CC8", Offset = "0x1641CC8", VA = "0x7BBBE41CC8")]
			internal bool <LiveTabName>b__7_0(LiveDesc x)
			{
				return default(bool);
			}

			// Token: 0x0600AECF RID: 44751 RVA: 0x000308E8 File Offset: 0x0002EAE8
			[Token(Token = "0x600AECF")]
			[Address(RVA = "0x1641CFC", Offset = "0x1641CFC", VA = "0x7BBBE41CFC")]
			internal bool <BooyahTabName>b__8_0(LiveDesc x)
			{
				return default(bool);
			}

			// Token: 0x0400B2D5 RID: 45781
			[Token(Token = "0x400B2D5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelLiveTv.<>c <>9;

			// Token: 0x0400B2D6 RID: 45782
			[Token(Token = "0x400B2D6")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<LiveDesc> <>9__4_0;

			// Token: 0x0400B2D7 RID: 45783
			[Token(Token = "0x400B2D7")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<LiveDesc> <>9__5_0;

			// Token: 0x0400B2D8 RID: 45784
			[Token(Token = "0x400B2D8")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<LiveDesc> <>9__6_0;

			// Token: 0x0400B2D9 RID: 45785
			[Token(Token = "0x400B2D9")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<LiveDesc> <>9__7_0;

			// Token: 0x0400B2DA RID: 45786
			[Token(Token = "0x400B2DA")]
			[FieldOffset(Offset = "0x28")]
			public static Predicate<LiveDesc> <>9__8_0;
		}
	}
}
