using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C6B RID: 7275
	[Token(Token = "0x2001C6B")]
	public class UIToggleValue
	{
		// Token: 0x06009E99 RID: 40601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E99")]
		[Address(RVA = "0x1F55330", Offset = "0x1F55330", VA = "0x7BBC755330")]
		public UIToggleValue(int value, UIToggle toggle)
		{
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E9A")]
		[Address(RVA = "0x1F5536C", Offset = "0x1F5536C", VA = "0x7BBC75536C")]
		public void SetUIToggleLabel(UILabel label)
		{
		}

		// Token: 0x0400A4FB RID: 42235
		[Token(Token = "0x400A4FB")]
		[FieldOffset(Offset = "0x10")]
		public int m_Content;

		// Token: 0x0400A4FC RID: 42236
		[Token(Token = "0x400A4FC")]
		[FieldOffset(Offset = "0x18")]
		public UIToggle m_Toggle;

		// Token: 0x0400A4FD RID: 42237
		[Token(Token = "0x400A4FD")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_Label;
	}
}
