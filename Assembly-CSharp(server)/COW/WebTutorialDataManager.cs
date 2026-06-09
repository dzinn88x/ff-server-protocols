using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200203D RID: 8253
	[Token(Token = "0x200203D")]
	public class WebTutorialDataManager : SingletonModule<WebTutorialDataManager>
	{
		// Token: 0x0600B7E5 RID: 47077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E5")]
		[Address(RVA = "0x17A0F98", Offset = "0x17A0F98", VA = "0x7BBBFA0F98", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600B7E6 RID: 47078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E6")]
		[Address(RVA = "0x17A1000", Offset = "0x17A1000", VA = "0x7BBBFA1000", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600B7E7 RID: 47079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E7")]
		[Address(RVA = "0x17A1004", Offset = "0x17A1004", VA = "0x7BBBFA1004")]
		public void LoadData()
		{
		}

		// Token: 0x0600B7E8 RID: 47080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E8")]
		[Address(RVA = "0x17A1294", Offset = "0x17A1294", VA = "0x7BBBFA1294", Slot = "9")]
		protected override void OnReloadMemory()
		{
		}

		// Token: 0x0600B7E9 RID: 47081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7E9")]
		[Address(RVA = "0x17A12EC", Offset = "0x17A12EC", VA = "0x7BBBFA12EC", Slot = "8")]
		protected override void OnUnloadMemeory()
		{
		}

		// Token: 0x0600B7EA RID: 47082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7EA")]
		[Address(RVA = "0x17A1360", Offset = "0x17A1360", VA = "0x7BBBFA1360")]
		public string GetWebUrlByType(WebTutorialType type)
		{
			return null;
		}

		// Token: 0x0600B7EB RID: 47083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7EB")]
		[Address(RVA = "0x17A1744", Offset = "0x17A1744", VA = "0x7BBBFA1744")]
		public string GetGameModeTutorial(int gameMode, int matchMode)
		{
			return null;
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x00034968 File Offset: 0x00032B68
		[Token(Token = "0x600B7EC")]
		[Address(RVA = "0x17A19B4", Offset = "0x17A19B4", VA = "0x7BBBFA19B4")]
		public bool IsVersionGameModeTutorial(int gameMode, int matchMode)
		{
			return default(bool);
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7ED")]
		[Address(RVA = "0x17A1AFC", Offset = "0x17A1AFC", VA = "0x7BBBFA1AFC")]
		public string GetLoadoutTutorial(uint loadoutID)
		{
			return null;
		}

		// Token: 0x0600B7EE RID: 47086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7EE")]
		[Address(RVA = "0x17A1CBC", Offset = "0x17A1CBC", VA = "0x7BBBFA1CBC")]
		public string GetGachaTutorial(int gachaID)
		{
			return null;
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7EF")]
		[Address(RVA = "0x17A1E7C", Offset = "0x17A1E7C", VA = "0x7BBBFA1E7C")]
		public WebTutorialDataManager()
		{
		}

		// Token: 0x0400BA11 RID: 47633
		[Token(Token = "0x400BA11")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<WebTutorialType, List<WebTutorialData>> m_webTutorialDataDic;

		// Token: 0x0200203E RID: 8254
		[Token(Token = "0x200203E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD8D4", Offset = "0x10FD8D4")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600B7F0 RID: 47088 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7F0")]
			[Address(RVA = "0x17A173C", Offset = "0x17A173C", VA = "0x7BBBFA173C")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0600B7F1 RID: 47089 RVA: 0x00034980 File Offset: 0x00032B80
			[Token(Token = "0x600B7F1")]
			[Address(RVA = "0x17A207C", Offset = "0x17A207C", VA = "0x7BBBFA207C")]
			internal bool <GetWebUrlByType>b__0(WebTutorialData temp)
			{
				return default(bool);
			}

			// Token: 0x0400BA12 RID: 47634
			[Token(Token = "0x400BA12")]
			[FieldOffset(Offset = "0x10")]
			public string regionServer;
		}

		// Token: 0x0200203F RID: 8255
		[Token(Token = "0x200203F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD8E4", Offset = "0x10FD8E4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B7F3 RID: 47091 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7F3")]
			[Address(RVA = "0x17A1F78", Offset = "0x17A1F78", VA = "0x7BBBFA1F78")]
			public <>c()
			{
			}

			// Token: 0x0600B7F4 RID: 47092 RVA: 0x00034998 File Offset: 0x00032B98
			[Token(Token = "0x600B7F4")]
			[Address(RVA = "0x17A1F80", Offset = "0x17A1F80", VA = "0x7BBBFA1F80")]
			internal bool <GetWebUrlByType>b__6_1(WebTutorialData temp)
			{
				return default(bool);
			}

			// Token: 0x0600B7F5 RID: 47093 RVA: 0x000349B0 File Offset: 0x00032BB0
			[Token(Token = "0x600B7F5")]
			[Address(RVA = "0x17A1FE0", Offset = "0x17A1FE0", VA = "0x7BBBFA1FE0")]
			internal bool <GetWebUrlByType>b__6_2(WebTutorialData temp)
			{
				return default(bool);
			}

			// Token: 0x0400BA13 RID: 47635
			[Token(Token = "0x400BA13")]
			[FieldOffset(Offset = "0x0")]
			public static readonly WebTutorialDataManager.<>c <>9;

			// Token: 0x0400BA14 RID: 47636
			[Token(Token = "0x400BA14")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<WebTutorialData> <>9__6_1;

			// Token: 0x0400BA15 RID: 47637
			[Token(Token = "0x400BA15")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<WebTutorialData> <>9__6_2;
		}

		// Token: 0x02002040 RID: 8256
		[Token(Token = "0x2002040")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD8F4", Offset = "0x10FD8F4")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x0600B7F6 RID: 47094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7F6")]
			[Address(RVA = "0x17A19AC", Offset = "0x17A19AC", VA = "0x7BBBFA19AC")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x0600B7F7 RID: 47095 RVA: 0x000349C8 File Offset: 0x00032BC8
			[Token(Token = "0x600B7F7")]
			[Address(RVA = "0x17A20B4", Offset = "0x17A20B4", VA = "0x7BBBFA20B4")]
			internal bool <GetGameModeTutorial>b__0(WebTutorialData a)
			{
				return default(bool);
			}

			// Token: 0x0600B7F8 RID: 47096 RVA: 0x000349E0 File Offset: 0x00032BE0
			[Token(Token = "0x600B7F8")]
			[Address(RVA = "0x17A2108", Offset = "0x17A2108", VA = "0x7BBBFA2108")]
			internal bool <GetGameModeTutorial>b__1(WebTutorialData a)
			{
				return default(bool);
			}

			// Token: 0x0400BA16 RID: 47638
			[Token(Token = "0x400BA16")]
			[FieldOffset(Offset = "0x10")]
			public int gameMode;

			// Token: 0x0400BA17 RID: 47639
			[Token(Token = "0x400BA17")]
			[FieldOffset(Offset = "0x14")]
			public int matchMode;
		}

		// Token: 0x02002041 RID: 8257
		[Token(Token = "0x2002041")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD904", Offset = "0x10FD904")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600B7F9 RID: 47097 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7F9")]
			[Address(RVA = "0x17A1AF4", Offset = "0x17A1AF4", VA = "0x7BBBFA1AF4")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x0600B7FA RID: 47098 RVA: 0x000349F8 File Offset: 0x00032BF8
			[Token(Token = "0x600B7FA")]
			[Address(RVA = "0x17A2144", Offset = "0x17A2144", VA = "0x7BBBFA2144")]
			internal bool <IsVersionGameModeTutorial>b__0(WebTutorialData a)
			{
				return default(bool);
			}

			// Token: 0x0400BA18 RID: 47640
			[Token(Token = "0x400BA18")]
			[FieldOffset(Offset = "0x10")]
			public int gameMode;

			// Token: 0x0400BA19 RID: 47641
			[Token(Token = "0x400BA19")]
			[FieldOffset(Offset = "0x14")]
			public int matchMode;
		}

		// Token: 0x02002042 RID: 8258
		[Token(Token = "0x2002042")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD914", Offset = "0x10FD914")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x0600B7FB RID: 47099 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7FB")]
			[Address(RVA = "0x17A1CB4", Offset = "0x17A1CB4", VA = "0x7BBBFA1CB4")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x0600B7FC RID: 47100 RVA: 0x00034A10 File Offset: 0x00032C10
			[Token(Token = "0x600B7FC")]
			[Address(RVA = "0x17A2198", Offset = "0x17A2198", VA = "0x7BBBFA2198")]
			internal bool <GetLoadoutTutorial>b__0(WebTutorialData a)
			{
				return default(bool);
			}

			// Token: 0x0400BA1A RID: 47642
			[Token(Token = "0x400BA1A")]
			[FieldOffset(Offset = "0x10")]
			public uint loadoutID;
		}

		// Token: 0x02002043 RID: 8259
		[Token(Token = "0x2002043")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD924", Offset = "0x10FD924")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600B7FD RID: 47101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7FD")]
			[Address(RVA = "0x17A1E74", Offset = "0x17A1E74", VA = "0x7BBBFA1E74")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x0600B7FE RID: 47102 RVA: 0x00034A28 File Offset: 0x00032C28
			[Token(Token = "0x600B7FE")]
			[Address(RVA = "0x17A2040", Offset = "0x17A2040", VA = "0x7BBBFA2040")]
			internal bool <GetGachaTutorial>b__0(WebTutorialData a)
			{
				return default(bool);
			}

			// Token: 0x0400BA1B RID: 47643
			[Token(Token = "0x400BA1B")]
			[FieldOffset(Offset = "0x10")]
			public int gachaID;
		}
	}
}
