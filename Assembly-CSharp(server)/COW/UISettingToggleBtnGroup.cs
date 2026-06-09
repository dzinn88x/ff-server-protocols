using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C68 RID: 7272
	[Token(Token = "0x2001C68")]
	public class UISettingToggleBtnGroup : UIToggleButtonGroup
	{
		// Token: 0x06009E89 RID: 40585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E89")]
		[Address(RVA = "0x16362A0", Offset = "0x16362A0", VA = "0x7BBBE362A0", Slot = "4")]
		protected override void OnAwake()
		{
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E8A")]
		[Address(RVA = "0x1636428", Offset = "0x1636428", VA = "0x7BBBE36428", Slot = "5")]
		public override void OnSelectButton(UIToggleButton selectedButton)
		{
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E8B")]
		[Address(RVA = "0x16365E4", Offset = "0x16365E4", VA = "0x7BBBE365E4")]
		public UISettingToggleBtnGroup()
		{
		}

		// Token: 0x0400A4E7 RID: 42215
		[Token(Token = "0x400A4E7")]
		[FieldOffset(Offset = "0x40")]
		public int[] m_Contents;

		// Token: 0x0400A4E8 RID: 42216
		[Token(Token = "0x400A4E8")]
		[FieldOffset(Offset = "0x48")]
		public string m_SettingKey;

		// Token: 0x0400A4E9 RID: 42217
		[Token(Token = "0x400A4E9")]
		[FieldOffset(Offset = "0x50")]
		public int m_DefaultContent;

		// Token: 0x0400A4EA RID: 42218
		[Token(Token = "0x400A4EA")]
		[FieldOffset(Offset = "0x58")]
		public OnToggleGroupValueChange OnToggleValueChange;

		// Token: 0x0400A4EB RID: 42219
		[Token(Token = "0x400A4EB")]
		[FieldOffset(Offset = "0x60")]
		private bool m_HasInit;
	}
}
