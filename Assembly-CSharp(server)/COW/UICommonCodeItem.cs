using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001742 RID: 5954
	[Token(Token = "0x2001742")]
	internal class UICommonCodeItem : MonoBehaviour
	{
		// Token: 0x06006FFC RID: 28668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFC")]
		[Address(RVA = "0x20AF8BC", Offset = "0x20AF8BC", VA = "0x7BBC8AF8BC")]
		public void SetUIData(int index, [Optional] Action<object> callback)
		{
		}

		// Token: 0x06006FFD RID: 28669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006FFD")]
		[Address(RVA = "0x20B0658", Offset = "0x20B0658", VA = "0x7BBC8B0658")]
		public static string GetInputCodeString(int index)
		{
			return null;
		}

		// Token: 0x06006FFE RID: 28670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFE")]
		[Address(RVA = "0x20B0948", Offset = "0x20B0948", VA = "0x7BBC8B0948")]
		public void ButtonColorHL(bool v)
		{
		}

		// Token: 0x06006FFF RID: 28671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFF")]
		[Address(RVA = "0x20B0E50", Offset = "0x20B0E50", VA = "0x7BBC8B0E50")]
		public UICommonCodeItem()
		{
		}

		// Token: 0x040089F3 RID: 35315
		[Token(Token = "0x40089F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIToggleButton Toggle;

		// Token: 0x040089F4 RID: 35316
		[Token(Token = "0x40089F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UILabel Code;

		// Token: 0x040089F5 RID: 35317
		[Token(Token = "0x40089F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UISprite IconSprite;

		// Token: 0x040089F6 RID: 35318
		[Token(Token = "0x40089F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UISprite BgSprite;

		// Token: 0x040089F7 RID: 35319
		[Token(Token = "0x40089F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_Index;

		// Token: 0x040089F8 RID: 35320
		[Token(Token = "0x40089F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int INPUT_DELETE_INDEX;

		// Token: 0x040089F9 RID: 35321
		[Token(Token = "0x40089F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int INPUT_ZERO_INDEX;

		// Token: 0x040089FA RID: 35322
		[Token(Token = "0x40089FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int INPUT_CONFIRM_INDEX;

		// Token: 0x040089FB RID: 35323
		[Token(Token = "0x40089FB")]
		private const uint CODE_BG_COLOR = 3705265151U;

		// Token: 0x040089FC RID: 35324
		[Token(Token = "0x40089FC")]
		private const uint ICON_BG_COLOR = 4290380031U;

		// Token: 0x040089FD RID: 35325
		[Token(Token = "0x40089FD")]
		private const uint ICON_BG_COLOR_DISABLE = 2456420607U;

		// Token: 0x02001743 RID: 5955
		[Token(Token = "0x2001743")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1D54", Offset = "0x10F1D54")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x06007001 RID: 28673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007001")]
			[Address(RVA = "0x20B0E48", Offset = "0x20B0E48", VA = "0x7BBC8B0E48")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x06007002 RID: 28674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007002")]
			[Address(RVA = "0x20B0ECC", Offset = "0x20B0ECC", VA = "0x7BBC8B0ECC")]
			internal void <SetUIData>b__0()
			{
			}

			// Token: 0x040089FE RID: 35326
			[Token(Token = "0x40089FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<object> callback;

			// Token: 0x040089FF RID: 35327
			[Token(Token = "0x40089FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UICommonCodeItem <>4__this;
		}
	}
}
